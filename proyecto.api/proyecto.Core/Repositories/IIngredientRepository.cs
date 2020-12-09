using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Repositories
{
    public interface IIngredientRepository<T>
    {
        T AddToList(Ingredient ingredient, int id);

        IEnumerable<T> GetFromList(int id);
    }
}
