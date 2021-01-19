using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using BudgetManagementApp.Properties;
using BudgetManagementApp.Test;

namespace BudgetManagementApp
{
    public partial class FrmMain : BaseForm
    {
        private readonly FrmTest frmTest;

        public FrmMain(FrmTest frmTest)
        {
            InitializeComponent();
            this.frmTest = frmTest;

            StringResources.Culture = CultureInfo.CurrentCulture;

            SetLabels();
        }

        private void SetLabels()
        {
            Text = StringResources.BudgetManagement;

            LoopControlsToSetLabels(Controls);

            LoopControlsToSetLabels(TclBudgetManagement.Controls);

            void LoopControlsToSetLabels(IEnumerable controls)
            {
                foreach (var ctrl in controls)
                {
                    var control = (Control) ctrl;

                    var name = control.Name;

                    control.Text = StringResources.ResourceManager.GetString(
                        name.Substring(3, name.Length - 3),
                        StringResources.Culture
                    );
                }
            }
        }
    }
}