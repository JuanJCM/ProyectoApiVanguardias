using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.api.Models
{
    public class GroceryListDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public IEnumerable<IngredientDto> Ingredients { get; set; }
    }
}
