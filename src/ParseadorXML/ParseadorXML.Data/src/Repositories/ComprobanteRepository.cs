using Microsoft.EntityFrameworkCore;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Infra.Data.EFRepositories.src.context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Repositories
{
    public class ComprobanteRepository : IComprobanteRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly CFDIContext _cFDIContext;


        public ComprobanteRepository(CFDIContext cFDIContext)
        {
            _cFDIContext = cFDIContext;
        }

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public  async Task<IEnumerable<Comprobante>> SelectAll()
        {
            var result = await _cFDIContext.Comprobante.ToListAsync();

            return result;
        }




        public async Task Update(Comprobante obj)
        {
            throw new NotImplementedException();
        }
    }
}
