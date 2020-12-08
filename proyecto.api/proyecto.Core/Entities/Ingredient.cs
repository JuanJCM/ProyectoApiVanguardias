using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public class Ingredient : BaseEntity
    {
        public int ListId { get; set; }

        public GroceryList GroceryList { get; set; }

        public string description { get; set; }
    }
}
