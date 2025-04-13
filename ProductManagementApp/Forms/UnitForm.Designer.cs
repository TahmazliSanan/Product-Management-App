namespace ProductManagementApp.Forms
{
    partial class UnitForm
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
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productManagementDs = new ProductManagementApp.DataAccess.DataSets.ProductManagementDs();
            this.grbUnitName = new System.Windows.Forms.GroupBox();
            this.txbUnitName = new System.Windows.Forms.TextBox();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagementDs)).BeginInit();
            this.grbUnitName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnits
            // 
            this.dgvUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnits.AutoGenerateColumns = false;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvUnits.DataSource = this.unitsBindingSource;
            this.dgvUnits.Location = new System.Drawing.Point(2, 3);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.Size = new System.Drawing.Size(325, 393);
            this.dgvUnits.TabIndex = 0;
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
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.productManagementDs;
            // 
            // productManagementDs
            // 
            this.productManagementDs.DataSetName = "ProductManagementDs";
            this.productManagementDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbUnitName
            // 
            this.grbUnitName.Controls.Add(this.txbUnitName);
            this.grbUnitName.Location = new System.Drawing.Point(2, 402);
            this.grbUnitName.Name = "grbUnitName";
            this.grbUnitName.Size = new System.Drawing.Size(314, 58);
            this.grbUnitName.TabIndex = 2;
            this.grbUnitName.TabStop = false;
            this.grbUnitName.Text = "Name";
            // 
            // txbUnitName
            // 
            this.txbUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUnitName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.unitsBindingSource, "id", true));
            this.txbUnitName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "name", true));
            this.txbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnitName.Location = new System.Drawing.Point(28, 19);
            this.txbUnitName.Name = "txbUnitName";
            this.txbUnitName.Size = new System.Drawing.Size(267, 29);
            this.txbUnitName.TabIndex = 0;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUnit.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUnit.Location = new System.Drawing.Point(202, 466);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(80, 38);
            this.btnDeleteUnit.TabIndex = 7;
            this.btnDeleteUnit.Text = "Delete";
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.BackColor = System.Drawing.Color.Green;
            this.btnEditUnit.ForeColor = System.Drawing.Color.White;
            this.btnEditUnit.Location = new System.Drawing.Point(116, 466);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(80, 38);
            this.btnEditUnit.TabIndex = 6;
            this.btnEditUnit.Text = "Edit";
            this.btnEditUnit.UseVisualStyleBackColor = false;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.Blue;
            this.btnAddUnit.ForeColor = System.Drawing.Color.White;
            this.btnAddUnit.Location = new System.Drawing.Point(30, 466);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(80, 38);
            this.btnAddUnit.TabIndex = 5;
            this.btnAddUnit.Text = "Add";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 507);
            this.Controls.Add(this.btnDeleteUnit);
            this.Controls.Add(this.btnEditUnit);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.grbUnitName);
            this.Controls.Add(this.dgvUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Units";
            this.Load += new System.EventHandler(this.UnitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagementDs)).EndInit();
            this.grbUnitName.ResumeLayout(false);
            this.grbUnitName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.GroupBox grbUnitName;
        private System.Windows.Forms.TextBox txbUnitName;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private DataAccess.DataSets.ProductManagementDs productManagementDs;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}