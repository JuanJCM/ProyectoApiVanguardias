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
    public class GroceryListService : IGroceryListService
    {
        private readonly IRepository<GroceryList> _groceryListIRepository;
        private readonly IGroceryListRepository<GroceryList> _groceryListRepository;

        public GroceryListService(IRepository<GroceryList> groceryListIRepository, IGroceryListRepository<GroceryList> groceryListRepository)
        {
            _groceryListIRepository = groceryListIRepository;
            _groceryListRepository = groceryListRepository;
        }

        public ServiceResult<GroceryList> NewList(GroceryList groceryList)
        {
            return ServiceResult<GroceryList>.SuccessResult(_groceryListIRepository.Add(groceryList));
        }

        public ServiceResult<Ingredient> AddIngredientToList(Ingredient ingredient)
        {
            return ServiceResult<Ingredient>.SuccessResult(_groceryListRepository.AddIngredientToList(ingredient));
        }

        public ServiceResult<Ingredient> RemoveIngredientFromList(Ingredient ingredient)
        {
            return ServiceResult<Ingredient>.SuccessResult(_groceryListRepository.RemoveIngredientFromList(ingredient));
        }

        public void ClearList(int id)
        {
            _groceryListRepository.ClearList(id);
        }

        public ServiceResult<IEnumerable<GroceryList>> GetAll()
        {
            return ServiceResult<IEnumerable<GroceryList>>.SuccessResult(_groceryListIRepository.GetAll());
        }

        public ServiceResult<GroceryList> GetByID(int Id)
        {
            return ServiceResult<GroceryList>.SuccessResult(_groceryListIRepository.GetById(Id));
        }

        public ServiceResult<IEnumerable<GroceryList>> GetAllFromUser(int userId)
        {
            return ServiceResult<IEnumerable<GroceryList>>.SuccessResult(_groceryListRepository.GetFromUser(userId));
        }

        public ServiceResult<IEnumerable<Ingredient>> GetIngredientsFromList(int Id)
        {
            return ServiceResult<IEnumerable<Ingredient>>.SuccessResult(_groceryListRepository.GetIngredientsFromList(Id));
        }
    }
}
