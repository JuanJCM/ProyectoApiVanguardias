using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Core.Entities;
using proyecto.Core.Interfaces;
using proyecto.Core.IRepositories;

namespace proyecto.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository<Ingredient> _ingredientListIRepository;

        public IngredientService(IRepository<Ingredient> ingredientIRepository)
        {
            _ingredientListIRepository = ingredientIRepository;
        }

        public ServiceResult<Ingredient> GetByID(int Id)
        {
            return ServiceResult<Ingredient>.SuccessResult(_ingredientListIRepository.GetById(Id));
        }

    }
}
