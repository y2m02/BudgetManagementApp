using BudgetManagementApp.Properties;
using System.Windows.Forms;

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
    }
}
