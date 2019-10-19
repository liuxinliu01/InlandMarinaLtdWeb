//Package part created by John

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

namespace CMPP248VB
{
    public partial class AddModifyPackage : Form
    {
        //public Package mainForm; // link to the main form
        public bool isAdd;              // main form sets it
        public bool ReadOnly;            // main form sets it
        public bool isAddFullPackage;
        public bool fullPackageModified;
        public Package currentPackage;  // main form sets it
        decimal? commission;
        DateTime? starttime;
        DateTime? endtime;
        List<Products_Supplier> ProductSupplierList = new List<Products_Supplier>();
        public AddModifyPackage()
        {
            InitializeComponent();
        }

        private void AddModifyPackage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            if (isAdd)
            {
                packageIdTextBox.Enabled = false; //PackageID is indentity.
                pkgNameTextBox.Focus(); // focus of the package name text box
                // make textboix invisible
                productSupplierLabel.Visible = false;
                productNameLabel.Visible = false;
                supplierNameLabel.Visible = false;
                productNameLabel.Visible = false;
                productSupplierListbox.Visible = false;
                addsupplierButton.Visible = false;
                deleteSupplierButton.Visible = false;
                productComboBox.Visible = false;
                supplierComboBox.Visible = false;
                this.Size = new System.Drawing.Size(450, 400);
            }          
            else if (isAddFullPackage)
            {
                
                pkgNameTextBox.Focus(); // focus of the package name text box
                this.Text = "Add Full Package";
                packageIdTextBox.Enabled = false;              
                loadProductComboBox();
                loadSupplierComboBox();

            }
            else if (fullPackageModified)
            {
                
                this.Text = "Edit Full Package";
                packageIdTextBox.Enabled = false;
                loadProductComboBox();
                loadSupplierComboBox();
                DisplayCurrentPackage(); // display data of the current product
            }
            else // it is Modify
            {
                DisplayCurrentPackage(); // display data of the current product
                packageIdTextBox.Enabled = false; // code is not updatable
                pkgNameTextBox.Focus(); // focus on description
            }
        }
        //Method for load product list to the combobox
        private void loadProductComboBox()
        {
            try
            {
                using (PackageDataContext dbContext = new PackageDataContext())
                {
                    productComboBox.DataSource = dbContext.Products;
                    productComboBox.DisplayMember = "ProdName";
                    productComboBox.ValueMember = "ProductId";
                    productComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        //methid to load supplier list to combobox
        private void loadSupplierComboBox()
        {
            try
            {
                using (PackageDataContext dbContext = new PackageDataContext())
                {
                    supplierComboBox.DataSource = dbContext.Suppliers;
                    supplierComboBox.DisplayMember = "SupName";
                    supplierComboBox.ValueMember = "SupplierId";
                    supplierComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        //method load all information for the selected package
        private void DisplayCurrentPackage()
        {
            if (ReadOnly)
            {
                // display current Product data 
                packageIdTextBox.Text = currentPackage.PackageId.ToString();
                pkgNameTextBox.Text = currentPackage.PkgName;
                pkgDescTextBox.Text = currentPackage.PkgDesc.ToString();
                pkgBasePriceTextBox.Text = currentPackage.PkgBasePrice.ToString();
                if (currentPackage.PkgStartDate is null)
                {
                    pkgStartDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgStartDateDateTimePicker.Value = (DateTime)currentPackage.PkgStartDate;
                }
                if (currentPackage.PkgEndDate is null)
                {
                    pkgEndDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgEndDateDateTimePicker.Value = (DateTime)currentPackage.PkgEndDate;
                }

                pkgAgencyCommissionTextBox.Text = currentPackage.PkgAgencyCommission.ToString();

                try
                {
                    using (PackageDataContext dbContext = new PackageDataContext())
                    {

                        var product_Suppliers = from pps in dbContext.Packages_Products_Suppliers
                                                join pk in dbContext.Packages
                                                on pps.PackageId equals pk.PackageId
                                                join ps in dbContext.Products_Suppliers
                                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                                join s in dbContext.Suppliers
                                                on ps.SupplierId equals s.SupplierId
                                                join p in dbContext.Products
                                                on ps.ProductId equals p.ProductId
                                                where pk.PackageId == currentPackage.PackageId
                                                select new
                                                {

                                                    s.SupName,
                                                    p.ProdName

                                                };


                        foreach (var ps in product_Suppliers)
                        {
                            productSupplierListbox.Items.Add($"Product Name: {ps.ProdName}, Product Supplier: {ps.SupName}");

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                // Read Only text box
                packageIdTextBox.Enabled = false;
                pkgNameTextBox.Enabled = false;
                pkgStartDateDateTimePicker.Enabled = false;
                pkgEndDateDateTimePicker.Enabled = false;
                pkgDescTextBox.Enabled = false;
                pkgBasePriceTextBox.Enabled = false;
                pkgAgencyCommissionTextBox.Enabled = false;
                productSupplierListbox.Enabled = false;
                CancelBtn.Visible = false;
                SavePackageBtn.Text = "OK";
             
                productNameLabel.Visible = false;
                supplierNameLabel.Visible = false;
                productNameLabel.Visible = false;               
                addsupplierButton.Visible = false;
                deleteSupplierButton.Visible = false;
                productComboBox.Visible = false;
                supplierComboBox.Visible = false;
             
            }
            else if (fullPackageModified)
            {
                // display current Product data 
                packageIdTextBox.Text = currentPackage.PackageId.ToString();
                pkgNameTextBox.Text = currentPackage.PkgName;
                pkgDescTextBox.Text = currentPackage.PkgDesc.ToString();
                pkgBasePriceTextBox.Text = currentPackage.PkgBasePrice.ToString();
                if (currentPackage.PkgStartDate is null)
                {
                    pkgStartDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgStartDateDateTimePicker.Value = (DateTime)currentPackage.PkgStartDate;
                }
                if (currentPackage.PkgEndDate is null)
                {
                    pkgEndDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgEndDateDateTimePicker.Value = (DateTime)currentPackage.PkgEndDate;
                }

                pkgAgencyCommissionTextBox.Text = currentPackage.PkgAgencyCommission.ToString();

                try
                {
                    using (PackageDataContext dbContext = new PackageDataContext())
                    {

                        var Product_Suppliers = from pps in dbContext.Packages_Products_Suppliers
                                                join pk in dbContext.Packages
                                                on pps.PackageId equals pk.PackageId
                                                join ps in dbContext.Products_Suppliers
                                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                                join s in dbContext.Suppliers
                                                on ps.SupplierId equals s.SupplierId
                                                join p in dbContext.Products
                                                on ps.ProductId equals p.ProductId
                                                where pk.PackageId == currentPackage.PackageId
                                                select new
                                                {
                                                    pps.ProductSupplierId,
                                                    s.SupplierId,
                                                    s.SupName,
                                                    p.ProductId,
                                                    p.ProdName

                                                };

                      
                        foreach (var ps in Product_Suppliers)
                        {
                            productSupplierListbox.Items.Add($"Product Name: {ps.ProdName}, Product Supplier: {ps.SupName}");
                            Products_Supplier newProduct_Supplier = new Products_Supplier();
                            newProduct_Supplier.ProductSupplierId = ps.ProductSupplierId;
                            newProduct_Supplier.SupplierId = ps.SupplierId;
                            newProduct_Supplier.ProductId = ps.ProductId;
                            ProductSupplierList.Add(newProduct_Supplier);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }              // Read Only text box
             

            }
            else
            {
                // display current Product data 
                packageIdTextBox.Text = currentPackage.PackageId.ToString();
                pkgNameTextBox.Text = currentPackage.PkgName;
                pkgDescTextBox.Text = currentPackage.PkgDesc.ToString();
                pkgBasePriceTextBox.Text = currentPackage.PkgBasePrice.ToString();
                if (currentPackage.PkgStartDate is null)
                {
                    pkgStartDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgStartDateDateTimePicker.Value = (DateTime)currentPackage.PkgStartDate;
                }
                if (currentPackage.PkgEndDate is null)
                {
                    pkgEndDateDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    pkgEndDateDateTimePicker.Value = (DateTime)currentPackage.PkgEndDate;
                }

                pkgAgencyCommissionTextBox.Text = currentPackage.PkgAgencyCommission.ToString();
                productSupplierLabel.Visible = false;
                productNameLabel.Visible = false;
                supplierNameLabel.Visible = false;
                productNameLabel.Visible = false;
                productSupplierListbox.Visible = false;
                addsupplierButton.Visible = false;
                deleteSupplierButton.Visible = false;
                productComboBox.Visible = false;
                supplierComboBox.Visible = false;
                this.Size = new System.Drawing.Size(450, 400);
            }
           

        }
        private void ClearTextBoxes()
        {
            packageIdTextBox.Text = "";
            pkgNameTextBox.Text = "";
            pkgDescTextBox.Text = "";
            pkgBasePriceTextBox.Text = "";
            pkgStartDateDateTimePicker.Value = DateTime.Now;
            pkgEndDateDateTimePicker.Value = DateTime.Now;
            pkgAgencyCommissionTextBox.Text = "";
        }
        private void addsupplierButton_Click(object sender, EventArgs e)
        {
            // make sure that a product  is selected first before adding a product
            int productIndex =productComboBox.SelectedIndex;
            // make sure that a product  is selected first before adding a product
            int SupplierIndex = supplierComboBox.SelectedIndex;
            // make sure that a course is selected
            if (productIndex == -1)
            {
                MessageBox.Show("Must select a product first");
                return;
            }
            if (productIndex == -1)
            {
                MessageBox.Show("Must select a supplier first");
                return;
            }
      
            {
                try
                {
                    using (PackageDataContext dbContext = new PackageDataContext())
                    {
                        Products_Supplier newProduct_Supplier = new Products_Supplier // create product supplier using provided data
                        {
                            ProductId = (int)productComboBox.SelectedValue,

                            SupplierId = (int)supplierComboBox.SelectedValue

                        };
                        // insert through data context object from the main form

                        dbContext.Products_Suppliers.InsertOnSubmit(newProduct_Supplier);
                        dbContext.SubmitChanges(); // submit to the database
                        var newProduct_SupplierDB = (from ps in dbContext.Products_Suppliers
                                                     orderby ps.ProductSupplierId descending
                                                     select ps).FirstOrDefault();
                        newProduct_Supplier.ProductSupplierId = newProduct_SupplierDB.ProductSupplierId;
                        ProductSupplierList.Add(newProduct_Supplier);
                        var ProductName = (from p in dbContext.Products
                                           where p.ProductId == newProduct_Supplier.ProductId
                                           select p).FirstOrDefault();
                        var SupplierName = (from ps in dbContext.Suppliers
                                            where ps.SupplierId == newProduct_Supplier.SupplierId
                                            select ps).FirstOrDefault();
                        productSupplierListbox.Items.Add($"Product Name: {ProductName.ProdName}, " +
                            $"Product Supplier: {SupplierName.SupName}");
                          

                        productComboBox.SelectedIndex = -1;
                        supplierComboBox.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    return;
                }
            }
          
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void nullable()
        {
            if (pkgAgencyCommissionTextBox.Text.Trim().Length == 0)
            {
                commission = null;
            }
            else
            {
                commission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text.Trim());
            }
            if (pkgStartDateDateTimePicker.Value.Day == DateTime.Now.Day)
            {
                starttime = null;
            }
            else
            {
                starttime = (DateTime)pkgStartDateDateTimePicker.Value;
            }
            if (pkgEndDateDateTimePicker.Value.Day == DateTime.Now.Day)
            {
                endtime = null;
            }
            else
            {
                endtime = (DateTime)pkgEndDateDateTimePicker.Value;
            }
        }
        private void SavePackageBtn_Click(object sender, EventArgs e)
        {

            if (isAdd)
            {

                if (// coded below in this form
                    Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                    Validator.IsPresent(pkgDescTextBox)&&
                    Validator.IsCorrectLength(pkgDescTextBox, 200)&&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNotTooEarly(pkgStartDateDateTimePicker) &&
                    Validator.IsNotTooEarly(pkgEndDateDateTimePicker)
                    )
                // replace with data validation: all fields provided, code unique, 
                // base price and Commission appropriate numeric type and non-negative
                // start date and end date later than today
                {
                    nullable();
                    Package newPackage = new Package // create package using provided data
                    {
                        //PackageId = Convert.ToInt32(packageIdTextBox.Text.Trim()),
                        PkgName = pkgNameTextBox.Text.Trim(),
                        PkgDesc = pkgDescTextBox.Text.Trim(),
                        PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text.Trim()),
                        PkgStartDate = starttime,
                        PkgEndDate = endtime,
                        PkgAgencyCommission = commission,
                        ImageFile = pkgNameTextBox.Text.Trim() + ".jpg"
                    };
                    using (PackageDataContext dbContext = new PackageDataContext())
                    {
                        // insert through data context object from the main form
                        dbContext.Packages.InsertOnSubmit(newPackage);
                        dbContext.SubmitChanges(); // submit to the database
                      
                    }
                    DialogResult = DialogResult.OK;
                }
                else // validation  failed
                {
                    
                    return;
                }
            }
            else if (isAddFullPackage)
            {
                if (// coded below in this form
                 Validator.IsPresent(pkgNameTextBox) &&
                 Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                 Validator.IsPresent(pkgDescTextBox) &&
                 Validator.IsCorrectLength(pkgDescTextBox, 200) &&
                 Validator.IsPresent(pkgBasePriceTextBox) &&
                 Validator.IsDecimal(pkgBasePriceTextBox) &&
                 Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                 Validator.IsNotTooEarly(pkgStartDateDateTimePicker) &&
                 Validator.IsNotTooEarly(pkgEndDateDateTimePicker)
                 )
                // replace with data validation: all fields provided, code unique, 
                // base price and Commission appropriate numeric type and non-negative
                // start date and end date later than today
                {
                    try
                    {
                        using (PackageDataContext dbContext = new PackageDataContext())
                        {
                            nullable();
                            Package newPackage = new Package // create package using provided data
                            {
                                //PackageId = Convert.ToInt32(packageIdTextBox.Text.Trim()),
                                PkgName = pkgNameTextBox.Text.Trim(),
                                PkgDesc = pkgDescTextBox.Text.Trim(),
                                PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text.Trim()),
                                PkgStartDate = starttime,
                                PkgEndDate = endtime,
                                PkgAgencyCommission = commission,
                                ImageFile = pkgNameTextBox.Text.Trim() + ".jpg"
                            };
                            dbContext.Packages.InsertOnSubmit(newPackage);
                            dbContext.SubmitChanges(); // submit to the database
                            foreach (Products_Supplier ps in ProductSupplierList)
                            {                          
                                Packages_Products_Supplier newPackage_Product_Supplier = new Packages_Products_Supplier // create product supplier using provided data
                                {
                                    PackageId = newPackage.PackageId,
                                    ProductSupplierId = ps.ProductSupplierId

                                };
                                // insert through data context object from the main form
                                dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPackage_Product_Supplier);
                                dbContext.SubmitChanges(); // submit to the database
                            }
                            ProductSupplierList.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        return;
                    }
                }
            }
            else if (fullPackageModified)// it is Modify
            {
                nullable();
                if (
                    Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                    Validator.IsPresent(pkgDescTextBox) &&
                    Validator.IsCorrectLength(pkgDescTextBox, 200) &&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNotTooEarly(pkgStartDateDateTimePicker) &&
                    Validator.IsNotTooEarly(pkgEndDateDateTimePicker) 
                
                    )
                {
                    try
                    {
                        using (PackageDataContext dbContext = new PackageDataContext())
                        {
                            // get the Package with Code from the current text box
                            Package pack = dbContext.Packages.Single(p => p.PackageId == Convert.ToInt32(packageIdTextBox.Text.Trim()));

                            //Product prod = dbContext.Products.Single(p => p.ProdName == prodNameComboBox.Text.Trim());
                            //Supplier supp = dbContext.Suppliers.Single(s => s.SupName == supNameComboBox.Text.Trim());
                            //Products_Supplier proSup = dbContext.Products_Suppliers.Single(p => p.ProductId == prod[""]&&)
                            if (pack != null)
                            {
                                // make changes by copying values from text boxes
                                pack.PkgName = pkgNameTextBox.Text.Trim();
                                pack.PkgDesc = pkgDescTextBox.Text.Trim();
                                pack.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text.Trim());
                                pack.PkgStartDate = starttime;
                                pack.PkgEndDate = endtime;
                                pack.PkgAgencyCommission = commission;
                                pack.ImageFile = pkgNameTextBox.Text.Trim() + ".jpg";

                                //pack.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text.Trim());
                                // submit changes 

                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                                int currentPackageID = pack.PackageId;
                                List<Packages_Products_Supplier> newProduct_SupplierDB = (from ps in dbContext.Packages_Products_Suppliers
                                                                                          where ps.PackageId == pack.PackageId
                                                                                          select ps).ToList();
                                List<int> currentPSList=new List<int>();
                                foreach(Packages_Products_Supplier pps in newProduct_SupplierDB)
                                {
                                    currentPSList.Add(pps.ProductSupplierId);
                                }
                                foreach (Products_Supplier ps in ProductSupplierList)
                                {
                                    if (!currentPSList.Contains(ps.ProductSupplierId))
                                    {
                                        Packages_Products_Supplier newPackage_Product_Supplier = new Packages_Products_Supplier // create product supplier using provided data
                                        {
                                            PackageId = pack.PackageId,
                                            ProductSupplierId = ps.ProductSupplierId
                                        };
                                        // insert through data context object from the main form
                                        dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPackage_Product_Supplier);
                                        dbContext.SubmitChanges(); // submit to the database
                                    }
                                    
                                }
                                ProductSupplierList.Clear();

                            }
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                        DialogResult = DialogResult.Retry;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // validation failed
                {
                    //DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else // it is Modify
            {
                nullable();
                if (
                    Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                    Validator.IsPresent(pkgDescTextBox) &&
                    Validator.IsCorrectLength(pkgDescTextBox, 200) &&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNotTooEarly(pkgStartDateDateTimePicker) &&
                    Validator.IsNotTooEarly(pkgEndDateDateTimePicker)
                  
                    )
                {
                    try
                    {
                        using (PackageDataContext dbContext = new PackageDataContext())
                        {
                            // get the Package with Code from the current text box
                            Package pack = dbContext.Packages.Single(p => p.PackageId == Convert.ToInt32(packageIdTextBox.Text.Trim()));
                            //Product prod = dbContext.Products.Single(p => p.ProdName == prodNameComboBox.Text.Trim());
                            //Supplier supp = dbContext.Suppliers.Single(s => s.SupName == supNameComboBox.Text.Trim());
                            //Products_Supplier proSup = dbContext.Products_Suppliers.Single(p => p.ProductId == prod[""]&&)
                            if (pack != null)
                            {
                                // make changes by copying values from text boxes
                                pack.PkgName = pkgNameTextBox.Text.Trim();
                                pack.PkgDesc = pkgDescTextBox.Text.Trim();
                                pack.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text.Trim());
                                pack.PkgStartDate = starttime;
                                pack.PkgEndDate = endtime;
                                pack.PkgAgencyCommission = commission;
                                pack.ImageFile = pkgNameTextBox.Text.Trim() + ".jpg";
                                //pack.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text.Trim());
                                // submit changes 
                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                        DialogResult = DialogResult.Retry;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // validation failed
                {
                    //DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            DialogResult = DialogResult.OK;
        }
         private void deleteSupplierButton_Click(object sender, EventArgs e)
         {
            // make sure that someon is selected before displaying the information
            int index = productSupplierListbox.SelectedIndex;
            // make sure that a course is selected
            if (index == -1)
            {
                MessageBox.Show("Must select a course first");
                return;
            }
            // issue a a confirmation dialog
            DialogResult result1 = MessageBox.Show($"Do you wish to delete " +
               $"{ProductSupplierList[index]} course?", "Confirmation Message", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                // remove the item from the database and 
                //remove selected item from both the display the display list box
                // and the backiging store list also
                using (PackageDataContext dbContext = new PackageDataContext())
                {
                    try  //use try and linq to delete the only select one.
                    {
                        Products_Supplier currentPS = (from p in dbContext.Products_Suppliers
                                                       where p.ProductSupplierId == ProductSupplierList[index].ProductSupplierId
                                                       select p).Single();
                        dbContext.Products_Suppliers.DeleteOnSubmit(currentPS);
                        dbContext.SubmitChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                ProductSupplierList.RemoveAt(productSupplierListbox.SelectedIndex);
                productSupplierListbox.Items.RemoveAt(productSupplierListbox.SelectedIndex);
            }
        }
        private bool IsUniqueID(TextBox packageIdTextBox)
        {
            Package pack = null;
            using (PackageDataContext dbContext = new PackageDataContext())
            {
                pack = (from p in dbContext.Packages
                        where p.PackageId == Convert.ToInt32(packageIdTextBox.Text.Trim())
                        select p).SingleOrDefault();

                //dbContext.Products.Single(p => p.ProductCode == productCodeTextBox.Text);
                if (pack != null) // there is another product with same code
                {
                    MessageBox.Show("Package ID must be unique", "Entry Error");
                    return false;
                }
                else
                    return true;
            }
        }

       
    }
}
