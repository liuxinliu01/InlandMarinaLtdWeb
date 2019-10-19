namespace Products
{
    partial class ProductsMainForm
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Products.Product);
            // 
            // productDataGridView
            // 
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(9, 10);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(320, 340);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // addProductsButton
            // 
            this.addProductsButton.Location = new System.Drawing.Point(346, 20);
            this.addProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(104, 32);
            this.addProductsButton.TabIndex = 2;
            this.addProductsButton.Text = "Add Product";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProductsButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(346, 77);
            this.editProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(104, 32);
            this.editProductButton.TabIndex = 2;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(346, 136);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProductsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.productDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

