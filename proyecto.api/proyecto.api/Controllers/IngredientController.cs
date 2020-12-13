using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proyecto.api.Models;
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
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        [Route("/ingredientId")]
        public ActionResult<IngredientDto> GetById(int id)
        {
            var ServiceResult = _ingredientService.GetByID(id);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new IngredientDto
            {
                Id = ServiceResult.Result.Id,
                Description = ServiceResult.Result.Description,
                ListId = ServiceResult.Result.ListId
            };

            return Ok(result);
        }

    }
}
