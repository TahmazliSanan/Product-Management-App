using System.Windows.Forms;

namespace ProductManagementApp.AppCode.Extensions
{
    public static partial class Extension
    {
        public static void ConfigureNumericUpDownComponent(
            this NumericUpDown numericUpDown)
        {
            numericUpDown.Maximum = int.MaxValue;
        }
    }
}
