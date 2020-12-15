using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
