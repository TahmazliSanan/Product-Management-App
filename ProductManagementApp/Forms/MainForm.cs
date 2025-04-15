using ProductManagementApp.AppCode.Extensions;
using ProductManagementApp.DataAccess.DataSets;
using ProductManagementApp.DataAccess.Helpers;
using ProductManagementApp.Forms;
using System;
using System.Windows.Forms;

namespace ProductManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvProducts.InitDefault();
        }

        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show(this);
        }

        private void btnMenuUnits_Click(object sender, EventArgs e)
        {
            UnitForm unitForm = new UnitForm();
            unitForm.Show(this);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbProductName.Text))
            {
                errorProvider.SetError(txbProductName, "Invalid name!");
                return;
            }
            if (string.IsNullOrEmpty(nmrStockKeepingUnit.Value.ToString()))
            {
                errorProvider.SetError(nmrStockKeepingUnit, "Invalid stock keeping unit!");
                return;
            }
            if (string.IsNullOrEmpty(nmrPrice.Value.ToString()))
            {
                errorProvider.SetError(nmrPrice, "Invalid price!");
                return;
            }
            if (cmbCategories.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCategories, "Invalid category!");
                return;
            }
            if (cmbUnits.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbUnits, "Invalid unit!");
                return;
            }

            productManagementDs.Products
                .AddProduct(txbProductName.Text, Convert.ToInt32(nmrStockKeepingUnit.Value), nmrPrice.Value, cmbCategories.SelectedIndex + 1, cmbUnits.SelectedIndex + 1);
            MessageBox.Show(this, "Product is added successfully!", "Add Product");
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = productsBindingSource.GetSelectedRow<ProductManagementDs.ProductsRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }

            productManagementDs.Products
                .EditProduct(txbProductName.Text, Convert.ToInt32(nmrStockKeepingUnit.Value), nmrPrice.Value, cmbCategories.SelectedIndex + 1, cmbUnits.SelectedIndex + 1, selectedRow.id);
            MessageBox.Show(this, "Product is updated successfully!", "Edit Product");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nmrStockKeepingUnit.ConfigureNumericUpDownComponent();
            nmrPrice.ConfigureNumericUpDownComponent();
            cmbCategories.FillCategoriesToComboBox();
            cmbUnits.FillUnitsToComboBox();
            productManagementDs.Products.FillProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = productsBindingSource.GetSelectedRow<ProductManagementDs.ProductsRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }
            else if (Extension.ShowQuestion("Are you sure?") != DialogResult.OK)
            {
                return;
            }

            productManagementDs.Products.DeleteProduct(selectedRow.id);
            MessageBox.Show(this, "Product is deleted successfully!", "Delete Product");
        }
    }
}
