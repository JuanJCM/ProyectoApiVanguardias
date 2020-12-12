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
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        ServiceResult<User> IUserService.Add(User user)
        {
            return ServiceResult<User>.SuccessResult(_userRepository.Add(user));
        }

        ServiceResult<IEnumerable<User>> IUserService.GetAll()
        {
            return ServiceResult<IEnumerable<User>>.SuccessResult( _userRepository.GetAll());
        }

        ServiceResult<User> IUserService.GetById(int id)
        {
            return ServiceResult<User>.SuccessResult(_userRepository.GetById(id));
        }
    }
}
