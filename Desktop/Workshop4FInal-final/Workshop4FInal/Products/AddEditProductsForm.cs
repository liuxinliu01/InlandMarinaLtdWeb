//Created by Mohammad

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

namespace Products
{
    public partial class AddEditProductsForm : Form
    {
        public bool EditMode = false;
        public Product existingProduct;
        public AddEditProductsForm()
        {
            InitializeComponent();
        }

        private void AddEditProductsForm_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                ShowExistingProduct();
                this.Text = "Edit Products";
                productIdTextBox.Enabled = false;
                prodNameTextBox.Focus();
            }
            else
            {
                this.Text = "Add Products";
                productIdTextBox.Focus();
            }
        }

        private void ShowExistingProduct()
        {
            //dispaly exist product in the form
            productIdTextBox.Text = existingProduct.ProductId.ToString();
            prodNameTextBox.Text = existingProduct.ProdName;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (!EditMode) //if adding a product
            {
                //validate user input before sending to database
                if (ValidateProduct.IsNotEmpty(prodNameTextBox, "Product Name") &&
                    ValidateProduct.IsValidString(prodNameTextBox, "Product Name") &&
                    ValidateProduct.IsValidInteger(productIdTextBox, "Product ID") &&
                    ValidateProduct.IsNotEmpty(productIdTextBox, "Product ID") &&
                    IsExistingID(productIdTextBox))
                {
                    Product newProduct = new Product //create a new product from user input
                    {
                        ProductId = int.Parse(productIdTextBox.Text),
                        ProdName = prodNameTextBox.Text
                    };
                    using (ProductsDataContext dataContext = new ProductsDataContext())
                    {
                        //insert through data context from the main form
                        dataContext.Products.InsertOnSubmit(newProduct);
                        dataContext.SubmitChanges(); //submit to the database
                    }
                    DialogResult = DialogResult.OK;
                }

            }
            else //if editing products 
            {
                //validate data input
                if (ValidateProduct.IsNotEmpty(prodNameTextBox, "Product Name") &&
                    ValidateProduct.IsValidString(prodNameTextBox, "Product Name"))
                {
                    try
                    {
                        using (ProductsDataContext dataContext = new ProductsDataContext())
                        {
                            //get the product ID from current text box
                            Product product = dataContext.Products.Single(p => p.ProductId.ToString() == productIdTextBox.Text);

                            if (product != null)
                            {
                                product.ProdName = prodNameTextBox.Text;
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
        }


        //the method ensures unique product ID
        private bool IsExistingID(TextBox IDtextBox)
        {
            Product product = null;
            using (ProductsDataContext dataContext = new ProductsDataContext())
            {
                product = (from p in dataContext.Products
                           where p.ProductId.ToString() == IDtextBox.Text
                           select p).SingleOrDefault();
                //dataContext.Products.Single(p => p.ProductId.ToString() == IDtextBox.Text);
                if(product != null) // there is another product with same code
                {
                    MessageBox.Show("Product code must be unique", "Entry Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
