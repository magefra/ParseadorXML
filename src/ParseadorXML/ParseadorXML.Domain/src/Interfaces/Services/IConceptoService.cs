using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Insert;
using ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Select;
using ParseadorXML.Domain.src.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Interfaces.Services
{
    public interface IConceptoService : IInsertServceAsync<ConceptoDTO>,
                                        ISelectAllServiceAsync<ConceptoDTO>
    {
    }
}
