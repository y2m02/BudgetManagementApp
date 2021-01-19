using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BudgetManagementApp.Entities;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories
{
    public abstract class BaseRepository
    {
        protected BaseRepository(BudgetManagementAppContext context)
        {
            Context = context;
        }

        protected BudgetManagementAppContext Context { get; }

        protected async Task Save()
        {
            await Context.SaveChangesAsync().ConfigureAwait(false);
        }

        protected async Task Create<T>(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;

            await Save().ConfigureAwait(false);
        }

        protected void AddPropertiesToModify<T>(T entity, List<string> properties)
        {
            properties.ForEach(propertyName =>
            {
                Context.Entry(entity).Property(propertyName).IsModified = true;
            });
        }

        protected async Task Delete<T>(T entity) where T : IDeletable
        {
            AddPropertiesToModify(entity, new List<string>
            {
                nameof(entity.DeletedOn)
            });

            await Save().ConfigureAwait(false);
        }
    }
}
