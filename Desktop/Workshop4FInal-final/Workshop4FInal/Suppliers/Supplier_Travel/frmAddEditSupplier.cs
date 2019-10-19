//Created by Bachir

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier_Travel
{
    public partial class frmAddEditSupplier : Form
    {
        public bool EditMode = false;
        public Supplier exsistingSupplier; 
        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (!EditMode) //if adding a Supplier
            {
                Supplier newSupplier = new Supplier //create a new Supplier from user input
                {
                    SupplierId = int.Parse(supplierIdTextBox.Text),
                    SupName = supNameTextBox.Text
                };
                using (SupplierDataContext dataContext = new SupplierDataContext())
                {
                    //insert through data context from the main form
                    dataContext.Suppliers.InsertOnSubmit(newSupplier);
                    dataContext.SubmitChanges(); //submit to the database
                }
                DialogResult = DialogResult.OK;
            }
            else //if editing Supplier 
            {
                try
                {
                    using (SupplierDataContext dataContext = new SupplierDataContext())
                    {
                        //get the product ID from current text box
                        Supplier supplier = dataContext.Suppliers.Single(p => p.SupplierId.ToString() == supplierIdTextBox.Text);

                        if (supplier != null)
                        {
                            supplier.SupName = supNameTextBox.Text;
                            //submit changes
                            dataContext.SubmitChanges();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (ChangeConflictException)
                {
                    MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                    DialogResult = DialogResult.Retry;
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, excp.GetType().ToString());
                }
            }
        }

        private void CancelAddSupplierButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
