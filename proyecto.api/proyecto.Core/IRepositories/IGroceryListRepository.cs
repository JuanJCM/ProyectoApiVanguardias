using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.IRepositories
{
    public interface IGroceryListRepository<T>
    {
        Ingredient AddIngredientToList(Ingredient ingredient);

        Ingredient RemoveIngredientFromList(Ingredient ingredient);

        void ClearList(int listId);

        IEnumerable<Ingredient> GetIngredientsFromList(int listId);

        IEnumerable<GroceryList> GetFromUser(int userId);
    }
}
