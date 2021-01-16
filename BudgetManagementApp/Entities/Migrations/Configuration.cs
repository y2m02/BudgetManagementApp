using System.Data.Entity.Migrations;

namespace BudgetManagementApp.Entities.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Entities.Models.ButgetManagementAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Entities.Models.ButgetManagementAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
