using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            return _context.List.Where(x => x.Id == userId).ToList();
        }

        public Ingredient RemoveFromList(Ingredient ingredient)
        {
            _context.Ingredient.Attach(ingredient);
            ingredient.IsDeleted = true;
            _context.Entry(ingredient).Property(i => i.IsDeleted).IsModified = true;
            _context.Entry(ingredient).State = EntityState.Modified;
            _context.SaveChanges();
            return ingredient;
        }

        public Ingredient AddToList(Ingredient ingredient)
        {
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }
    }
}
