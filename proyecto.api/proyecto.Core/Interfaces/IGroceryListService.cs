using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Interfaces
{
    public interface IGroceryListService
    {
        ServiceResult<IEnumerable<GroceryList>> GetAll();

        ServiceResult<IEnumerable<GroceryList>> GetAllFromUser(int userId);

        ServiceResult<GroceryList> GetByID(int Id);

        ServiceResult<GroceryList> NewList(GroceryList groceryList);

        ServiceResult<GroceryList> Update(GroceryList groceryList);

        ServiceResult<GroceryList> AddToList(int listId, Ingredient ingredient);

        ServiceResult<GroceryList> RemoveFromList(int listId, Ingredient ingredient);

        ServiceResult<GroceryList> ClearList(int id);

    }
}
