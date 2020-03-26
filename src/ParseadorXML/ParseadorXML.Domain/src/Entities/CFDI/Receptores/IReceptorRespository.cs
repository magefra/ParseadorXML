using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Interfaces.Repositories
{
    public interface  IReceptorRespository : IInsertRepositoryAsync<Receptor>,
                                             ISelectAllRepositoryAsync<Receptor>
    {
    }
}
