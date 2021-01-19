using BudgetManagementApp.Entities.Migrations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BudgetManagementApp.Entities.Models
{
    public class BudgetManagementAppContext : DbContext
    {
        public BudgetManagementAppContext() : base("name=BudgetManagementApp")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BudgetManagementAppContext, Configuration>()
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<SubType> SubTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<AccountingMovement> AccountingMovements { get; set; }
        public DbSet<BalanceSheet> BalanceSheets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Project>().Property(w => w.Construction).HasPrecision(18, 2);
            modelBuilder.Entity<Project>().Property(w => w.Cost).HasPrecision(18, 2);
            modelBuilder.Entity<AccountingMovement>().Property(w => w.Amount).HasPrecision(18, 2);
        }
    }
}