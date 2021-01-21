using System.Collections;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp
{
    public class BaseForm : Form
    {
        protected DialogResult DisplayInformationMessage(string message)
        {
            return MessageBox.Show(
                message,
                StringResources.Information,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        protected DialogResult DisplayExclamationMessage(string message)
        {
            return MessageBox.Show(
                message,
                StringResources.Information,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

        protected DialogResult DisplayQuestionMessage(string message)
        {
            return MessageBox.Show(
                message,
                StringResources.Question,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        protected DialogResult DisplayWarningMessage(string message)
        {
            return MessageBox.Show(
                message,
                StringResources.Warning,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
        }

        protected DialogResult DisplayErrorMessage(string message)
        {
            return MessageBox.Show(
                message,
                StringResources.Error,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        protected void LoopControlsToSetLabels(IEnumerable controls)
        {
            string[] controlsToSetLabels = { "Lbl", "Btn", "Tab" };

            foreach (Control control in controls)
            {
                var name = control.Name;

                if (controlsToSetLabels.Any(c => name.StartsWith(c)))
                {
                    control.Text = StringResourcesHandler.GetString(
                        name.Substring(3, name.Length - 3)
                    );
                }
            }
        }

        protected void SetControlsStatus(bool enable, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = enable;
            }
        }

        // TODO: make this method abstract.
        protected virtual void SetLabels()
        {

        }
    }
}