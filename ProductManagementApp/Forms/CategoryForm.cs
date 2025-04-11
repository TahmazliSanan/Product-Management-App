using ProductManagementApp.DataAccess.Helpers;
using System.Windows.Forms;

namespace ProductManagementApp.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, System.EventArgs e)
        {
            productManagementDs.Categories.FillCategories();
        }
    }
}
