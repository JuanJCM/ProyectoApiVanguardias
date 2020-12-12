using Microsoft.AspNetCore.Mvc;
using proyecto.api.Models;
using proyecto.Core.Entities;
using proyecto.Core.Enums;
using proyecto.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.api.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<UserDto> GetAll()
        {
            var result = _userService.GetAll();
            if (result.ResponseCode != ResponseCode.Success)
                return BadRequest(result.Error);

            return Ok(result.Result.Select(u => new UserDto
            {
                Id = u.Id,
                Name = u.Name,
                Username = u.Username,
                Password = u.Password
            }));
        }

        [HttpGet]
        [Route("{userId}")]
        public ActionResult<UserDto> GetById(int groceryListId)
        {
            var ServiceResult = _userService.GetById(groceryListId);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new UserDto
            {
                Id = ServiceResult.Result.Id,
                Name = ServiceResult.Result.Name,
                Username = ServiceResult.Result.Username,
                Password = ServiceResult.Result.Password
            };
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<GroceryListDto> NewList([FromBody] User user)
        {
            var ServiceResult = _userService.Add(user);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new UserDto
            {
                Id = ServiceResult.Result.Id,
                Name = ServiceResult.Result.Name,
                Username = ServiceResult.Result.Username,
                Password = ServiceResult.Result.Password
            };

            return Ok(result);
        }
    }
}
