using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Repositories
{
    public interface IGroceryListRepository<T>
    {
        T AddToList(int listId, Ingredient ingredient);

        T RemoveFromList(int listId, Ingredient ingredient);

        T ClearList(int listId);

        IEnumerable<T> GetFromUser(int userId);
    }
}
