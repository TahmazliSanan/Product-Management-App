using ProductManagementApp.AppCode.Extensions;
using ProductManagementApp.DataAccess.Helpers;
using ProductManagementApp.Exceptions;
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
                errorProvider.SetError(txbCategoryName, 
                    new InvalidCategoryNameException().Message);
                return;
            }

            productManagementDs.Categories.AddCategory(txbCategoryName.Text);
            txbCategoryName.Clear();
            txbCategoryName.Focus();
        }
    }
}
