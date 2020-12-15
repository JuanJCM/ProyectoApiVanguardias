using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Core.Entities;
using proyecto.Core.Interfaces;
using proyecto.Core.IRepositories;

namespace proyecto.Core.Services
{
    public class ReminderService : IReminderService
    {
        private readonly IRepository<Reminder> _reminderIRepository;
        private readonly IReminderRepository _reminderRepository;

        public ReminderService(IRepository<Reminder> reminderIRepository, IReminderRepository reminderRepository)
        {
            _reminderIRepository = reminderIRepository;
            _reminderRepository = reminderRepository;
        }

        public ServiceResult<IEnumerable<Reminder>> GetAllRemindersFromUser(int userId)
        {
            return ServiceResult<IEnumerable<Reminder>>.SuccessResult(_reminderRepository.GetFromUser(userId));
        }

        ServiceResult<Reminder> IReminderService.Add(Reminder reminder)
        {
            return ServiceResult<Reminder>.SuccessResult(_reminderIRepository.Add(reminder));
        }

        ServiceResult<IEnumerable<Reminder>> IReminderService.GetAll()
        {
            return ServiceResult<IEnumerable<Reminder>>.SuccessResult(_reminderIRepository.GetAll());
        }

        ServiceResult<Reminder> IReminderService.GetById(int id)
        {
            return ServiceResult<Reminder>.SuccessResult(_reminderIRepository.GetById(id));
        }

    }
}
