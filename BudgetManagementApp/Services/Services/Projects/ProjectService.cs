using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Repositories.Repositories.Projects;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.Projects
{
    public class ProjectService :
        BaseService<Project, ProjectViewModel>,
        IProjectService
    {
        private readonly IProjectRepository projectRepository;

        public ProjectService(
            IMapper mapper,
            IProjectRepository projectRepository
        ) : base(mapper)
        {
            this.projectRepository = projectRepository;
        }

        protected override IBaseRepository<Project> Repository => projectRepository;
    }
}