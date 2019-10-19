namespace Supplier_Travel
{
    partial class frmSupplier
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
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.editSupplierButton = new System.Windows.Forms.Button();
            this.closeMainSupplierButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Supplier_Travel.Supplier);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(16, 34);
            this.supplierDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.RowHeadersWidth = 51;
            this.supplierDataGridView.Size = new System.Drawing.Size(440, 395);
            this.supplierDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Location = new System.Drawing.Point(501, 86);
            this.addSupplierButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(100, 28);
            this.addSupplierButton.TabIndex = 2;
            this.addSupplierButton.Text = "Add Supplier";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // editSupplierButton
            // 
            this.editSupplierButton.Location = new System.Drawing.Point(501, 148);
            this.editSupplierButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editSupplierButton.Name = "editSupplierButton";
            this.editSupplierButton.Size = new System.Drawing.Size(100, 28);
            this.editSupplierButton.TabIndex = 3;
            this.editSupplierButton.Text = "Edit Supplier";
            this.editSupplierButton.UseVisualStyleBackColor = true;
            this.editSupplierButton.Click += new System.EventHandler(this.EditSupplierButton_Click);
            // 
            // closeMainSupplierButton
            // 
            this.closeMainSupplierButton.Location = new System.Drawing.Point(501, 209);
            this.closeMainSupplierButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeMainSupplierButton.Name = "closeMainSupplierButton";
            this.closeMainSupplierButton.Size = new System.Drawing.Size(100, 28);
            this.closeMainSupplierButton.TabIndex = 4;
            this.closeMainSupplierButton.Text = "Close";
            this.closeMainSupplierButton.UseVisualStyleBackColor = true;
            this.closeMainSupplierButton.Click += new System.EventHandler(this.CloseMainSupplierButton_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.closeMainSupplierButton);
            this.Controls.Add(this.editSupplierButton);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.supplierDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Button editSupplierButton;
        private System.Windows.Forms.Button closeMainSupplierButton;
    }
}

