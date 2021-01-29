using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Repositories.Repositories.Base;

namespace BudgetManagementApp.Repositories.Repositories.Projects
{
    public class ProjectRepository :
        BaseRepository<Project>,
        IProjectRepository
    {
        public ProjectRepository(
            BudgetManagementAppContext context
        ) : base(context)
        {
        }

        public IEnumerable<Project> GetAll()
        {
            return Context.Projects
                .Include(w => w.AccountingMovements)
                .Where(w => !w.DeletedOn.HasValue)
                .OrderByDescending(w => w.ProjectId)
                .AsNoTracking();
        }

        public void Create(Project entity)
        {
            Add(entity);
        }

        public void Update(Project entity)
        {
            Modify(entity);
        }

        public void Delete(Project entity)
        {
            Remove(entity);
        }
    }
}