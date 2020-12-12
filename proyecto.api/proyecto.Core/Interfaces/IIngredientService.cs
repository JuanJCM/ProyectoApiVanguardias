using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Interfaces
{
    public interface IIngredientService
    {
        ServiceResult<IEnumerable<Ingredient>> GetIngredientsFromList(int Id);

        ServiceResult<Ingredient> GetByID(int Id);

    }
}
