using ProductSupplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class PackagesForm : Form
    {
        fullPackageDataContext dbContext = new fullPackageDataContext();
        List<Package> PackageList = new List<Package>();
        List<Supplier> SupplierList = new List<Supplier>();
        List<Product> ProductList = new List<Product>();
        List<Products_Supplier> Products_SupplierList = new List<Products_Supplier>();
        List<Packages_Products_Supplier> Packages_Products_SupplierList = new List<Packages_Products_Supplier>();

        public PackagesForm()
        {
            InitializeComponent();
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {


            using (fullPackageDataContext dbContext = new fullPackageDataContext())
            {
                packageGridView.DataSource = dbContext.Packages;
                foreach (Package p in dbContext.Packages)
                {
                    PackageList.Add(p);

                }

                var packages = from pps in dbContext.Packages_Products_Suppliers
                               join pk in dbContext.Packages
                               on pps.PackageId equals pk.PackageId
                               join ps in dbContext.Products_Suppliers
                               on pps.ProductSupplierId equals ps.ProductSupplierId
                               join s in dbContext.Suppliers
                               on ps.SupplierId equals s.SupplierId
                               join p in dbContext.Products
                               on ps.ProductId equals p.ProductId
                               select new
                               {
                                   pk.PackageId,
                                   pk.PkgName,
                                   pk.PkgDesc,
                                   pk.PkgStartDate,
                                   //pk.PkgEndDate,
                                   //pk.PkgBasePrice,
                                   //pk.PkgAgencyCommission,
                                   s.SupName,
                                   p.ProdName

                               };
                string packageName = "";
                int i = 0;
                foreach (var package in packages)
                {
                    if (package.PkgName != packageName)
                    {
                        fullPackageListView.Items.Add(package.PkgName);
                        packageName = package.PkgName;
                    }
                    else
                    {
                        fullPackageListView.Items.Add("");
                    }
                    fullPackageListView.Items[i].SubItems.Add(package.PkgDesc.ToString());
                    fullPackageListView.Items[i].SubItems.Add(
                       Convert.ToDateTime(package.PkgStartDate).ToShortDateString());
                    fullPackageListView.Items[i].SubItems.Add(package.SupName.ToString());
                    fullPackageListView.Items[i].SubItems.Add(package.ProdName.ToString());
                    //fullPackageListView.Items[i].SubItems.Add(package.PkgDesc);
                    //fullPackageListView.Items[i].SubItems.Add(package.PkgDesc);
                    i += 1;

                }
                fullpackageGridView.DataSource = packages;
            }


        }

        private void PackageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowNum = packageGridView.CurrentCell.RowIndex;
            AddPackageForm apf = new AddPackageForm();
            apf.ReadOnly = true;
            apf.currentPackage = PackageList[rowNum];
            DialogResult result = apf.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
        }
    }
}
