using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public class GroceryList : BaseEntity
    {

        public GroceryList()
        {
            Items = new List<Ingredient>();
        }

        public int UserId { get; set; }
        public string Description { get; set; }
        public  ICollection<Ingredient> Items { get; set; }
    }
}
