using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagementApp.Services.Extensions
{
    public static class ControlExtensions
    {
        public static T GetSafeControl<T>(
            this Control.ControlCollection controls,
            string name
        )
            where T : Control
        {
            var control = default(T);

            try
            {
                control = (T)controls.Cast<Control>().FirstOrDefault(
                    w => w.Name == name
                );
            }
            catch { }

            return control;
        }

        public static void SetText(this Control control, string text)
        {
            control.Text = text;
        }
    }
}
