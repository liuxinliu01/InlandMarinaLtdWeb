namespace ProductSupplier
{
    partial class AddModifySupplierProductForm
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
            this.supplierIDtextbox = new System.Windows.Forms.TextBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCombobox = new System.Windows.Forms.ComboBox();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.productSupplierIDLabel = new System.Windows.Forms.Label();
            this.productSupplierIDTextbox = new System.Windows.Forms.TextBox();
            this.productIDTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // supplierIDtextbox
            // 
            this.supplierIDtextbox.Location = new System.Drawing.Point(252, 95);
            this.supplierIDtextbox.Name = "supplierIDtextbox";
            this.supplierIDtextbox.Size = new System.Drawing.Size(235, 26);
            this.supplierIDtextbox.TabIndex = 2;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.Location = new System.Drawing.Point(83, 91);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(163, 30);
            this.supplierNameLabel.TabIndex = 2;
            this.supplierNameLabel.Text = "Supplier Name";
            this.supplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Location = new System.Drawing.Point(83, 58);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(163, 30);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productCombobox
            // 
            this.productCombobox.FormattingEnabled = true;
            this.productCombobox.Location = new System.Drawing.Point(255, 197);
            this.productCombobox.Name = "productCombobox";
            this.productCombobox.Size = new System.Drawing.Size(235, 28);
            this.productCombobox.TabIndex = 3;
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Location = new System.Drawing.Point(255, 130);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(114, 36);
            this.addSupplierButton.TabIndex = 4;
            this.addSupplierButton.Text = "Add";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(376, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 36);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // productSupplierIDLabel
            // 
            this.productSupplierIDLabel.Location = new System.Drawing.Point(86, 24);
            this.productSupplierIDLabel.Name = "productSupplierIDLabel";
            this.productSupplierIDLabel.Size = new System.Drawing.Size(163, 30);
            this.productSupplierIDLabel.TabIndex = 2;
            this.productSupplierIDLabel.Text = "Product_SupplierID";
            this.productSupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productSupplierIDTextbox
            // 
            this.productSupplierIDTextbox.Location = new System.Drawing.Point(255, 28);
            this.productSupplierIDTextbox.Name = "productSupplierIDTextbox";
            this.productSupplierIDTextbox.Size = new System.Drawing.Size(84, 26);
            this.productSupplierIDTextbox.TabIndex = 1;
            // 
            // productIDTextbox
            // 
            this.productIDTextbox.Location = new System.Drawing.Point(252, 60);
            this.productIDTextbox.Name = "productIDTextbox";
            this.productIDTextbox.Size = new System.Drawing.Size(235, 26);
            this.productIDTextbox.TabIndex = 2;
            // 
            // AddModifySupplierProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 255);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productCombobox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productSupplierIDTextbox);
            this.Controls.Add(this.productSupplierIDLabel);
            this.Controls.Add(this.productIDTextbox);
            this.Controls.Add(this.supplierIDtextbox);
            this.Controls.Add(this.supplierNameLabel);
            this.Name = "AddModifySupplierProductForm";
            this.Text = "AddModifySupplierProductForm";
            this.Load += new System.EventHandler(this.AddModifySupplierProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplierIDtextbox;
        private System.Windows.Forms.Label supplierNameLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.ComboBox productCombobox;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label productSupplierIDLabel;
        private System.Windows.Forms.TextBox productSupplierIDTextbox;
        private System.Windows.Forms.TextBox productIDTextbox;
    }
}