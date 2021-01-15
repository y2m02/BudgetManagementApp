using System.Data.Entity.Migrations;

namespace ProjectManagementApp.Entities.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Entities.Models.ProjectManagementAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Entities.Models.ProjectManagementAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
