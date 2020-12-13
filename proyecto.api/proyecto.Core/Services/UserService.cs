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
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userIRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IRepository<User> userIRepository, IUserRepository userRepository)
        {
            _userIRepository = userIRepository;
            _userRepository = userRepository;
        }

        public ServiceResult<IEnumerable<GroceryList>> GetAllListsFromUser(int userId)
        {
            return ServiceResult<IEnumerable<GroceryList>>.SuccessResult(_userRepository.GetAllListsFromUser(userId));
        }

        public ServiceResult<IEnumerable<Reminder>> GetAllRemindersFromUser(int userId)
        {
            return ServiceResult<IEnumerable<Reminder>>.SuccessResult(_userRepository.GetAllRemindersFromUser(userId));
        }

        ServiceResult<User> IUserService.Add(User user)
        {
            return ServiceResult<User>.SuccessResult(_userIRepository.Add(user));
        }

        ServiceResult<IEnumerable<User>> IUserService.GetAll()
        {
            return ServiceResult<IEnumerable<User>>.SuccessResult(_userIRepository.GetAll());
        }

        ServiceResult<User> IUserService.GetById(int id)
        {
            return ServiceResult<User>.SuccessResult(_userIRepository.GetById(id));
        }
    }
}
