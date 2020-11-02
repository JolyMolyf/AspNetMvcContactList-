using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrhecstraReadyProject.Data
{
    public class MyDbContext : DbContext
    {
     




        public virtual DbSet<Contact> contacts { get; set; }


        public MyDbContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("Contact_Pk");
                entity.Property(e => e.Married);
                entity.Property(e => e.Name).HasMaxLength(20);
                entity.Property(e => e.Phone).HasMaxLength(10);
                entity.Property(e => e.Salary).HasMaxLength(8);
                entity.Property(e => e.DateOfBirth);
            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=127.0.0.1; port=3306; user=root; password=root; database=files")
                .UseLoggerFactory(LoggerFactory.Create(b =>
                    b.AddConsole().AddFilter(level => level >= LogLevel.Information))).EnableSensitiveDataLogging()
                .EnableDetailedErrors();

        }
    }
}
