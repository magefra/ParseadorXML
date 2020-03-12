using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Repositories
{
    public class ReceptorRepository : IReceptorRespository
    {
        public void Insert(Receptor obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Receptor>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
