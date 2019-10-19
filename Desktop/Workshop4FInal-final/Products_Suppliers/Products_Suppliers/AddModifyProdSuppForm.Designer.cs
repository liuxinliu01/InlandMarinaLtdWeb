namespace Products_Suppliers
{
    partial class AddModifyProdSuppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyProdSuppForm));
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.travelExpertsDataSet = new Products_Suppliers.TravelExpertsDataSet();
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersTableAdapter = new Products_Suppliers.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.tableAdapterManager = new Products_Suppliers.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.products_SuppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.products_SuppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Products_Suppliers.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Products_Suppliers.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supNameLabel = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).BeginInit();
            this.products_SuppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // products_SuppliersBindingSource
            // 
            this.products_SuppliersBindingSource.DataMember = "Products_Suppliers";
            this.products_SuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Products_SuppliersTableAdapter = this.products_SuppliersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Products_Suppliers.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // products_SuppliersBindingNavigator
            // 
            this.products_SuppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.products_SuppliersBindingNavigator.BindingSource = this.products_SuppliersBindingSource;
            this.products_SuppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.products_SuppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.products_SuppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.products_SuppliersBindingNavigatorSaveItem});
            this.products_SuppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.products_SuppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.products_SuppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.products_SuppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.products_SuppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.products_SuppliersBindingNavigator.Name = "products_SuppliersBindingNavigator";
            this.products_SuppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.products_SuppliersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.products_SuppliersBindingNavigator.TabIndex = 0;
            this.products_SuppliersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // products_SuppliersBindingNavigatorSaveItem
            // 
            this.products_SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.products_SuppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("products_SuppliersBindingNavigatorSaveItem.Image")));
            this.products_SuppliersBindingNavigatorSaveItem.Name = "products_SuppliersBindingNavigatorSaveItem";
            this.products_SuppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.products_SuppliersBindingNavigatorSaveItem.Text = "Save Data";
            this.products_SuppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.products_SuppliersBindingNavigatorSaveItem_Click);
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(30, 51);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(100, 13);
            productSupplierIdLabel.TabIndex = 1;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SuppliersBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(136, 48);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(127, 20);
            this.productSupplierIdTextBox.TabIndex = 2;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(71, 86);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(59, 13);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Id:";
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(136, 83);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(127, 21);
            this.productIdComboBox.TabIndex = 4;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(70, 123);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 13);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierId", true));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(136, 120);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(127, 21);
            this.supplierIdComboBox.TabIndex = 6;
            // 
            // supNameLabel
            // 
            this.supNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.supNameLabel.Location = new System.Drawing.Point(284, 120);
            this.supNameLabel.Name = "supNameLabel";
            this.supNameLabel.Size = new System.Drawing.Size(100, 23);
            this.supNameLabel.TabIndex = 8;
            this.supNameLabel.Text = "Supplier Name";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProdName", true));
            this.prodNameLabel.Location = new System.Drawing.Point(284, 83);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(100, 23);
            this.prodNameLabel.TabIndex = 10;
            this.prodNameLabel.Text = "Product Name";
            // 
            // AddModifyProdSuppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.supNameLabel);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdComboBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdComboBox);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(this.productSupplierIdTextBox);
            this.Controls.Add(this.products_SuppliersBindingNavigator);
            this.Name = "AddModifyProdSuppForm";
            this.Text = "AddModifyProdSuppForm";
            this.Load += new System.EventHandler(this.AddModifyProdSuppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).EndInit();
            this.products_SuppliersBindingNavigator.ResumeLayout(false);
            this.products_SuppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator products_SuppliersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton products_SuppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.Label supNameLabel;
        private System.Windows.Forms.Label prodNameLabel;
    }
}