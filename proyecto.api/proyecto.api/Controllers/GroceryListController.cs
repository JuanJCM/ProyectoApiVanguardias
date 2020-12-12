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
    public class GroceryListController : ControllerBase
    {

        private readonly IGroceryListService _groceryListService;

        public GroceryListController(IGroceryListService groceryListService)
        {
            _groceryListService = groceryListService;
        }

        [HttpGet]
        public ActionResult<GroceryListDto> GetAll()
        {
            var result = _groceryListService.GetAll();
            if (result.ResponseCode != ResponseCode.Success)
                return BadRequest(result.Error);

            return Ok(result.Result.Select(g => new GroceryListDto
            {

                Id = g.Id,
                Description = g.Description,
                UserId = g.UserId,
                Ingredients = g.Items.Select(i => new IngredientDto
                {
                    Id = i.Id,
                    Description = i.Description,
                    ListId = i.ListId
                })
            }));
        }

        [HttpGet]
        [Route("{groceryListId}")]
        public ActionResult<GroceryListDto> GetById(int groceryListId)
        {
            var ServiceResult = _groceryListService.GetByID(groceryListId);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new GroceryListDto
            {
                Id = ServiceResult.Result.Id,
                Description = ServiceResult.Result.Description,
                UserId = ServiceResult.Result.UserId,
                Ingredients = ServiceResult.Result.Items.Select(i => new IngredientDto
                {
                    Id = i.Id,
                    Description = i.Description,
                    ListId = i.ListId
                })
            };
            return Ok(result);
        }

        [HttpGet]
        [Route("{/Users/{userId}")]
        public ActionResult<IEnumerable<GroceryListDto>> GetAllFromUser(int userId)
        {
            var ServiceResult = _groceryListService.GetAllFromUser(userId);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            return Ok(ServiceResult.Result.Select(g => new GroceryListDto { 
                Id = g.Id,
                Description = g.Description,
                UserId = g.UserId,
                Ingredients = g.Items.Select(i => new IngredientDto
                {
                    Id = i.Id,
                    Description = i.Description,
                    ListId = i.ListId
                })
            
            }));
        }

        [HttpPost]
        public ActionResult<GroceryListDto> NewList([FromBody]GroceryList groceryList)
        {
            var ServiceResult = _groceryListService.NewList(groceryList);
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            var result = new GroceryListDto
            {
                Id = ServiceResult.Result.Id,
                Description = ServiceResult.Result.Description,
                UserId = ServiceResult.Result.UserId,
                Ingredients = ServiceResult.Result.Items.Select(i => new IngredientDto
                {
                    Id = i.Id,
                    Description = i.Description,
                    ListId = i.ListId
                })
            };

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<IngredientDto> AddIngredientToList([FromBody] Ingredient ingredient)
        {
            var ServiceResult = _groceryListService.AddIngredientToList(ingredient);
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

        [HttpPatch]
        public ActionResult<Ingredient> RemoveIngredientFromList(Ingredient ingredient)
        {
            var ServiceResult = _groceryListService.RemoveIngredientFromList(ingredient);
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
