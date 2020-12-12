using proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Core.Interfaces
{
    public interface IUserService
    {
        ServiceResult<IEnumerable<User>> GetAll();

        ServiceResult<User> GetById(int id);

        ServiceResult<User> Add(User user);

    }
}
