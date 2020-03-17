using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Repositories
{
    public class ConceptoRepository : IConceptoRepository
    {
        public void Insert(Concepto obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Concepto>> SelectAll()
        {
            throw new NotImplementedException();
        }

        Task IInsertRepositoryAsync<Concepto>.Insert(Concepto obj)
        {
            throw new NotImplementedException();
        }
    }
}
