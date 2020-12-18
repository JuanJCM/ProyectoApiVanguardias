using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using proyecto.Core.IRepositories;
using proyecto.Core.Entities;

namespace XUnitTests.Fake
{
    class FakeUserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;

        public FakeUserRepository()
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
        
        public IEnumerable<User> GetAll()
        {
            return _users.ToList();
        }

        public IEnumerable<GroceryList> GetAllListsFromUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reminder> GetAllRemindersFromUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
