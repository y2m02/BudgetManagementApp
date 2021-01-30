using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;

namespace BudgetManagementApp.Forms.Base
{
    public class BaseForm : Form
    {
        // TODO: make this method abstract.
        protected virtual void SetLabels()
        {
        }

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

            var controlsToSetLabels = new[]
            {
                typeof(Label),
                typeof(Button),
                typeof(TabPage),
            };

            controls.Cast<Control>()
                .Where(
                    control => controlsToSetLabels.Any(
                        type => type == control.GetType()
                    )
                )
                .Each(control =>
                {
                    var name = control.Name;

                    control.Text = StringResourcesHandler.GetString(
                        name.Substring(prefix, name.Length - prefix)
                    );
                });
        }

        protected void SetControlsStatus(bool enable, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = enable;
            }
        }

        protected void SetAppLabels()
        {
            StringResources.Culture = CultureInfo.CurrentCulture;

            SetLabels();
        }


        protected void Upsert(
            Func<BaseViewModel, BaseReturnViewModel> executor,
            BaseViewModel model
        )
        {
            var result = executor(model);

            if (result.HasValidations())
            {
                var message = result.GetValidations().Join("\n");

                DisplayExclamationMessage(message);

                return;
            }

            if (result.IsSuccess())
            {
                DialogResult = DialogResult.OK;

                Close();

                return;
            }

            DialogResult = DialogResult.None;

            DisplayErrorMessage(result.GetFailureError());
        }
    }
}