using BudgetManagementApp.Entities.Extensions;
using BudgetManagementApp.Entities.Helpers;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Forms.Base;
using BudgetManagementApp.Resources.Properties;
using BudgetManagementApp.Services.Services.Projects;
using System;

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

        public ProjectViewModel Project { get; set; }

        private void FrmProjectMaintenance_Load(object sender, EventArgs e)
        {
            SetLabels();

            TxtProjectId.SetText(Project.ProjectId.ToString());

            TxtProjectName.SetText(Project.Name);

            DtpStartDate.Value = Project.StartDate > DateTime.MinValue
                ? Project.StartDate
                : DateTime.Now;

            DtpEndDate.Value = Project.EndDate > DateTime.MinValue
                ? Project.EndDate
                : DateTime.Now;

            TxtContruction.SetText(
                Project.Construction.ToString(CultureData.GetEnglishCulture())
            );

            TxtCost.SetText(
                Project.Cost.ToString(CultureData.GetEnglishCulture())
            );
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