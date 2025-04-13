namespace ProductManagementApp
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockkeepingunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productManagementDs = new ProductManagementApp.DataAccess.DataSets.ProductManagementDs();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.grbProductName = new System.Windows.Forms.GroupBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbStockKeepingUnit = new System.Windows.Forms.GroupBox();
            this.nmrStockKeepingUnit = new System.Windows.Forms.NumericUpDown();
            this.grbPrice = new System.Windows.Forms.GroupBox();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.grbCategoryName = new System.Windows.Forms.GroupBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.grbUnitName = new System.Windows.Forms.GroupBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagementDs)).BeginInit();
            this.menuBar.SuspendLayout();
            this.grbProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grbStockKeepingUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStockKeepingUnit)).BeginInit();
            this.grbPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            this.grbCategoryName.SuspendLayout();
            this.grbUnitName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stockkeepingunitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.unitidDataGridViewTextBoxColumn,
            this.unitnameDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productsBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(286, 27);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(545, 434);
            this.dgvProducts.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // stockkeepingunitDataGridViewTextBoxColumn
            // 
            this.stockkeepingunitDataGridViewTextBoxColumn.DataPropertyName = "stock_keeping_unit";
            this.stockkeepingunitDataGridViewTextBoxColumn.HeaderText = "Stock Keeping Unit";
            this.stockkeepingunitDataGridViewTextBoxColumn.Name = "stockkeepingunitDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            // 
            // unitidDataGridViewTextBoxColumn
            // 
            this.unitidDataGridViewTextBoxColumn.DataPropertyName = "unit_id";
            this.unitidDataGridViewTextBoxColumn.HeaderText = "unit_id";
            this.unitidDataGridViewTextBoxColumn.Name = "unitidDataGridViewTextBoxColumn";
            this.unitidDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitnameDataGridViewTextBoxColumn
            // 
            this.unitnameDataGridViewTextBoxColumn.DataPropertyName = "unit_name";
            this.unitnameDataGridViewTextBoxColumn.HeaderText = "Unit Name";
            this.unitnameDataGridViewTextBoxColumn.Name = "unitnameDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productManagementDs;
            // 
            // productManagementDs
            // 
            this.productManagementDs.DataSetName = "ProductManagementDs";
            this.productManagementDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuFile});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(835, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCategory,
            this.btnMenuUnits});
            this.btnMenuFile.Name = "btnMenuFile";
            this.btnMenuFile.Size = new System.Drawing.Size(37, 20);
            this.btnMenuFile.Text = "File";
            // 
            // btnMenuCategory
            // 
            this.btnMenuCategory.Name = "btnMenuCategory";
            this.btnMenuCategory.Size = new System.Drawing.Size(130, 22);
            this.btnMenuCategory.Text = "Categories";
            this.btnMenuCategory.Click += new System.EventHandler(this.btnMenuCategory_Click);
            // 
            // btnMenuUnits
            // 
            this.btnMenuUnits.Name = "btnMenuUnits";
            this.btnMenuUnits.Size = new System.Drawing.Size(130, 22);
            this.btnMenuUnits.Text = "Units";
            this.btnMenuUnits.Click += new System.EventHandler(this.btnMenuUnits_Click);
            // 
            // grbProductName
            // 
            this.grbProductName.Controls.Add(this.txbProductName);
            this.grbProductName.Location = new System.Drawing.Point(13, 27);
            this.grbProductName.Name = "grbProductName";
            this.grbProductName.Size = new System.Drawing.Size(267, 51);
            this.grbProductName.TabIndex = 2;
            this.grbProductName.TabStop = false;
            this.grbProductName.Text = "Name";
            // 
            // txbProductName
            // 
            this.txbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProductName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productsBindingSource, "id", true));
            this.txbProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "name", true));
            this.txbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductName.Location = new System.Drawing.Point(6, 19);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(238, 26);
            this.txbProductName.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grbStockKeepingUnit
            // 
            this.grbStockKeepingUnit.Controls.Add(this.nmrStockKeepingUnit);
            this.grbStockKeepingUnit.Location = new System.Drawing.Point(13, 84);
            this.grbStockKeepingUnit.Name = "grbStockKeepingUnit";
            this.grbStockKeepingUnit.Size = new System.Drawing.Size(267, 51);
            this.grbStockKeepingUnit.TabIndex = 3;
            this.grbStockKeepingUnit.TabStop = false;
            this.grbStockKeepingUnit.Text = "Stock Keeping Unit";
            // 
            // nmrStockKeepingUnit
            // 
            this.nmrStockKeepingUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrStockKeepingUnit.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productsBindingSource, "id", true));
            this.nmrStockKeepingUnit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "stock_keeping_unit", true));
            this.nmrStockKeepingUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrStockKeepingUnit.Location = new System.Drawing.Point(7, 20);
            this.nmrStockKeepingUnit.Name = "nmrStockKeepingUnit";
            this.nmrStockKeepingUnit.Size = new System.Drawing.Size(237, 26);
            this.nmrStockKeepingUnit.TabIndex = 0;
            // 
            // grbPrice
            // 
            this.grbPrice.Controls.Add(this.nmrPrice);
            this.grbPrice.Location = new System.Drawing.Point(13, 141);
            this.grbPrice.Name = "grbPrice";
            this.grbPrice.Size = new System.Drawing.Size(267, 51);
            this.grbPrice.TabIndex = 4;
            this.grbPrice.TabStop = false;
            this.grbPrice.Text = "Price";
            // 
            // nmrPrice
            // 
            this.nmrPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrPrice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productsBindingSource, "id", true));
            this.nmrPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "price", true));
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrPrice.Location = new System.Drawing.Point(7, 20);
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(237, 26);
            this.nmrPrice.TabIndex = 0;
            // 
            // grbCategoryName
            // 
            this.grbCategoryName.Controls.Add(this.cmbCategories);
            this.grbCategoryName.Location = new System.Drawing.Point(12, 198);
            this.grbCategoryName.Name = "grbCategoryName";
            this.grbCategoryName.Size = new System.Drawing.Size(267, 55);
            this.grbCategoryName.TabIndex = 5;
            this.grbCategoryName.TabStop = false;
            this.grbCategoryName.Text = "Category Name";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productsBindingSource, "category_id", true));
            this.cmbCategories.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "category_name", true));
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(7, 20);
            this.cmbCategories.MaxDropDownItems = 100;
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(238, 28);
            this.cmbCategories.TabIndex = 0;
            // 
            // grbUnitName
            // 
            this.grbUnitName.Controls.Add(this.cmbUnits);
            this.grbUnitName.Location = new System.Drawing.Point(13, 259);
            this.grbUnitName.Name = "grbUnitName";
            this.grbUnitName.Size = new System.Drawing.Size(267, 51);
            this.grbUnitName.TabIndex = 6;
            this.grbUnitName.TabStop = false;
            this.grbUnitName.Text = "Unit Name";
            // 
            // cmbUnits
            // 
            this.cmbUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productsBindingSource, "unit_id", true));
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "unit_name", true));
            this.cmbUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(6, 17);
            this.cmbUnits.MaxDropDownItems = 100;
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(238, 28);
            this.cmbUnits.TabIndex = 7;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(190, 331);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(80, 38);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Green;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(104, 331);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(80, 38);
            this.btnEditProduct.TabIndex = 8;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Blue;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 331);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(80, 38);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.productManagementDs;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.grbUnitName);
            this.Controls.Add(this.grbCategoryName);
            this.Controls.Add(this.grbPrice);
            this.Controls.Add(this.grbStockKeepingUnit);
            this.Controls.Add(this.grbProductName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagementDs)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.grbProductName.ResumeLayout(false);
            this.grbProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grbStockKeepingUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrStockKeepingUnit)).EndInit();
            this.grbPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            this.grbCategoryName.ResumeLayout(false);
            this.grbUnitName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCategory;
        private System.Windows.Forms.ToolStripMenuItem btnMenuUnits;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataAccess.DataSets.ProductManagementDs productManagementDs;
        private System.Windows.Forms.GroupBox grbProductName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grbStockKeepingUnit;
        private System.Windows.Forms.NumericUpDown nmrStockKeepingUnit;
        private System.Windows.Forms.GroupBox grbPrice;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.GroupBox grbCategoryName;
        private System.Windows.Forms.GroupBox grbUnitName;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockkeepingunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
    }
}

