using System.Collections.Generic;
using System.Data.Entity;
using BudgetManagementApp.Entities.Helpers;
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

        protected void Save()
        {
            Context.SaveChanges();
        }

        protected void Create<T>(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;

            Save();

            Detach(entity);
        }

        protected void AddPropertiesToModify<T>(T entity, List<string> properties)
        {
            properties.ForEach(propertyName =>
            {
                Context.Entry(entity).Property(propertyName).IsModified = true;
            });
        }

        protected void Delete<T>(T entity) where T : IDeletable
        {
            AddPropertiesToModify(entity, new List<string>
            {
                nameof(entity.DeletedOn),
            });

            Save();

            Detach(entity);
        }

        protected void Detach<T>(T entity)
        {
            Context.Entry(entity).State = EntityState.Detached;
        }
    }
}