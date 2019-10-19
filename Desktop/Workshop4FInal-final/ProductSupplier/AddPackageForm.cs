using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSupplier
{
    public partial class AddPackageForm : Form
    {
        public bool isAddPackage;
        public List<Products_Supplier> ProductSupplierList = new List<Products_Supplier>();
        public AddPackageForm()
        {
            InitializeComponent();
        }
        private void AddPackageForm_Load(object sender, EventArgs e)
        {
            // loading the data to in the product supplier list 
            using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
            {
                productListGridView.DataSource = dbContext.Products_Suppliers;

                foreach (Products_Supplier ps in dbContext.Products_Suppliers)
                {
                    ProductSupplierList.Add(ps);
                }
            }
            if (isAddPackage)
            {
                packageIDTextBox.Enabled = false;

            }

        }

        private void AddPackageButton_Click(object sender, EventArgs e)
        {
         
        }

        ///////***********************************************************/////////
        
        private void AddSupplierProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModifySupplierProductForm amspf = new AddModifySupplierProductForm();
            amspf.isAdd = true;

            DialogResult result = amspf.ShowDialog();
            if (result == DialogResult.OK) // new row got inserted
            {

                ProductSupplierList.Add(amspf.currentProductSupplier);
                productSupplierListbox.Items.Add($"ProductSupplierID: {ProductSupplierList.Count}:::ProductID: {amspf.currentProductSupplier.ProductId}, " +
                    $"SupplierID: {amspf.currentProductSupplier.SupplierId}");
                RefreshGridView();
            }



        }
        private void RefreshGridView()
        {
            using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
            {
                productListGridView.DataSource = dbContext.Products_Suppliers;
            }
        }


        private void EditSupplierProductToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ///////////////////////////////////////////////
            int rowNum = productListGridView.CurrentCell.RowIndex;

            AddModifySupplierProductForm amspf = new AddModifySupplierProductForm();
            amspf.isAdd = false;
            amspf.currentProductSupplier = ProductSupplierList[rowNum];
            DialogResult result = amspf.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }


        }

        private void DeleteSupplierProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the key of the current product in the data grid view
            int rowNum = productListGridView.CurrentCell.RowIndex;
            Products_Supplier ps = ProductSupplierList[rowNum];
            DialogResult answer = MessageBox.Show($"Are you sure you want to delete{ps.ProductSupplierId} ?",
                "Confirmation Message", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
                {
                    try
                    {
                        //Delete and update the grid view information
                        Products_Supplier currentProductSupplier = dbContext.Products_Suppliers.SingleOrDefault(x => x.ProductSupplierId == ps.ProductSupplierId);
                        dbContext.Products_Suppliers.DeleteOnSubmit(currentProductSupplier);
                        dbContext.SubmitChanges();
                        ProductSupplierList.RemoveAt(rowNum);
                        RefreshGridView();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
