using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Repositories
{
    public class ComprobanteRepository : IComprobanteRepository
    {
        public async Task  Insert(Comprobante obj)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comprobante> Select(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comprobante>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Comprobante obj)
        {
            throw new NotImplementedException();
        }
    }
}
