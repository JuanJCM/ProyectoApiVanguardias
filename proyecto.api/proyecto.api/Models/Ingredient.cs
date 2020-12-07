using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.api.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string description { get; set; }
    }
}
