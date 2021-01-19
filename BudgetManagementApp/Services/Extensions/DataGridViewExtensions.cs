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
    }
}
