//created by John, modified by Bachir, Kingsley, Mohammad, John

using Products;
using Supplier_Travel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMPP248VB
{
    public partial class MainForm : Form
    {
        private object frmSupplier;

        public MainForm()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            using (PackageDataContext dbContext = new PackageDataContext())
            {
                packagesDataGridView.DataSource = dbContext.Packages;
            }
            packagesDataGridView.BorderStyle = BorderStyle.None;
            packagesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            packagesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            packagesDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            packagesDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            packagesDataGridView.BackgroundColor = Color.White;

            packagesDataGridView.EnableHeadersVisualStyles = false;
            packagesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            packagesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            packagesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void AddPackageBtn_Click(object sender, EventArgs e)
        {
            AddModifyPackage secondForm = new AddModifyPackage();
            secondForm.isAdd = true;
            secondForm.currentPackage = null; // no current product when inserting
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                RefreshGridView();
            }
            DialogResult = DialogResult.OK;
        }
        private void RefreshGridView()
        {
            PackageDataContext dbContext = new PackageDataContext();
            packagesDataGridView.DataSource = dbContext.Packages;
        }

        private void ModifyPackageBtn_Click(object sender, EventArgs e)
        {
            /**/
            // get the key of the current package in the data grid view
            int rowNum = packagesDataGridView.CurrentCell.RowIndex; // index of the current row
            int packID = (int)packagesDataGridView["dataGridViewTextBoxColumn1", rowNum].Value; // Column for PackageID

            Package currentPackage;
            using (PackageDataContext dbContext = new PackageDataContext())
            {
                currentPackage = (from p in dbContext.Packages
                                  where p.PackageId == packID
                                  select p).Single();
            }

            AddModifyPackage secondForm = new AddModifyPackage();
            secondForm.isAdd = false; // it Modify
            secondForm.currentPackage = currentPackage;
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }
        }

        private void DeletePackageBtn_Click(object sender, EventArgs e)
        {
            int rowNum = packagesDataGridView.CurrentCell.RowIndex;
            int packageID = (int)packagesDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;
            DialogResult answer = MessageBox.Show("Are you sure you want to delete " + packageID + "?", "Confirm", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                using (PackageDataContext dbContext = new PackageDataContext())
                {
                    try  //use try and linq to delete the only select one.
                    {
                        Package currentPackage = (from p in dbContext.Packages
                                                  where p.PackageId == packageID
                                                  select p).Single();
                        List<Booking> currentBookings= (from p in dbContext.Bookings
                                                        where p.PackageId == packageID
                                                        select p).ToList();
                        foreach (Booking bk in currentBookings)
                        {
                            dbContext.Bookings.DeleteOnSubmit(bk);
                            dbContext.SubmitChanges();
                        }
                        List<Packages_Products_Supplier> currentPPS = (from p in dbContext.Packages_Products_Suppliers
                                                                 where p.PackageId == packageID
                                                                 select p).ToList();
                        foreach(Packages_Products_Supplier pps in currentPPS)
                        {
                            dbContext.Packages_Products_Suppliers.DeleteOnSubmit(pps);
                            dbContext.SubmitChanges();
                        }
                        
                        //dbContext.Packages_Products_Suppliers.DeleteOnSubmit(currentPPS);
                        //dbContext.SubmitChanges();
                        dbContext.Packages.DeleteOnSubmit(currentPackage);
                        dbContext.SubmitChanges();
                        RefreshGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            //int rowNum = packagesDataGridView.CurrentCell.RowIndex; // index of the current row
            //int packID = (int)(packagesDataGridView["dataGridViewTextBoxColumn1", rowNum].Value); // Column for PackageID

            //DialogResult answer = MessageBox.Show("Are you sure you want to delete " + packID + "?", "Confirm", MessageBoxButtons.OKCancel);
            //if (answer == DialogResult.OK)
            //{
            //    using (PackageDataContext dbContext = new PackageDataContext())
            //    {
            //        try  //use try and linq to delete the only select one.
            //        {
            //            Package currentPackage = (from p in dbContext.Packages
            //                                      where p.PackageId == packID
            //                                      select p).Single();

            //            dbContext.Packages.DeleteOnSubmit(currentPackage);

            //            dbContext.SubmitChanges();
            //            //refresh gridview
            //            RefreshGridView();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, ex.GetType().ToString());
            //        }
            //    }
            //}
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier supplierForm = new frmSupplier();
            DialogResult result = supplierForm.ShowDialog();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsMainForm productsForm = new ProductsMainForm();
            DialogResult result = productsForm.ShowDialog();
        }

      
        private void AddFullPackageBtn_Click(object sender, EventArgs e)
        {
            
            Package currentPackage=null;
       
            AddModifyPackage amf = new AddModifyPackage();
            amf.isAddFullPackage = true;
            //apf.currentPackage = PackageList[rowNum];
            amf.currentPackage = currentPackage;
            DialogResult result = amf.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshGridView();
            }
            DialogResult = DialogResult.OK;
        }
        private void ModifyFullPackageBtn_Click(object sender, EventArgs e)
        {
            int rowNum = packagesDataGridView.CurrentCell.RowIndex;
            int packageID = (int)packagesDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;
            Package currentPackage;
            using (PackageDataContext dbContext = new PackageDataContext())
            {
                currentPackage = (from p in dbContext.Packages
                                  where p.PackageId == packageID
                                  select p).Single();
            }
            AddModifyPackage amf = new AddModifyPackage();
            amf.fullPackageModified = true;
            //apf.currentPackage = PackageList[rowNum];
            amf.currentPackage = currentPackage;
            DialogResult result = amf.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshGridView();
            }
            DialogResult = DialogResult.OK;
        }
        private void fullPackageDetailBtn_Click(object sender, EventArgs e)
        {
            int rowNum = packagesDataGridView.CurrentCell.RowIndex;
            int packageID = (int)packagesDataGridView["dataGridViewTextBoxColumn1", rowNum].Value;
            Package currentPackage;
            using (PackageDataContext dbContext = new PackageDataContext())
            {
                currentPackage = (from p in dbContext.Packages
                                  where p.PackageId == packageID
                                  select p).Single();
            }
            AddModifyPackage amf = new AddModifyPackage();
            amf.ReadOnly = true;
            //apf.currentPackage = PackageList[rowNum];
            amf.currentPackage = currentPackage;
            DialogResult result = amf.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshGridView();
            }
            DialogResult = DialogResult.OK;
        }

        private void SuppliersModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PackagesExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
