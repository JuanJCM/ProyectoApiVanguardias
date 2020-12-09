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

        ServiceResult<GroceryList> GetByID(int Id);

        ServiceResult<GroceryList> Add(GroceryList groceryList);

        ServiceResult<GroceryList> Update(GroceryList groceryList);

    }
}
