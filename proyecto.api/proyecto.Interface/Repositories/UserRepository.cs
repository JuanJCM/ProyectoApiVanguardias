using Microsoft.EntityFrameworkCore;
using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Infrastructure.Repositories
{
    class UserRepository<T> : IUserRepository<T>
    {
        protected readonly ProyectoDbContext _context;

        public UserRepository(ProyectoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GroceryList> GetAllListsFromUser(int userId)
        {
            return _context.List.Where(x => x.Id == userId)
                .Include(x => x.Items)
                .ToList();
        }

        public IEnumerable<Reminder> GetAllRemindersFromUser(int userId)
        {
            return _context.Reminder.Where(l => l.UserId == userId);
        }
    }
}
