using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BudgetManagementApp.Entities.Migrations;

namespace BudgetManagementApp.Entities.Models
{
    public class ButgetManagementAppContext : DbContext
    {
        public ButgetManagementAppContext() : base("name=ButgetManagementApp")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ButgetManagementAppContext, Configuration>()
            );
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }

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
