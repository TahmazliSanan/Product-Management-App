using System.Windows.Forms;

namespace ProductManagementApp.AppCode.Extensions
{
    public static partial class Extension
    {
        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public static DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(message, "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
