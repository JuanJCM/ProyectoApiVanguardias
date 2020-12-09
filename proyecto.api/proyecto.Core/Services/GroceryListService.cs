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
    public class GroceryListService : IGroceryListService
    {
        private readonly IRepository<GroceryList> _groceryListRepository;

        public GroceryListService(IRepository<GroceryList> groceryListRepository)
        {
            _groceryListRepository = groceryListRepository;
        }

        public ServiceResult<GroceryList> Add(GroceryList groceryList)
        {
            return ServiceResult<GroceryList>.SuccessResult(_groceryListRepository.Add(groceryList));
        }

        public ServiceResult<IEnumerable<GroceryList>> GetAll()
        {
            return ServiceResult<IEnumerable<GroceryList>>.SuccessResult(_groceryListRepository.GetAll());
        }

        public ServiceResult<GroceryList> GetByID(int Id)
        {
            return ServiceResult<GroceryList>.SuccessResult(_groceryListRepository.GetById(Id));
        }

        public ServiceResult<GroceryList> Update(GroceryList groceryList)
        {
            return ServiceResult<GroceryList>.SuccessResult(_groceryListRepository.Update(groceryList));
        }
    }
}
