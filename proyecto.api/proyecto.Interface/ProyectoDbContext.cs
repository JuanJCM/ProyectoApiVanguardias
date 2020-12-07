using System;
using Microsoft.EntityFrameworkCore;
using proyecto.Core.Entities;
using proyecto.Interface.Configurations;
namespace proyecto.Interface
{
    public class ProyectoDbContext : DbContext
    {
        public ProyectoDbContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<List> List { get; set; }      
        public DbSet<Recepy> Recepy{get; set;}
        public DbSet<Reminder> Reminder { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModeCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.ApplyConfiguration(new IngredientConfiguration()); 
            modelBuilder.ApplyConfiguration(new ListConfiguration());
            modelBuilder.ApplyConfiguration(new RecepyConfiguration());
            modelBuilder.ApplyConfiguration(new ReminderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
             */

        }
    }
}
