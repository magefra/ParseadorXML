using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Entities
{
    public abstract  class BaseEntity
    {

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }
    }
}
