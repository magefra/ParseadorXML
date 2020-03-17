using Microsoft.EntityFrameworkCore;
using ParseadorXML.Domain.src.Entities.CFDI.Comprobante;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD;
using ParseadorXML.Infra.Data.EFRepositories.src.context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Repositories
{
    public class EmisorRepository : IEmisorRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly CFDIContext _CFDIContext;


        public EmisorRepository(CFDIContext CFDIContext)
        {
            _CFDIContext = CFDIContext;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task Insert(Emisor obj)
        {
            _CFDIContext.Emisor.Add(obj);
            await SaveChanges();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Emisor>> SelectAll()
        {
            return await _CFDIContext.Emisor.ToListAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChanges()
        {
            return await _CFDIContext.SaveChangesAsync();
        }


    }
}
