using System.Collections;
using System.Windows.Forms;

namespace BudgetManagementApp.Entities.Extensions
{
    public static class ComboBoxExtensions
    {
        public static bool HasDataSource(this ComboBox cbx)
        {
            return cbx.DataSource != null;
        }

        public static void ClearDataSource(this ComboBox cbx)
        {
            cbx.DataSource = null;
        }

        public static bool IsEmpty(this ComboBox cbx)
        {
            return
                cbx.DataSource == null ||
                ((IList)cbx.DataSource).Count == 0;
        }

        public static bool HasValue(this ComboBox cbx)
        {
            return !IsEmpty(cbx);
        }

        public static void SetData(
            this ComboBox cbx,
            object source,
            string valueMember,
            string displayMember
        )
        {
            cbx.DataSource = source;
            cbx.ValueMember = valueMember;
            cbx.DisplayMember = displayMember;
        }

        public static T SafeSelectedValue<T>(this ComboBox cbx)
        {
            var value = default(T);

            if (cbx.HasValue() && cbx.SelectedValue is not null)
            {
                try
                {
                    value = (T)cbx.SelectedValue;
                }
                catch { }
            }

            return value;
        }

        public static void SetSelectedValue(this ComboBox cbx, object value)
        {
            cbx.SelectedValue = value;
        }
    }
}