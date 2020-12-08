using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public class Recipe : BaseEntity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
