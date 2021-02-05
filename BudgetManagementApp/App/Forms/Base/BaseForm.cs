using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Resources;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Services.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManagementApp.Forms.Base
{
    public class BaseForm : Form
    {
        // TODO: make this method abstract.
        protected virtual void SetLabels()
        {
            LoopControlsToSetLabels(Controls);
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

        protected static void PopulateGrid<TDataModel>(
            DataGridView grid,
            IEnumerable<TDataModel> data,
            Action<DataGridView, List<string>> formatGrid,
            List<string> columnNames
        )
        {
            grid.DataSource = data.ToList();

            formatGrid(grid, columnNames);
        }

        protected static void SetColumnNames(DataGridView grid, Dictionary<string, string> columnNames)
        {
            if (!grid.HasDataSource())
                return;

            foreach (var columnName in columnNames)
            {
                grid.Columns[columnName.Key].HeaderText = columnName.Value;
            }
        }

        protected void HandleEntity<T>(BaseReturnViewModel result, Action<IEnumerable<T>> executor)
        {
            if (result.IsSuccess<IEnumerable<T>>())
            {
                executor(result.GetSuccessModel<IEnumerable<T>>());
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());
            }
        }

        protected List<T> HandleEntity<T>(BaseReturnViewModel result)
        {
            if (result.IsSuccess<IEnumerable<T>>())
            {
                return result.GetSuccessModel<IEnumerable<T>>().ToList();
            }
            else
            {
                DisplayErrorMessage(result.GetFailureError());

                return new List<T>();
            }
        }

        protected static IEnumerable<T> GetFilteredData<T>(
            string textToSearch,
            IEnumerable<T> model,
            Func<T, bool> filter
        )
            where T : BaseViewModel
        {
            var data = new List<T>(model);

            return textToSearch.HasValue()
                ? data.PrettyWhere(filter)
                : data;
        }

        protected void SetDetailsData(
            DataGridView grid,
            Button btnModify,
            Button btnDelete,
            Action<DataGridViewRow> fillFields
        )
        {
            if (grid.HasRowsSelected())
            {
                fillFields(grid.GetSelectedRow());

                SetControlsStatus(
                    !grid.GetSelectedRowValue<bool>(FieldNames.InUse),
                    btnDelete
                );

                SetControlsStatus(true, btnModify);

                return;
            }

            if (grid.HasValue())
            {
                fillFields(grid.FirstRow());
            }

            SetControlsStatus(false, btnModify, btnDelete);
        }

        protected static void FormatGrid(
            DataGridView grid,
            List<string> columnNamesToHide
        )
        {
            if (!grid.HasDataSource())
                return;

            try
            {
                DisableColumns(grid, columnNamesToHide);
            }
            catch { }
        }

        protected void Delete(
            IBaseService service,
            BaseViewModel model,
            TextBox filter,
            Action executeWhenSuccess,
            string customDeleteMessage = null
        )
        {
            var deleteQuestion = customDeleteMessage.HasValue()
                ? customDeleteMessage
                : StringResources.DeleteQuestion;

            if (!DisplayQuestionMessage(deleteQuestion).IsYesResponse())
                return;

            var result = service.Delete(model);

            if (result.IsSuccess())
            {
                DisplayInformationMessage(StringResources.RecordDeleted);

                filter.Clear();

                executeWhenSuccess();

                return;
            }

            DisplayErrorMessage(result.GetFailureError());
        }

        protected void SelectFirstCbxValue(ComboBox cbx)
        {
            if (cbx.HasValue())
            {
                cbx.SelectedIndex = 0;
            }
        }

        private static void DisableColumns(
            DataGridView grid,
            List<string> columnNames,
            bool disableCommonFields = true
        )
        {
            if (disableCommonFields)
            {
                columnNames.AddRange(new[]
                {
                    FieldNames.Id,
                    FieldNames.Action,
                    FieldNames.DeletedOn,
                    FieldNames.InUse,
                });
            }

            foreach (var columnName in columnNames)
            {
                grid.Columns[columnName].Visible = false;
            }
        }
    }
}