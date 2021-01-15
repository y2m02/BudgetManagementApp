using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjectManagementApp.Entities.Migrations;

namespace ProjectManagementApp.Entities.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("name=BaseConnection")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BaseContext, Configuration>()
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
