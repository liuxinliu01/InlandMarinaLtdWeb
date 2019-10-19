using LINQ_to_SQL_Demo;
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

namespace ProductSupplier
{
    public partial class AddModifySupplierProductForm : Form
    {
        public bool isAdd;
        public Products_Supplier currentProductSupplier;



        public AddModifySupplierProductForm()
        {
            InitializeComponent();
        }

        private void AddModifySupplierProductForm_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                this.Text = "Add Supplier and Products";
                productSupplierIDTextbox.Enabled = false;
               


            }
            else
            {
                this.Text = "Modifier Supplier and Products";
                DisplayCurrentProductSupplier();
                productSupplierIDTextbox.Enabled = false;
            }
        }

        private void DisplayCurrentProductSupplier()
        {
            productSupplierIDTextbox.Text = currentProductSupplier.ProductSupplierId.ToString();
            productIDTextbox.Text = currentProductSupplier.ProductId.ToString();
            supplierIDtextbox.Text = currentProductSupplier.SupplierId.ToString();
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            
            if (isAdd)
            {
                if (
                       Validator.IsInt32(productIDTextbox) && Validator.IsNonNegativeInt(productIDTextbox) &&
                       Validator.IsInt32(supplierIDtextbox) && Validator.IsNonNegativeInt(supplierIDtextbox) 
                      
                     )
                {

                    try
                    {
                        using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
                        {
                            Products_Supplier newProduct_Supplier = new Products_Supplier // create product supplier using provided data
                            {
                                ProductId = int.Parse(productIDTextbox.Text),

                                SupplierId = int.Parse(supplierIDtextbox.Text)

                            };
                            // insert through data context object from the main form

                            dbContext.Products_Suppliers.InsertOnSubmit(newProduct_Supplier);
                            dbContext.SubmitChanges(); // submit to the database
                            currentProductSupplier = newProduct_Supplier;
                        }
                    }               
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        return;
                    }

                   
                    DialogResult = DialogResult.OK;
                }
                else // validation  failed
                {
                    return;
                }
            }
            else // it is Modify
            {
                if (Validator.IsInt32(productIDTextbox) && Validator.IsNonNegativeInt(productIDTextbox) &&
                       Validator.IsInt32(supplierIDtextbox) && Validator.IsNonNegativeInt(supplierIDtextbox)
                    )
                {
                    try
                    {
                        using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
                        {
                            // get the product with Code from the current text box
                            Products_Supplier ps = dbContext.Products_Suppliers.Single(p => p.ProductSupplierId == int.Parse( productSupplierIDTextbox.Text));

                            //MessageBox.Show("Testing concurrency: update or delete current record from SSMS and click OK");

                            if (ps != null)
                            {
                                // make changes by copying values from text boxes
                                ps.ProductId = int.Parse(productIDTextbox.Text);
                                ps.SupplierId = int.Parse(supplierIDtextbox.Text);
                                //submit
                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        return;
                    }
                }
                else // validation failed
                {
                   return;
                }
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
        
            DialogResult= DialogResult.Cancel;
        }
        private bool IsUniqueCode(TextBox productCodeTextBox)
        {
            Products_Supplier ps = null;
            using (ProductSuppliersDataContext dbContext = new ProductSuppliersDataContext())
            {
                ps = (from p in dbContext.Products_Suppliers
                        where p.ProductSupplierId == int.Parse( productCodeTextBox.Text)
                        select p).SingleOrDefault();

                //dbContext.Products.Single(p => p.ProductCode == productCodeTextBox.Text);
                if (ps != null) // there is another product with same code
                {
                    MessageBox.Show("Product code must be unique", "Entry Error");
                    return false;
                }
                else
                    return true;
            }
        }
    }
}
