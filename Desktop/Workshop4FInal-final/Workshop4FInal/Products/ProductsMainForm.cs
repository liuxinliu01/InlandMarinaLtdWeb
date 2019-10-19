using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class ProductsMainForm : Form
    {
        public ProductsMainForm()
        {
            InitializeComponent();
        }

        private void ProductsMainForm_Load(object sender, EventArgs e)
        {
            using(ProductsDataContext dataContext = new ProductsDataContext())
            {
                //this loads the entire table
                productDataGridView.DataSource = dataContext.Products;
                //productDataGridView.DataSource = from prod in dataContext.Products
                //                                 select prod;
            }
           productDataGridView.BorderStyle = BorderStyle.None;
           productDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
           productDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
           productDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
           productDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
           productDataGridView.BackgroundColor = Color.White;

           productDataGridView.EnableHeadersVisualStyles = false;
           productDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
           productDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
           productDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddEditProductsForm addEditForm = new AddEditProductsForm();
            addEditForm.EditMode = false;
            addEditForm.existingProduct = null;
            DialogResult result = addEditForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                ReloadGridView();
            }
        }

        private void ReloadGridView()
        {
            ProductsDataContext dataContext = new ProductsDataContext();
            productDataGridView.DataSource = dataContext.Products;

        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            //get the key of the current product in the data grid view
            int rowNum = productDataGridView.CurrentCell.RowIndex;
            string prodID = productDataGridView["dataGridViewTextBoxColumn1", rowNum].Value.ToString();
            //create a current product object
            Product existingProduct;
            using(ProductsDataContext dataContext = new ProductsDataContext())
            {
                existingProduct = (from p in dataContext.Products
                                   where p.ProductId.ToString() == prodID
                                   select p).Single();
            }
            //instantiate the addeditproductsForm
            AddEditProductsForm addEditForm = new AddEditProductsForm();
            addEditForm.EditMode = true; //editing products
            addEditForm.existingProduct = existingProduct;
            DialogResult result = addEditForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                ReloadGridView();
            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
