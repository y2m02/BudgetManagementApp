﻿using System.Collections;
using System.Windows.Forms;

namespace BudgetManagementApp.Services.Extensions
{
    public static class ComboBoxExtensions
    {
        public static bool HasDataSource(this ComboBox cbx)
        {
            return cbx.DataSource != null;
        }

        public static bool IsEmpty(this ComboBox cbx)
        {
            return 
                cbx.DataSource == null || 
                ((IList) cbx.DataSource).Count == 0;
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
            return cbx.HasValue() 
                ? (T)cbx.SelectedValue 
                : default;
        }
    }
}