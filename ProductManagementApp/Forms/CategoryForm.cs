using ProductManagementApp.AppCode.Extensions;
using ProductManagementApp.DataAccess.DataSets;
using ProductManagementApp.DataAccess.Helpers;
using System.Windows.Forms;

namespace ProductManagementApp.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            dgvCategories.InitDefault();
        }

        private void CategoryForm_Load(object sender, System.EventArgs e)
        {
            productManagementDs.Categories.FillCategories();
        }

        private void btnAddCategory_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCategoryName.Text))
            {
                errorProvider.SetError(txbCategoryName, "Invalid category name!");
                return;
            }

            productManagementDs.Categories.AddCategory(txbCategoryName.Text);
            txbCategoryName.Clear();
            txbCategoryName.Focus();
        }

        private void btnEditCategory_Click(object sender, System.EventArgs e)
        {
            var selectedRow = categoriesBindingSource.GetSelectedRow<ProductManagementDs.CategoriesRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }

            txbCategoryName.Clear();
            txbCategoryName.Focus();
            productManagementDs.Categories.EditCategory(selectedRow.name, selectedRow.id);
        }

        private void btnDeleteCategory_Click(object sender, System.EventArgs e)
        {
            var selectedRow = categoriesBindingSource.GetSelectedRow<ProductManagementDs.CategoriesRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }
            else if (Extension.ShowQuestion("Are you sure?") != DialogResult.OK)
            {
                return;
            }

            txbCategoryName.Clear();
            txbCategoryName.Focus();
            productManagementDs.Categories.DeleteCategory(selectedRow.id);
        }
    }
}
