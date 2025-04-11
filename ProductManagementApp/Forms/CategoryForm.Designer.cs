namespace ProductManagementApp.Forms
{
    partial class CategoryForm
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
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.grbCategoryName = new System.Windows.Forms.GroupBox();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.grbCategoryName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(2, 3);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(322, 406);
            this.dgvCategories.TabIndex = 0;
            // 
            // grbCategoryName
            // 
            this.grbCategoryName.Controls.Add(this.txbCategoryName);
            this.grbCategoryName.Location = new System.Drawing.Point(2, 415);
            this.grbCategoryName.Name = "grbCategoryName";
            this.grbCategoryName.Size = new System.Drawing.Size(322, 53);
            this.grbCategoryName.TabIndex = 1;
            this.grbCategoryName.TabStop = false;
            this.grbCategoryName.Text = "Name";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(3, 16);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(316, 29);
            this.txbCategoryName.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(211, 466);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(110, 38);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 507);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.grbCategoryName);
            this.Controls.Add(this.dgvCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.grbCategoryName.ResumeLayout(false);
            this.grbCategoryName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.GroupBox grbCategoryName;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
    }
}