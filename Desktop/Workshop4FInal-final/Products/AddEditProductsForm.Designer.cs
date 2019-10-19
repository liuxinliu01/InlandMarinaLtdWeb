namespace Products
{
    partial class AddEditProductsForm
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIdLabel;
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            prodNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(20, 125);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(83, 17);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Prod Name:";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(116, 122);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.prodNameTextBox.TabIndex = 1;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(20, 71);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(76, 17);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Id:";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(116, 68);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIdTextBox.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Products.Product);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(42, 189);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(84, 37);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 37);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 250);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Name = "AddEditProductsForm";
            this.Text = "AddEditProductsForm";
            this.Load += new System.EventHandler(this.AddEditProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
    }
}