using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Extensions;
using BudgetManagementApp.Services.Services.Projects;

namespace BudgetManagementApp.Forms.Projects
{
    public partial class FrmProjectMaintenance : BaseForm
    {
        private readonly IProjectService projectService;

        public FrmProjectMaintenance(IProjectService projectService)
        {
            this.projectService = projectService;
            InitializeComponent();
        }

        private void FrmProjectMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        protected override void SetLabels()
        {
            DtpStartDate.CustomFormat = StringResources.DateFormat;
            DtpEndDate.CustomFormat = StringResources.DateFormat;

            LoopControlsToSetLabels(Controls);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Upsert(projectService.Upsert, new ProjectViewModel
            {
                Id = TxtProjectId.Text.ToIntOrDefault(),
                Name = TxtProjectName.Text,
                Construction = TxtContruction.Text.ToDecimalOrDefault(),
                Cost = TxtCost.Text.ToDecimalOrDefault(),
                StartDate = DtpStartDate.Value.Date,
                EndDate = DtpEndDate.Value.Date,
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
