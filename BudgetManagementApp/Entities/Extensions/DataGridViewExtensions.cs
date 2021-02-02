using System.Windows.Forms;

namespace BudgetManagementApp.Entities.Extensions
{
    public static class DataGridViewExtensions
    {
        public static bool HasDataSource(this DataGridView grid)
        {
            return grid.DataSource != null;
        }

        public static bool IsEmpty(this DataGridView grid)
        {
            return
                grid.DataSource == null ||
                grid.RowCount == 0;
        }

        public static bool HasValue(this DataGridView grid)
        {
            return !IsEmpty(grid);
        }

        public static DataGridViewRow GetRow(this DataGridView grid, int rowIndex)
        {
            return grid.Rows[rowIndex];
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

        public static DataGridViewRow GetSelectedRow(this DataGridView grid)
        {
            return grid.SelectedRows[0];
        }

        public static DataGridViewCell GetSelectedRowCell(
            this DataGridView grid,
            int columnIndex
        )
        {
            return grid.GetSelectedRow().Cells[columnIndex];
        }

        public static DataGridViewCell GetSelectedRowCell(
            this DataGridView grid,
            string columnName
        )
        {
            return grid.GetSelectedRow().Cells[columnName];
        }

        public static T GetSelectedRowValue<T>(
            this DataGridView grid,
            int columnIndex
        )
        {
            if (grid.HasValue())
            {
                return (T)grid.GetSelectedRow().Cells[columnIndex].Value;
            }

            return default;
        }

        public static T GetSelectedRowValue<T>(
            this DataGridView grid,
            string columnName
        )
        {
            if (grid.HasValue())
            {
                return (T)grid.GetSelectedRow().Cells[columnName].Value;
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

        public static DataGridViewRow FirstRow(this DataGridView grid)
        {
            return grid.GetRow(0);
        }

        public static T FirstRow<T>(this DataGridView grid, string columnName)
        {
            return grid.GetRowValue<T>(0, columnName);
        }

        public static T Value<T>(this DataGridViewRow row, int rowIndex)
        {
            return (T)row.Cells[rowIndex].Value;
        }

        public static T Value<T>(this DataGridViewRow row, string columnName)
        {
            return (T)row.Cells[columnName].Value;
        }

        public static void FormatColumn(
            this DataGridView grid, 
            string format, 
            params string[] columns
        )
        {
            foreach (var columnName in columns)
            {
                grid.Columns[columnName].DefaultCellStyle.Format = format;
            }
        }
    }
}