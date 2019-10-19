namespace ProductSupplier
{
    partial class AddPackageForm
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
            this.packageNameLabel = new System.Windows.Forms.Label();
            this.packageNameTextbox = new System.Windows.Forms.TextBox();
            this.packageStartDateLabel = new System.Windows.Forms.Label();
            this.packageEndDateLabel = new System.Windows.Forms.Label();
            this.packageDescriptionLabel = new System.Windows.Forms.Label();
            this.packageDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.basePriceTextbox = new System.Windows.Forms.TextBox();
            this.agencyCommissionLabel = new System.Windows.Forms.Label();
            this.agencyCommissionTextbox = new System.Windows.Forms.TextBox();
            this.productSupplierLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.productListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSupplierProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSupplierProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.productSupplierListbox = new System.Windows.Forms.ListBox();
            this.packageIDLabel = new System.Windows.Forms.Label();
            this.packageIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageNameLabel
            // 
            this.packageNameLabel.Location = new System.Drawing.Point(20, 51);
            this.packageNameLabel.Name = "packageNameLabel";
            this.packageNameLabel.Size = new System.Drawing.Size(163, 30);
            this.packageNameLabel.TabIndex = 0;
            this.packageNameLabel.Text = "Package Name";
            this.packageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageNameTextbox
            // 
            this.packageNameTextbox.Location = new System.Drawing.Point(189, 55);
            this.packageNameTextbox.Name = "packageNameTextbox";
            this.packageNameTextbox.Size = new System.Drawing.Size(235, 26);
            this.packageNameTextbox.TabIndex = 1;
            // 
            // packageStartDateLabel
            // 
            this.packageStartDateLabel.Location = new System.Drawing.Point(20, 83);
            this.packageStartDateLabel.Name = "packageStartDateLabel";
            this.packageStartDateLabel.Size = new System.Drawing.Size(163, 30);
            this.packageStartDateLabel.TabIndex = 0;
            this.packageStartDateLabel.Text = "Package Start Date";
            this.packageStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageEndDateLabel
            // 
            this.packageEndDateLabel.Location = new System.Drawing.Point(20, 115);
            this.packageEndDateLabel.Name = "packageEndDateLabel";
            this.packageEndDateLabel.Size = new System.Drawing.Size(163, 30);
            this.packageEndDateLabel.TabIndex = 0;
            this.packageEndDateLabel.Text = "Package End Date";
            this.packageEndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageDescriptionLabel
            // 
            this.packageDescriptionLabel.Location = new System.Drawing.Point(20, 147);
            this.packageDescriptionLabel.Name = "packageDescriptionLabel";
            this.packageDescriptionLabel.Size = new System.Drawing.Size(163, 30);
            this.packageDescriptionLabel.TabIndex = 0;
            this.packageDescriptionLabel.Text = "Package Description";
            this.packageDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageDescriptionTextbox
            // 
            this.packageDescriptionTextbox.Location = new System.Drawing.Point(189, 151);
            this.packageDescriptionTextbox.Name = "packageDescriptionTextbox";
            this.packageDescriptionTextbox.Size = new System.Drawing.Size(235, 26);
            this.packageDescriptionTextbox.TabIndex = 4;
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.Location = new System.Drawing.Point(20, 178);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(163, 30);
            this.basePriceLabel.TabIndex = 0;
            this.basePriceLabel.Text = "Package Base Price";
            this.basePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // basePriceTextbox
            // 
            this.basePriceTextbox.Location = new System.Drawing.Point(189, 182);
            this.basePriceTextbox.Name = "basePriceTextbox";
            this.basePriceTextbox.Size = new System.Drawing.Size(235, 26);
            this.basePriceTextbox.TabIndex = 5;
            // 
            // agencyCommissionLabel
            // 
            this.agencyCommissionLabel.Location = new System.Drawing.Point(20, 210);
            this.agencyCommissionLabel.Name = "agencyCommissionLabel";
            this.agencyCommissionLabel.Size = new System.Drawing.Size(163, 30);
            this.agencyCommissionLabel.TabIndex = 0;
            this.agencyCommissionLabel.Text = "Agency Commission";
            this.agencyCommissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agencyCommissionTextbox
            // 
            this.agencyCommissionTextbox.Location = new System.Drawing.Point(189, 214);
            this.agencyCommissionTextbox.Name = "agencyCommissionTextbox";
            this.agencyCommissionTextbox.Size = new System.Drawing.Size(235, 26);
            this.agencyCommissionTextbox.TabIndex = 6;
            // 
            // productSupplierLabel
            // 
            this.productSupplierLabel.Location = new System.Drawing.Point(20, 242);
            this.productSupplierLabel.Name = "productSupplierLabel";
            this.productSupplierLabel.Size = new System.Drawing.Size(163, 30);
            this.productSupplierLabel.TabIndex = 0;
            this.productSupplierLabel.Text = "Product Supplier";
            this.productSupplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(579, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 36);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(458, 422);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(114, 36);
            this.addPackageButton.TabIndex = 8;
            this.addPackageButton.Text = "Add";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.AddPackageButton_Click);
            // 
            // productListGridView
            // 
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.productListGridView.Location = new System.Drawing.Point(24, 475);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.RowHeadersWidth = 62;
            this.productListGridView.RowTemplate.Height = 28;
            this.productListGridView.Size = new System.Drawing.Size(709, 148);
            this.productListGridView.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierProductToolStripMenuItem,
            this.editSupplierProductToolStripMenuItem,
            this.deleteSupplierProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(289, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // addSupplierProductToolStripMenuItem
            // 
            this.addSupplierProductToolStripMenuItem.Name = "addSupplierProductToolStripMenuItem";
            this.addSupplierProductToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.addSupplierProductToolStripMenuItem.Text = "Add Supplier & Product....";
            this.addSupplierProductToolStripMenuItem.Click += new System.EventHandler(this.AddSupplierProductToolStripMenuItem_Click);
            // 
            // editSupplierProductToolStripMenuItem
            // 
            this.editSupplierProductToolStripMenuItem.Name = "editSupplierProductToolStripMenuItem";
            this.editSupplierProductToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.editSupplierProductToolStripMenuItem.Text = "Edit Supplier & Product...";
            this.editSupplierProductToolStripMenuItem.Click += new System.EventHandler(this.EditSupplierProductToolStripMenuItem_Click);
            // 
            // deleteSupplierProductToolStripMenuItem
            // 
            this.deleteSupplierProductToolStripMenuItem.Name = "deleteSupplierProductToolStripMenuItem";
            this.deleteSupplierProductToolStripMenuItem.Size = new System.Drawing.Size(288, 32);
            this.deleteSupplierProductToolStripMenuItem.Text = "Delete Supplier & Product...";
            this.deleteSupplierProductToolStripMenuItem.Click += new System.EventHandler(this.DeleteSupplierProductToolStripMenuItem_Click);
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(189, 87);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(235, 26);
            this.startDateTime.TabIndex = 2;
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(189, 119);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(235, 26);
            this.endDateTime.TabIndex = 3;
            // 
            // productSupplierListbox
            // 
            this.productSupplierListbox.ContextMenuStrip = this.contextMenuStrip1;
            this.productSupplierListbox.FormattingEnabled = true;
            this.productSupplierListbox.ItemHeight = 20;
            this.productSupplierListbox.Location = new System.Drawing.Point(191, 252);
            this.productSupplierListbox.Name = "productSupplierListbox";
            this.productSupplierListbox.Size = new System.Drawing.Size(512, 144);
            this.productSupplierListbox.TabIndex = 7;
            // 
            // packageIDLabel
            // 
            this.packageIDLabel.Location = new System.Drawing.Point(22, 19);
            this.packageIDLabel.Name = "packageIDLabel";
            this.packageIDLabel.Size = new System.Drawing.Size(163, 30);
            this.packageIDLabel.TabIndex = 0;
            this.packageIDLabel.Text = "Package ID";
            this.packageIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageIDTextBox
            // 
            this.packageIDTextBox.Location = new System.Drawing.Point(191, 23);
            this.packageIDTextBox.Name = "packageIDTextBox";
            this.packageIDTextBox.Size = new System.Drawing.Size(130, 26);
            this.packageIDTextBox.TabIndex = 1;
            // 
            // AddPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 718);
            this.Controls.Add(this.productSupplierListbox);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.productListGridView);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.agencyCommissionTextbox);
            this.Controls.Add(this.productSupplierLabel);
            this.Controls.Add(this.agencyCommissionLabel);
            this.Controls.Add(this.basePriceTextbox);
            this.Controls.Add(this.basePriceLabel);
            this.Controls.Add(this.packageDescriptionTextbox);
            this.Controls.Add(this.packageDescriptionLabel);
            this.Controls.Add(this.packageEndDateLabel);
            this.Controls.Add(this.packageStartDateLabel);
            this.Controls.Add(this.packageIDTextBox);
            this.Controls.Add(this.packageIDLabel);
            this.Controls.Add(this.packageNameTextbox);
            this.Controls.Add(this.packageNameLabel);
            this.Name = "AddPackageForm";
            this.Text = "AddModifyPackage";
            this.Load += new System.EventHandler(this.AddPackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packageNameLabel;
        private System.Windows.Forms.TextBox packageNameTextbox;
        private System.Windows.Forms.Label packageStartDateLabel;
        private System.Windows.Forms.Label packageEndDateLabel;
        private System.Windows.Forms.Label packageDescriptionLabel;
        private System.Windows.Forms.TextBox packageDescriptionTextbox;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.TextBox basePriceTextbox;
        private System.Windows.Forms.Label agencyCommissionLabel;
        private System.Windows.Forms.TextBox agencyCommissionTextbox;
        private System.Windows.Forms.Label productSupplierLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.DataGridView productListGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addSupplierProductToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.ListBox productSupplierListbox;
        private System.Windows.Forms.ToolStripMenuItem editSupplierProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierProductToolStripMenuItem;
        private System.Windows.Forms.Label packageIDLabel;
        private System.Windows.Forms.TextBox packageIDTextBox;
    }
}

