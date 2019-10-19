namespace CMPP248VB
{
    partial class AddModifyPackage
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyPackage));
            this.packageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.packageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SavePackageBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.travelExpertsDataSet = new CMPP248VB.TravelExpertsDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new CMPP248VB.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new CMPP248VB.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new CMPP248VB.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierListbox = new System.Windows.Forms.ListBox();
            this.addsupplierButton = new System.Windows.Forms.Button();
            this.deleteSupplierButton = new System.Windows.Forms.Button();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productSupplierLabel = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).BeginInit();
            this.packageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(101, 52);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(40, 246);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(83, 147);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(109, 111);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(89, 210);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(106, 78);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(86, 177);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // packageBindingNavigator
            // 
            this.packageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packageBindingNavigator.BindingSource = this.packageBindingSource;
            this.packageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.packageBindingNavigatorSaveItem});
            this.packageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.packageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packageBindingNavigator.Name = "packageBindingNavigator";
            this.packageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packageBindingNavigator.Size = new System.Drawing.Size(830, 25);
            this.packageBindingNavigator.TabIndex = 0;
            this.packageBindingNavigator.Text = "bindingNavigator1";
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
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(CMPP248VB.Package);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // packageBindingNavigatorSaveItem
            // 
            this.packageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packageBindingNavigatorSaveItem.Enabled = false;
            this.packageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packageBindingNavigatorSaveItem.Image")));
            this.packageBindingNavigatorSaveItem.Name = "packageBindingNavigatorSaveItem";
            this.packageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packageBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Location = new System.Drawing.Point(182, 45);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.packageIdTextBox.TabIndex = 1;
            this.packageIdTextBox.Tag = "Package ID";
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(182, 243);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 7;
            this.pkgAgencyCommissionTextBox.Tag = "Package Agency Commission";
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(182, 144);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 4;
            this.pkgBasePriceTextBox.Tag = "Package Base Price";
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(182, 111);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgDescTextBox.TabIndex = 3;
            this.pkgDescTextBox.Tag = "Package Description";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(182, 210);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 6;
            this.pkgEndDateDateTimePicker.Tag = "Package End Date";
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(182, 78);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgNameTextBox.TabIndex = 2;
            this.pkgNameTextBox.Tag = "Package Name";
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(182, 177);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgStartDateDateTimePicker.TabIndex = 5;
            this.pkgStartDateDateTimePicker.Tag = "Package Start Date";
            // 
            // SavePackageBtn
            // 
            this.SavePackageBtn.Location = new System.Drawing.Point(66, 291);
            this.SavePackageBtn.Name = "SavePackageBtn";
            this.SavePackageBtn.Size = new System.Drawing.Size(100, 50);
            this.SavePackageBtn.TabIndex = 10;
            this.SavePackageBtn.Text = "Save";
            this.SavePackageBtn.UseVisualStyleBackColor = true;
            this.SavePackageBtn.Click += new System.EventHandler(this.SavePackageBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(282, 291);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 50);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = null;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMPP248VB.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // productSupplierListbox
            // 
            this.productSupplierListbox.FormattingEnabled = true;
            this.productSupplierListbox.Location = new System.Drawing.Point(413, 111);
            this.productSupplierListbox.Name = "productSupplierListbox";
            this.productSupplierListbox.Size = new System.Drawing.Size(388, 147);
            this.productSupplierListbox.TabIndex = 14;
            // 
            // addsupplierButton
            // 
            this.addsupplierButton.Location = new System.Drawing.Point(804, 111);
            this.addsupplierButton.Name = "addsupplierButton";
            this.addsupplierButton.Size = new System.Drawing.Size(24, 23);
            this.addsupplierButton.TabIndex = 15;
            this.addsupplierButton.Text = "+";
            this.addsupplierButton.UseVisualStyleBackColor = true;
            this.addsupplierButton.Click += new System.EventHandler(this.addsupplierButton_Click);
            // 
            // deleteSupplierButton
            // 
            this.deleteSupplierButton.Location = new System.Drawing.Point(804, 140);
            this.deleteSupplierButton.Name = "deleteSupplierButton";
            this.deleteSupplierButton.Size = new System.Drawing.Size(24, 23);
            this.deleteSupplierButton.TabIndex = 15;
            this.deleteSupplierButton.Text = "-";
            this.deleteSupplierButton.UseVisualStyleBackColor = true;
            this.deleteSupplierButton.Click += new System.EventHandler(this.deleteSupplierButton_Click);
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(612, 85);
            this.supplierComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(189, 21);
            this.supplierComboBox.TabIndex = 9;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(413, 85);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(189, 21);
            this.productComboBox.TabIndex = 8;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.AutoSize = true;
            this.supplierNameLabel.Location = new System.Drawing.Point(609, 64);
            this.supplierNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(76, 13);
            this.supplierNameLabel.TabIndex = 16;
            this.supplierNameLabel.Text = "Supplier Name";
            this.supplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(415, 64);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 13);
            this.productNameLabel.TabIndex = 17;
            this.productNameLabel.Text = "Product Name:";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productSupplierLabel
            // 
            this.productSupplierLabel.AutoSize = true;
            this.productSupplierLabel.Location = new System.Drawing.Point(415, 45);
            this.productSupplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productSupplierLabel.Name = "productSupplierLabel";
            this.productSupplierLabel.Size = new System.Drawing.Size(85, 13);
            this.productSupplierLabel.TabIndex = 17;
            this.productSupplierLabel.Text = "Product Supplier";
            this.productSupplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 378);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.supplierNameLabel);
            this.Controls.Add(this.productSupplierLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.deleteSupplierButton);
            this.Controls.Add(this.addsupplierButton);
            this.Controls.Add(this.productSupplierListbox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SavePackageBtn);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Controls.Add(this.packageBindingNavigator);
            this.Name = "AddModifyPackage";
            this.Text = "AddModifyPackage";
            this.Load += new System.EventHandler(this.AddModifyPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).EndInit();
            this.packageBindingNavigator.ResumeLayout(false);
            this.packageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingNavigator packageBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton packageBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.Button SavePackageBtn;
        private System.Windows.Forms.Button CancelBtn;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ListBox productSupplierListbox;
        private System.Windows.Forms.Button addsupplierButton;
        private System.Windows.Forms.Button deleteSupplierButton;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label supplierNameLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productSupplierLabel;
    }
}