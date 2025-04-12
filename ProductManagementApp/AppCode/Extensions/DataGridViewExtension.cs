using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductManagementApp.AppCode.Extensions
{
    public static partial class Extension
    {
        public static DataGridView InitDefault(
            this DataGridView dgv, 
            bool readonlyCell = true)
        {
            Font font = new Font(dgv.Font.FontFamily, 10);
            Font fontBold = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);
            Padding padding = new Padding(2);

            dgv.BorderStyle = BorderStyle.None;
            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersDefaultCellStyle.Padding = padding;
            dgv.ColumnHeadersDefaultCellStyle.Font = fontBold;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Cursor = Cursors.Hand;
            dgv.Font = font;
            dgv.BackgroundColor = SystemColors.Control;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F3F3");
            dgv.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808080");
            dgv.RowsDefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#ffffff");

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.ReadOnly = readonlyCell;
                col.DefaultCellStyle.Padding = padding;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                if (col.HeaderText.Equals("#") || col.HeaderText.Equals("Id"))
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Resizable = DataGridViewTriState.False;
                    col.Width = 50;
                    col.MinimumWidth = 50;
                }
            }


            dgv.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                if (dgv.Rows.Count > 0 && e.Button == MouseButtons.Right)
                {
                    DataGridView.HitTestInfo hti = dgv.HitTest(e.X, e.Y);
                    dgv.ClearSelection();
                    
                    if (hti.RowIndex < 0)
                    {
                        dgv.Rows[0].Selected = true;
                    }
                    else
                    {
                        dgv.Rows[hti.RowIndex].Selected = true;
                    }
                }
            };

            return dgv;
        }

        public static T GetSelectedRow<T>(this DataGridView dgv)
            where T : DataRow
        {
            if (dgv.SelectedRows.Count < 1)
            {
                return null;
            }

            DataGridViewRow selectedRow = dgv.SelectedRows[0];
            DataRow dataRow = (selectedRow.DataBoundItem as DataRowView)?.Row;
            
            T boundedRow = dataRow as T;
            return boundedRow;
        }

        public static IEnumerable<T> GetSelectedRows<T>(this DataGridView dgv)
            where T : DataRow
        {
            List<T> selecteds = Enumerable.Empty<T>().ToList();

            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                DataRow dataRow = (row.DataBoundItem as DataRowView)?.Row;
                T boundedRow = dataRow as T;

                if (boundedRow == null)
                {
                    break;
                }

                selecteds.Add(boundedRow);
            }

            return selecteds;
        }

        public static T GetSelectedRow<T>(this BindingSource bindingSource)
        where T : DataRow
        {
            DataRow dataRow = (bindingSource.Current as DataRowView)?.Row;
            return dataRow as T;
        }
    }
}
