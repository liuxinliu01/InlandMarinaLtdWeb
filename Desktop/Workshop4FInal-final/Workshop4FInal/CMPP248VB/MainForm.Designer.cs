namespace CMPP248VB
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.travelExpertsDataSet = new CMPP248VB.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new CMPP248VB.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new CMPP248VB.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.packagesDataGridView = new System.Windows.Forms.DataGridView();
            this.AddPackageBtn = new System.Windows.Forms.Button();
            this.ModifyPackageBtn = new System.Windows.Forms.Button();
            this.DeletePackageBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.suppliersModifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFullPackageBtn = new System.Windows.Forms.Button();
            this.ModifyFullPackageBtn = new System.Windows.Forms.Button();
            this.packages_Products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullPackageDetailBtn = new System.Windows.Forms.Button();
            this.Packages = new System.Windows.Forms.Label();
            this.packagesExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMPP248VB.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // packagesDataGridView
            // 
            this.packagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packagesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packagesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.packagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.packagesDataGridView.DataSource = this.packagesBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packagesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.packagesDataGridView.Location = new System.Drawing.Point(0, 101);
            this.packagesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packagesDataGridView.Name = "packagesDataGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packagesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.packagesDataGridView.RowHeadersWidth = 51;
            this.packagesDataGridView.Size = new System.Drawing.Size(1174, 339);
            this.packagesDataGridView.TabIndex = 1;
            this.packagesDataGridView.DoubleClick += new System.EventHandler(this.fullPackageDetailBtn_Click);
            // 
            // AddPackageBtn
            // 
            this.AddPackageBtn.Location = new System.Drawing.Point(18, 472);
            this.AddPackageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPackageBtn.Name = "AddPackageBtn";
            this.AddPackageBtn.Size = new System.Drawing.Size(179, 49);
            this.AddPackageBtn.TabIndex = 2;
            this.AddPackageBtn.Text = "Add New Package";
            this.AddPackageBtn.UseVisualStyleBackColor = true;
            this.AddPackageBtn.Click += new System.EventHandler(this.AddPackageBtn_Click);
            // 
            // ModifyPackageBtn
            // 
            this.ModifyPackageBtn.Location = new System.Drawing.Point(233, 472);
            this.ModifyPackageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifyPackageBtn.Name = "ModifyPackageBtn";
            this.ModifyPackageBtn.Size = new System.Drawing.Size(179, 49);
            this.ModifyPackageBtn.TabIndex = 2;
            this.ModifyPackageBtn.Text = "Modify Package";
            this.ModifyPackageBtn.UseVisualStyleBackColor = true;
            this.ModifyPackageBtn.Click += new System.EventHandler(this.ModifyPackageBtn_Click);
            // 
            // DeletePackageBtn
            // 
            this.DeletePackageBtn.Location = new System.Drawing.Point(459, 472);
            this.DeletePackageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeletePackageBtn.Name = "DeletePackageBtn";
            this.DeletePackageBtn.Size = new System.Drawing.Size(179, 49);
            this.DeletePackageBtn.TabIndex = 2;
            this.DeletePackageBtn.Text = "Delete Package";
            this.DeletePackageBtn.UseVisualStyleBackColor = true;
            this.DeletePackageBtn.Click += new System.EventHandler(this.DeletePackageBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersModifiedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // suppliersModifiedToolStripMenuItem
            // 
            this.suppliersModifiedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.suppliersModifiedToolStripMenuItem.Name = "suppliersModifiedToolStripMenuItem";
            this.suppliersModifiedToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.suppliersModifiedToolStripMenuItem.Text = "Menu";
            this.suppliersModifiedToolStripMenuItem.Click += new System.EventHandler(this.SuppliersModifiedToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.suppliersToolStripMenuItem.Text = "Suppliers ";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AddFullPackageBtn
            // 
            this.AddFullPackageBtn.Location = new System.Drawing.Point(18, 562);
            this.AddFullPackageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddFullPackageBtn.Name = "AddFullPackageBtn";
            this.AddFullPackageBtn.Size = new System.Drawing.Size(179, 46);
            this.AddFullPackageBtn.TabIndex = 2;
            this.AddFullPackageBtn.Text = "Add Full Package";
            this.AddFullPackageBtn.UseVisualStyleBackColor = true;
            this.AddFullPackageBtn.Click += new System.EventHandler(this.AddFullPackageBtn_Click);
            // 
            // ModifyFullPackageBtn
            // 
            this.ModifyFullPackageBtn.Location = new System.Drawing.Point(233, 562);
            this.ModifyFullPackageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifyFullPackageBtn.Name = "ModifyFullPackageBtn";
            this.ModifyFullPackageBtn.Size = new System.Drawing.Size(179, 46);
            this.ModifyFullPackageBtn.TabIndex = 2;
            this.ModifyFullPackageBtn.Text = "Modify Full Package";
            this.ModifyFullPackageBtn.UseVisualStyleBackColor = true;
            this.ModifyFullPackageBtn.Click += new System.EventHandler(this.ModifyFullPackageBtn_Click);
            // 
            // fullPackageDetailBtn
            // 
            this.fullPackageDetailBtn.Location = new System.Drawing.Point(459, 562);
            this.fullPackageDetailBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullPackageDetailBtn.Name = "fullPackageDetailBtn";
            this.fullPackageDetailBtn.Size = new System.Drawing.Size(179, 46);
            this.fullPackageDetailBtn.TabIndex = 2;
            this.fullPackageDetailBtn.Text = "Full Package Details";
            this.fullPackageDetailBtn.UseVisualStyleBackColor = true;
            this.fullPackageDetailBtn.Click += new System.EventHandler(this.fullPackageDetailBtn_Click);
            // 
            // Packages
            // 
            this.Packages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Packages.BackColor = System.Drawing.SystemColors.Highlight;
            this.Packages.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Packages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Packages.Location = new System.Drawing.Point(0, 35);
            this.Packages.Name = "Packages";
            this.Packages.Size = new System.Drawing.Size(1178, 0);
            this.Packages.TabIndex = 4;
            this.Packages.Text = "Packages";
            // 
            // packagesExitButton
            // 
            this.packagesExitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.packagesExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesExitButton.Location = new System.Drawing.Point(1025, 562);
            this.packagesExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packagesExitButton.Name = "packagesExitButton";
            this.packagesExitButton.Size = new System.Drawing.Size(140, 46);
            this.packagesExitButton.TabIndex = 5;
            this.packagesExitButton.Text = "Exit";
            this.packagesExitButton.UseVisualStyleBackColor = false;
            this.packagesExitButton.Click += new System.EventHandler(this.PackagesExitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1174, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "Travel Packages";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packagesExitButton);
            this.Controls.Add(this.Packages);
            this.Controls.Add(this.fullPackageDetailBtn);
            this.Controls.Add(this.ModifyFullPackageBtn);
            this.Controls.Add(this.DeletePackageBtn);
            this.Controls.Add(this.AddFullPackageBtn);
            this.Controls.Add(this.ModifyPackageBtn);
            this.Controls.Add(this.AddPackageBtn);
            this.Controls.Add(this.packagesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Expert Package Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView packagesDataGridView;
        private System.Windows.Forms.Button AddPackageBtn;
        private System.Windows.Forms.Button ModifyPackageBtn;
        private System.Windows.Forms.Button DeletePackageBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem suppliersModifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Button AddFullPackageBtn;
        private System.Windows.Forms.Button ModifyFullPackageBtn;
        private System.Windows.Forms.BindingSource packages_Products_SuppliersBindingSource;
        private System.Windows.Forms.Button fullPackageDetailBtn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label Packages;
        private System.Windows.Forms.Button packagesExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

