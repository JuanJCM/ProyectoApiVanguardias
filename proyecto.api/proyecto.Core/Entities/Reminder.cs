using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public class Reminder : BaseEntity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTime DateDue { get; set; }
    }
}
