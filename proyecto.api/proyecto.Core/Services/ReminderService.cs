using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Core.Entities;
using proyecto.Core.Interfaces;
using proyecto.Core.Repositories;

namespace proyecto.Core.Services
{
    public class ReminderService : IReminderService
    {
        private readonly IRepository<Reminder> _reminderRepository;

        public ReminderService(IRepository<Reminder> reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }


        ServiceResult<Reminder> IReminderService.Add(Reminder reminder)
        {
            return ServiceResult<Reminder>.SuccessResult(_reminderRepository.Add(reminder));
        }

        ServiceResult<IEnumerable<Reminder>> IReminderService.GetAll()
        {
            return ServiceResult<IEnumerable<Reminder>>.SuccessResult(_reminderRepository.GetAll());
        }

        ServiceResult<Reminder> IReminderService.GetById(int id)
        {
            return ServiceResult<Reminder>.SuccessResult(_reminderRepository.GetById(id));
        }

        ServiceResult<Reminder> IReminderService.Update(Reminder reminder)
        {
            return ServiceResult<Reminder>.SuccessResult(_reminderRepository.Update(reminder));
        }
    }
}
