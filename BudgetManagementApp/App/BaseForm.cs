using System.Windows.Forms;

namespace BudgetManagementApp
{
    public abstract class BaseForm : Form
    {
        protected DialogResult DisplayInformationMessage(string message)
        {
            return MessageBox.Show(
                message, 
                "Información", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        protected DialogResult DisplayExclamationMessage(string message)
        {
            return MessageBox.Show(
                message, 
                "Información", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation
            );
        }

        protected DialogResult DisplayQuestionMessage(string message)
        {
            return MessageBox.Show(
                message, 
                "Pregunta", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );
        }

        protected DialogResult DisplayWarningMessage(string message)
        {
            return MessageBox.Show(
                message, 
                "Atención", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning
            );
        }

        protected DialogResult DisplayErrorMessage(string message)
        {
            return MessageBox.Show(
                message, 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
    }
}
