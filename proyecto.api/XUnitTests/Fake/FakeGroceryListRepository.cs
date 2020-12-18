using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTests.Fake
{
    class FakeGroceryListRepository : IGroceryListRepository
    {
        private readonly IEnumerable<GroceryList> _lists;

        public FakeGroceryListRepository()
        {
            _lists = new List<GroceryList>
            {
                new GroceryList
                {
                    Id = 1,
                    UserId = 1,
                    Description ="test"
                },
                new GroceryList
                {
                    Id = 2,
                    UserId = 2,
                    Description ="test"
                },
                new GroceryList
                {
                    Id = 3,
                    UserId = 1,
                    Description ="test"
                },
            };
        }

        public Ingredient AddIngredientToList(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void ClearList(int listId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroceryList> GetFromUser(int userId)
        {
            return _lists.Where(l => l.UserId == userId).ToList();
        }

        public IEnumerable<Ingredient> GetIngredientsFromList(int listId)
        {
            throw new NotImplementedException();
        }

        public Ingredient RemoveIngredientFromList(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
