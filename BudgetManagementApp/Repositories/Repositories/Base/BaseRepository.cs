using System.Collections.Generic;
using System.Data.Entity;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories.Base
{
    public abstract class BaseRepository<TModel>
    {
        protected BaseRepository(BudgetManagementAppContext context)
        {
            Context = context;
        }

        protected BudgetManagementAppContext Context { get; }

        protected void Add(TModel entity)
        {
            Context.Entry(entity).State = EntityState.Added;

            SaveChangesAndDetach(entity);
        }

        protected void Modify(TModel entity)
        {
            Context.Entry(entity).State = EntityState.Modified;

            SaveChangesAndDetach(entity);
        }

        protected void Remove(TModel entity)
        {
            Modify(entity);
        }

        protected void AddPropertiesToModify(TModel entity, List<string> properties)
        {
            properties.ForEach(propertyName =>
            {
                Context.Entry(entity).Property(propertyName).IsModified = true;
            });
        }

        private void SaveChangesAndDetach(TModel entity)
        {
            Context.SaveChanges();

            Context.Entry(entity).State = EntityState.Detached;
        }
    }
}