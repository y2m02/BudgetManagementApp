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

            SaveChangesAndDetach(entity);
        }

        public void Update<T>(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;

            SaveChangesAndDetach(entity);
        }

        protected void Delete<T>(T entity) where T : IDeletable
        {
            Context.Entry(entity).State = EntityState.Modified;
            
            SaveChangesAndDetach(entity);
        }

        protected void Detach<T>(T entity)
        {
            Context.Entry(entity).State = EntityState.Detached;
        }

        protected void AddPropertiesToModify<T>(T entity, List<string> properties)
        {
            properties.ForEach(propertyName =>
            {
                Context.Entry(entity).Property(propertyName).IsModified = true;
            });
        }

        private void SaveChangesAndDetach<T>(T entity)
        {
            Save();

            Detach(entity);
        }
    }
}