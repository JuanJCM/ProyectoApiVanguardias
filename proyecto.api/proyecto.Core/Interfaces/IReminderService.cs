using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Interfaces
{
    public interface IReminderService
    {
        ServiceResult<IEnumerable<Reminder>> GetAll();

        ServiceResult<Reminder> GetById(int id);

        ServiceResult<Reminder> Add(Reminder reminder);

        ServiceResult<Reminder> Update(Reminder reminder);

        ServiceResult<IEnumerable<Reminder>> GetAllFromUser(int userId);


    }
}
