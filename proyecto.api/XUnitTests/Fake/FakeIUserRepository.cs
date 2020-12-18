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
    public class FakeIUserRepository : IRepository<User>
    {
        private readonly IEnumerable<User> _users;
        public FakeIUserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "hola",
                    Password = "adios"
                },
                new User
                {
                    Id = 2,
                    Username = "kayy",
                    Password = "adios"
                },
                new User
                {
                    Id = 3,
                    Username = "bye",
                    Password = "adios"
                }
            };
        }

        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Filter(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _users.Where(u => u.Id == id).FirstOrDefault();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _users.ToList();
        }
    }
}
