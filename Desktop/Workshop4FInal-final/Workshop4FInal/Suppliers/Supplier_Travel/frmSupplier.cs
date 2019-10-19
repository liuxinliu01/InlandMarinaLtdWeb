//Created by Bachir

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier_Travel
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            using (SupplierDataContext dataContext = new SupplierDataContext())
            {
                supplierDataGridView.DataSource = dataContext.Suppliers;
            }

            supplierDataGridView.BorderStyle = BorderStyle.None;
            supplierDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            supplierDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            supplierDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            supplierDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            supplierDataGridView.BackgroundColor = Color.White;

            supplierDataGridView.EnableHeadersVisualStyles = false;
            supplierDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            supplierDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            supplierDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frmAddEdit = new frmAddEditSupplier();
            frmAddEdit.EditMode = false;
            frmAddEdit.exsistingSupplier = null;
            DialogResult result = frmAddEdit.ShowDialog();
            if(result == DialogResult.OK)
            {
                reloadGridView();
            }

        }

        private void reloadGridView()
        {
            SupplierDataContext dataContext = new SupplierDataContext();
            supplierDataGridView.DataSource = dataContext.Suppliers;

        }

        private void EditSupplierButton_Click(object sender, EventArgs e)
        {
            //get the key of the current Supplier in the data grid view
            int rowNum = supplierDataGridView.CurrentCell.RowIndex;
            string supplierID = supplierDataGridView["dataGridViewTextBoxColumn1", rowNum].Value.ToString();
            //create a current Supplier object
            Supplier existingSupplier;
            using (SupplierDataContext dataContext = new SupplierDataContext())
            {
                existingSupplier = (from s in dataContext.Suppliers
                                   where s.SupplierId.ToString() == supplierID
                                   select s).Single();
            }
            //instantiate the addeditSupplierForm
            frmAddEditSupplier frmAddEdit = new frmAddEditSupplier();
            frmAddEdit.EditMode = true; //editing Supplier
            frmAddEdit.exsistingSupplier = existingSupplier;
            DialogResult result = frmAddEdit.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                reloadGridView();
            }

        }

        private void CloseMainSupplierButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
