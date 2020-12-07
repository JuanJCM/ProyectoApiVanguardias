using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.api.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTime DateDue { get; set; }
    }
}
