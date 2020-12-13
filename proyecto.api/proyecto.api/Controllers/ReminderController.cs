using Microsoft.AspNetCore.Http;
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
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderController : ControllerBase
    {
        private readonly IReminderService _reminderListService;

        public ReminderController(IReminderService reminderListService)
        {
            _reminderListService = reminderListService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReminderDto>> GetAll()
        {
            var ServiceResult = _reminderListService.GetAll();
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            return Ok(ServiceResult.Result.Select(r => new ReminderDto
            {
                Id = r.Id,
                Description = r.Description,
                Message = r.Message,
                DateDue = r.DateDue,
                UserId = r.UserId
            }));
        }


        [HttpGet]
        [Route("{userId}")]
        public ActionResult<ReminderDto> GetAllRemindersFromUser(int id)
        {
            var ServiceResult = _reminderListService.GetAllRemindersFromUser(id);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);


            return Ok(ServiceResult.Result.Select(r => new ReminderDto
            {
                Id = r.Id,
                Description = r.Description,
                Message = r.Message,
                DateDue = r.DateDue,
                UserId = r.UserId
            }));
        }

        [HttpGet]
        [Route("{reminderId}")]
        public ActionResult<ReminderDto> GetById(int id)
        {
            var ServiceResult = _reminderListService.GetById(id);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new ReminderDto
            {
                Id = ServiceResult.Result.Id,
                Description = ServiceResult.Result.Description,
                Message = ServiceResult.Result.Message,
                DateDue = ServiceResult.Result.DateDue,
                UserId = ServiceResult.Result.UserId
            };

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<ReminderDto> Add(Reminder reminder)
        {
            var ServiceResult = _reminderListService.Add(reminder);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new ReminderDto
            {
                Id = ServiceResult.Result.Id,
                Description = ServiceResult.Result.Description,
                Message = ServiceResult.Result.Message,
                DateDue = ServiceResult.Result.DateDue,
                UserId = ServiceResult.Result.UserId
            };

            return Ok(result);
        }
    }
}
