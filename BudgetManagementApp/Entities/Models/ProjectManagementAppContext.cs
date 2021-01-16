using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BudgetManagementApp.Entities.Migrations;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Payment>().Property(w => w.AmountPaid).HasPrecision(18, 2);
        }

        //public class PatientMappings : EntityTypeConfiguration<Patient>
        //{
        //    public PatientMappings()
        //    {
        //        HasRequired(c => c.PatientHealth).WithRequiredPrincipal(e => e.Patient);
        //        HasRequired(c => c.PlateRegistration).WithRequiredPrincipal(e => e.Patient);
        //    }
        //}
    }
}
