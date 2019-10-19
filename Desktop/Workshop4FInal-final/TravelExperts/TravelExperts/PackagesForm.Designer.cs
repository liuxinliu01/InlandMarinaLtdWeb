namespace TravelExperts
{
    partial class PackagesForm
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
            this.fullpackageGridView = new System.Windows.Forms.DataGridView();
            this.fullPackageListView = new System.Windows.Forms.ListView();
            this.PackageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.packageDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fullpackageGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fullpackageGridView
            // 
            this.fullpackageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullpackageGridView.Location = new System.Drawing.Point(27, 345);
            this.fullpackageGridView.Name = "fullpackageGridView";
            this.fullpackageGridView.RowHeadersWidth = 62;
            this.fullpackageGridView.RowTemplate.Height = 28;
            this.fullpackageGridView.Size = new System.Drawing.Size(1151, 137);
            this.fullpackageGridView.TabIndex = 0;
            // 
            // fullPackageListView
            // 
            this.fullPackageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PackageName,
            this.PackageDesc,
            this.PackageStartDate,
            this.PackageSupplierName,
            this.PackageProductName});
            this.fullPackageListView.Location = new System.Drawing.Point(27, 500);
            this.fullPackageListView.Name = "fullPackageListView";
            this.fullPackageListView.Size = new System.Drawing.Size(1141, 254);
            this.fullPackageListView.TabIndex = 1;
            this.fullPackageListView.UseCompatibleStateImageBehavior = false;
            this.fullPackageListView.View = System.Windows.Forms.View.Details;
            // 
            // PackageName
            // 
            this.PackageName.Text = "Package Name";
            this.PackageName.Width = 200;
            // 
            // PackageDesc
            // 
            this.PackageDesc.Text = "Package Description";
            this.PackageDesc.Width = 250;
            // 
            // PackageStartDate
            // 
            this.PackageStartDate.Text = "PackageStartDate";
            this.PackageStartDate.Width = 200;
            // 
            // PackageSupplierName
            // 
            this.PackageSupplierName.Text = "Supplier";
            this.PackageSupplierName.Width = 200;
            // 
            // PackageProductName
            // 
            this.PackageProductName.Text = "ProductName";
            this.PackageProductName.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 69);
            // 
            // packageDetailsToolStripMenuItem
            // 
            this.packageDetailsToolStripMenuItem.Name = "packageDetailsToolStripMenuItem";
            this.packageDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.packageDetailsToolStripMenuItem.Text = "Package Details....";
            this.packageDetailsToolStripMenuItem.Click += new System.EventHandler(this.PackageDetailsToolStripMenuItem_Click);
            // 
            // packageGridView
            // 
            this.packageGridView.AllowUserToOrderColumns = true;
            this.packageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.packageGridView.Location = new System.Drawing.Point(79, 34);
            this.packageGridView.Name = "packageGridView";
            this.packageGridView.RowHeadersWidth = 62;
            this.packageGridView.RowTemplate.Height = 28;
            this.packageGridView.Size = new System.Drawing.Size(935, 189);
            this.packageGridView.TabIndex = 4;
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.packageGridView);
            this.Controls.Add(this.fullPackageListView);
            this.Controls.Add(this.fullpackageGridView);
            this.Name = "PackagesForm";
            this.Text = "PackageForm";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullpackageGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fullpackageGridView;
        private System.Windows.Forms.ListView fullPackageListView;
        private System.Windows.Forms.ColumnHeader PackageName;
        private System.Windows.Forms.ColumnHeader PackageDesc;
        private System.Windows.Forms.ColumnHeader PackageStartDate;
        private System.Windows.Forms.ColumnHeader PackageSupplierName;
        private System.Windows.Forms.ColumnHeader PackageProductName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem packageDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridView packageGridView;
    }
}

