using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTests.Fake
{
    class FakeIGroceryListRepository : IRepository<GroceryList>
    {
        private readonly IEnumerable<GroceryList> _lists;

        public FakeIGroceryListRepository()
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

        public GroceryList Add(GroceryList entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroceryList> Filter(Expression<Func<GroceryList, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroceryList> GetAll()
        {
            return _lists.ToList();
        }

        public GroceryList GetById(int id)
        {
            return _lists.Where(l => l.Id == id).FirstOrDefault();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public GroceryList Update(GroceryList entity)
        {
            throw new NotImplementedException();
        }
    }
}
