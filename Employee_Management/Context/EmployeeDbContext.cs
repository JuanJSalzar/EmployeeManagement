using Employee_Management.Models;
using System.Data.Entity;

namespace Employee_Management.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// <summary>
            /// Use Fluent API to configure the model
            /// </summary>
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Employee>()
                .ToTable("Employees");

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id)
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Position)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Office)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .IsRequired();
        }
    }
}