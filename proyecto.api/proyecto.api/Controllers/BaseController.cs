using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto.Core;
using proyecto.Core.Enums;

namespace proyecto.api.Controllers
{
    public class BaseController : ControllerBase
    {
         public ActionResult GetResult<T>(ServiceResult<T> serviceResult)
        {
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok();
        }
    }
}
