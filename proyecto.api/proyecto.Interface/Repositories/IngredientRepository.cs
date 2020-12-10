using proyecto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Infrastructure.Repositories;
using proyecto.Core.Entities;

namespace proyecto.Infrastructure.Repositories
{
    class IngredientRepository<T>: IIngredientRepository<T>
    {
        protected readonly ProyectoDbContext _context;

        public IngredientRepository(ProyectoDbContext context)
        {
            _context = context;
        }

        public Ingredient AddToList(Ingredient ingredient)
        {
            _context.Ingredient.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

        public IEnumerable<Ingredient> GetFromList(int listId)
        {
            return _context.Ingredient.Where(i => i.ListId == listId);
        }
    }
}
