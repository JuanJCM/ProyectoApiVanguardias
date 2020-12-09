using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Core.Entities;
using proyecto.Core.Interfaces;
using proyecto.Core.Repositories;

namespace proyecto.Core.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository<Ingredient> _ingredientListIRepository;
        private readonly IIngredientRepository<Ingredient> _ingredientRepository;

        public IngredientService(IRepository<Ingredient> ingredientIRepository, IIngredientRepository<Ingredient> ingredientRepository)
        {
            _ingredientListIRepository = ingredientIRepository;
            _ingredientRepository = ingredientRepository;
        }

        public ServiceResult<Ingredient> AddToList(Ingredient ingredient, int id)
        {
            return ServiceResult<Ingredient>.SuccessResult(_ingredientRepository.AddToList(ingredient, id));
        }

        public ServiceResult<Ingredient> GetByID(int Id)
        {
            return ServiceResult<Ingredient>.SuccessResult(_ingredientListIRepository.GetById(Id));
        }

        public ServiceResult<IEnumerable<Ingredient>> GetFromList(int Id)
        {
            return ServiceResult<IEnumerable<Ingredient>>.SuccessResult(_ingredientRepository.GetFromList(Id));
        }

        public ServiceResult<Ingredient> Update(Ingredient ingredient)
        {
            return ServiceResult<Ingredient>.SuccessResult(_ingredientListIRepository.Update(ingredient));
        }
    }
}
