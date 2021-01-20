using System.Windows.Forms;

namespace BudgetManagementApp.Services.Extensions
{
    public static class DataGridViewExtensions
    {
        public static bool IsEmpty(this DataGridView dgv)
        {
            return
                dgv.DataSource == null ||
                dgv.RowCount == 0;
        }

        public static bool HasValue(this DataGridView dgv)
        {
            return !IsEmpty(dgv);
        }

        public static DataGridViewRow GetRow(this DataGridView dgv, int rowIndex)
        {
            return dgv.Rows[rowIndex];
        }

        public static T GetRowValue<T>(
            this DataGridView dgv,
            int rowIndex,
            int columnIndex
        )
        {
            if (dgv.HasValue())
            {
                return (T)dgv.GetRow(rowIndex).Cells[columnIndex].Value;
            }

            return default;
        }

        public static T GetRowValue<T>(
            this DataGridView dgv,
            int rowIndex,
            string columnName
        )
        {
            if (dgv.HasValue())
            {
                return (T)dgv.GetRow(rowIndex).Cells[columnName].Value;
            }

            return default;
        }

        public static DataGridViewRow GetSelectedRow(this DataGridView dgv)
        {
            return dgv.SelectedRows[0];
        }

        public static DataGridViewCell GetSelectedRowCell(
            this DataGridView dgv,
            int columnIndex
        )
        {
            return dgv.GetSelectedRow().Cells[columnIndex];
        }

        public static DataGridViewCell GetSelectedRowCell(
            this DataGridView dgv,
            string columnName
        )
        {
            return dgv.GetSelectedRow().Cells[columnName];
        }

        public static T GetSelectedRowValue<T>(
            this DataGridView dgv,
            int columnIndex
        )
        {
            if (dgv.HasValue())
            {
                return (T)dgv.GetSelectedRow().Cells[columnIndex].Value;
            }

            return default;
        }

        public static T GetSelectedRowValue<T>(
            this DataGridView dgv,
            string columnName
        )
        {
            if (dgv.HasValue())
            {
                return (T)dgv.GetSelectedRow().Cells[columnName].Value;
            }

            return default;
        }

        public static void SetSelectedRow(this DataGridView grid, int rowIndex)
        {
            grid.Rows[rowIndex].Selected = true;
        }

        public static bool HasRowsSelected(this DataGridView grid)
        {
            return grid.SelectedRows.Count > 0;
        }
    }
}