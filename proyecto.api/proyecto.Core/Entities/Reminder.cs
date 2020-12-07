using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    class Reminder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTime DateDue { get; set; }
    }
}
