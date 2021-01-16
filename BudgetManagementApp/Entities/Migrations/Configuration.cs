using System.Data.Entity.Migrations;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Entities.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BudgetManagementAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BudgetManagementAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}