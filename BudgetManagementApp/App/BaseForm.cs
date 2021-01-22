using System.Collections;
using System.Collections.Generic;
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
            const int prefix = 3;

            var controlsToSetLabels = new Dictionary<string, string>
            {
                ["Labels"] = "Lbl",
                ["Buttons"] = "Btn",
                ["Tabs"] = "Tab",
            };

            foreach (Control control in controls)
            {
                var name = control.Name;

                if (controlsToSetLabels.Values.Any(ctrl => name.StartsWith(ctrl)))
                {
                    control.Text = StringResourcesHandler.GetString(
                        name.Substring(prefix, name.Length - prefix)
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