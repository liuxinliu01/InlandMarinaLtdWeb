namespace Products_Suppliers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.products_SuppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeMainSupplierButton = new System.Windows.Forms.Button();
            this.editProducts_SupplierButton = new System.Windows.Forms.Button();
            this.addProducts_SuppliersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).BeginInit();
            this.products_SuppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersDataGridView)).BeginInit();
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
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
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
            this.products_SuppliersBindingNavigator.Size = new System.Drawing.Size(484, 25);
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
            // products_SuppliersDataGridView
            // 
            this.products_SuppliersDataGridView.AutoGenerateColumns = false;
            this.products_SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_SuppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.products_SuppliersDataGridView.DataSource = this.products_SuppliersBindingSource;
            this.products_SuppliersDataGridView.Location = new System.Drawing.Point(12, 28);
            this.products_SuppliersDataGridView.Name = "products_SuppliersDataGridView";
            this.products_SuppliersDataGridView.Size = new System.Drawing.Size(347, 321);
            this.products_SuppliersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // closeMainSupplierButton
            // 
            this.closeMainSupplierButton.Location = new System.Drawing.Point(365, 149);
            this.closeMainSupplierButton.Name = "closeMainSupplierButton";
            this.closeMainSupplierButton.Size = new System.Drawing.Size(75, 23);
            this.closeMainSupplierButton.TabIndex = 7;
            this.closeMainSupplierButton.Text = "Close";
            this.closeMainSupplierButton.UseVisualStyleBackColor = true;
            // 
            // editProducts_SupplierButton
            // 
            this.editProducts_SupplierButton.Location = new System.Drawing.Point(365, 99);
            this.editProducts_SupplierButton.Name = "editProducts_SupplierButton";
            this.editProducts_SupplierButton.Size = new System.Drawing.Size(75, 23);
            this.editProducts_SupplierButton.TabIndex = 6;
            this.editProducts_SupplierButton.Text = "Edit";
            this.editProducts_SupplierButton.UseVisualStyleBackColor = true;
            // 
            // addProducts_SuppliersButton
            // 
            this.addProducts_SuppliersButton.Location = new System.Drawing.Point(365, 49);
            this.addProducts_SuppliersButton.Name = "addProducts_SuppliersButton";
            this.addProducts_SuppliersButton.Size = new System.Drawing.Size(75, 23);
            this.addProducts_SuppliersButton.TabIndex = 5;
            this.addProducts_SuppliersButton.Text = "Add";
            this.addProducts_SuppliersButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.closeMainSupplierButton);
            this.Controls.Add(this.editProducts_SupplierButton);
            this.Controls.Add(this.addProducts_SuppliersButton);
            this.Controls.Add(this.products_SuppliersDataGridView);
            this.Controls.Add(this.products_SuppliersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Products_Suppliers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).EndInit();
            this.products_SuppliersBindingNavigator.ResumeLayout(false);
            this.products_SuppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView products_SuppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button closeMainSupplierButton;
        private System.Windows.Forms.Button editProducts_SupplierButton;
        private System.Windows.Forms.Button addProducts_SuppliersButton;
    }
}

