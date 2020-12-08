using System;
using Microsoft.EntityFrameworkCore;
using proyecto.Core.Entities;
using proyecto.Infrastructure.Configurations; 

namespace proyecto.Infrastructure
{
    public class ProyectoDbContext : DbContext
    {
        public ProyectoDbContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<GroceryList> List { get; set; }      
        public DbSet<Recipe> Recepy{get; set;}
        public DbSet<Reminder> Reminder { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            modelBuilder.ApplyConfiguration(new GroceryListConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeConfiguration());
            modelBuilder.ApplyConfiguration(new ReminderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }
    }
}
