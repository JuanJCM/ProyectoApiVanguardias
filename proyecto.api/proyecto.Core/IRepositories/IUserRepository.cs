using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.IRepositories
{
    public interface IUserRepository<T>
    {
        IEnumerable<GroceryList> GetAllListsFromUser(int userId);

        IEnumerable<Reminder> GetAllRemindersFromUser(int userId);
    }
}
