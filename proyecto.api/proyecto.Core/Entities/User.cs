using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
