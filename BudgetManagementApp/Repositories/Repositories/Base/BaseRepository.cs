using System.Collections.Generic;
using System.Data.Entity;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected BaseRepository(BudgetManagementAppContext context)
        {
            Context = context;
        }

        protected BudgetManagementAppContext Context { get; }

        protected void Add<TModel>(TModel entity)
        {
            Context.Entry(entity).State = EntityState.Added;

            SaveChangesAndDetach(entity);
        }

        protected void Modify<TModel>(TModel entity)
        {
            Context.Entry(entity).State = EntityState.Modified;

            SaveChangesAndDetach(entity);
        }

        protected void Remove<TModel>(TModel entity)
        {
            Modify(entity);
        }

        protected void AddPropertiesToModify<TModel>(TModel entity, List<string> properties)
        {
            properties.ForEach(propertyName =>
            {
                Context.Entry(entity).Property(propertyName).IsModified = true;
            });
        }

        private void SaveChangesAndDetach<TModel>(TModel entity)
        {
            Context.SaveChanges();

            Context.Entry(entity).State = EntityState.Detached;
        }
    }
}