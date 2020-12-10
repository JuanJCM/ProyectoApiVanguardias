using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Repositories
{
    public interface IReminderRepository<T>
    {
        IEnumerable<T> GetFromUser(int userId);
    }
}
