using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.api.Models
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string Description { get; set; }
    }
}
