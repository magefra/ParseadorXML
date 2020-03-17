using ParseadorXML.Domain.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.CFDI.Emisores
{
    public class EmisorId : Entity
    {
        public EmisorId(Guid id) : base(id) { }


        public static explicit operator EmisorId(Guid id) => id == Guid.Empty ? null : new EmisorId(id);
    }
}
