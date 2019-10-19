using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Suppliers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void products_SuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.products_SuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);

        }
    }
}
