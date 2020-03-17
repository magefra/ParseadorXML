using ParseadorXML.Domain.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.CFDI.Receptores
{
    public class ReceptorId : Entity
    {
        public ReceptorId(Guid id) : base(id) { }

        public static explicit operator ReceptorId(Guid id) => id == Guid.Empty ? null : new ReceptorId(id);
    }
}
