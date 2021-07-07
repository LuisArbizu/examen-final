using AppUCA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.Context
{
    public class AppGuiContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Inscription> Inscriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=LAPTOP-P2DP1NT1;Database=ParcialFinalPOO;Trusted_Connection=True;");

        // Model configuration for properties of objects
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Inscription>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
