using ProductManagementApp.AppCode.Extensions;
using ProductManagementApp.DataAccess.DataSets;
using ProductManagementApp.DataAccess.Helpers;
using System.Windows.Forms;

namespace ProductManagementApp.Forms
{
    public partial class UnitForm : Form
    {
        public UnitForm()
        {
            InitializeComponent();
            dgvUnits.InitDefault();
        }

        private void UnitForm_Load(object sender, System.EventArgs e)
        {
            productManagementDs.Units.FillUnits();
        }

        private void btnAddUnit_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUnitName.Text))
            {
                errorProvider.SetError(txbUnitName, "Invalid name!");
                return;
            }

            productManagementDs.Units.AddUnit(txbUnitName.Text);
            txbUnitName.Clear();
            txbUnitName.Focus();
        }

        private void btnEditUnit_Click(object sender, System.EventArgs e)
        {
            var selectedRow = unitsBindingSource.GetSelectedRow<ProductManagementDs.UnitsRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }

            txbUnitName.Clear();
            txbUnitName.Focus();
            productManagementDs.Units.EditUnit(selectedRow.name, selectedRow.id);
        }

        private void btnDeleteUnit_Click(object sender, System.EventArgs e)
        {
            var selectedRow = unitsBindingSource.GetSelectedRow<ProductManagementDs.UnitsRow>();

            if (selectedRow is null)
            {
                Extension.ShowError("Row is not selected!");
                return;
            }
            else if (Extension.ShowQuestion("Are you sure?") != DialogResult.OK)
            {
                return;
            }

            txbUnitName.Clear();
            txbUnitName.Focus();
            productManagementDs.Units.DeleteUnit(selectedRow.id);
        }
    }
}
