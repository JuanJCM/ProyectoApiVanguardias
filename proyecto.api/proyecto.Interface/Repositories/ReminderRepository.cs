using proyecto.Core.Entities;
using proyecto.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Infrastructure.Repositories
{
    class ReminderRepository<T> : IReminderRepository<T>
    {
        protected readonly ProyectoDbContext _context;

        public ReminderRepository(ProyectoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Reminder> GetFromUser(int userId)
        {
            return _context.Reminder.Where(r => r.UserId == userId);
        }
    }
}
