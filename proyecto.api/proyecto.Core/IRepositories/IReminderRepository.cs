using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.IRepositories
{
    public interface IReminderRepository
    {
        IEnumerable<Reminder> GetFromUser(int userId);
    }
}
