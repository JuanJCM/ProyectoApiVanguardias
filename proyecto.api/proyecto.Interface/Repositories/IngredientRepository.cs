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

    }
}
