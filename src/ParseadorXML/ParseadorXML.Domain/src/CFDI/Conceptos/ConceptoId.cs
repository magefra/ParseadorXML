using ParseadorXML.Domain.src.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.CFDI.Conceptos
{
    public class ConceptoId : Entity
    {

        public ConceptoId(Guid id) : base(id) { }


        public static explicit operator ConceptoId(Guid id) => id == Guid.Empty ? null : new ConceptoId(id);

    }
}
