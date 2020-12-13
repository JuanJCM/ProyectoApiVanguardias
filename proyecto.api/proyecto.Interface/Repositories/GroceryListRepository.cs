using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using proyecto.Core;

namespace proyecto.Infrastructure.Repositories
{
    class GroceryListRepository<T> : IGroceryListRepository<T>
    {
        protected readonly ProyectoDbContext _context;

        public GroceryListRepository(ProyectoDbContext context)
        {
            _context = context;
        }

        public void ClearList(int listId)
        {
            var ingredients = _context.Ingredient.Where(i => i.ListId == listId);
            ingredients.ToList().ForEach(i => {
                i.IsDeleted = true;
            });
            _context.SaveChanges();
        }

        public IEnumerable<GroceryList> GetFromUser(int userId)
        {
            return _context.List.Where(x => x.Id == userId)
                .Include(x => x.Items)
                .ToList();
        }

        public Ingredient RemoveIngredientFromList(Ingredient ingredient)
        {
            _context.Ingredient.Attach(ingredient);
            ingredient.IsDeleted = true;
            _context.Entry(ingredient).Property(i => i.IsDeleted).IsModified = true;
            _context.Entry(ingredient).State = EntityState.Modified;
            _context.SaveChanges();
            return ingredient;
        }

        public Ingredient AddIngredientToList(Ingredient ingredient)
        {
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

        public IEnumerable<Ingredient> GetIngredientsFromList(int listId)
        {
            return _context.Ingredient.Where(i => i.ListId == listId);
        }
    }
}
