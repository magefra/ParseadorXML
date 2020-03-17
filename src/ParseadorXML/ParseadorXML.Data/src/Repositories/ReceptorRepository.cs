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
    public class ReceptorRepository : IReceptorRespository
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly CFDIContext _CFDIContext;



        public ReceptorRepository(CFDIContext CFDIContext)
        {
            _CFDIContext = CFDIContext;
        }


        public async Task Insert(Receptor obj)
        {
            _CFDIContext.Receptor.Add(obj);
            await SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Receptor>> SelectAll()
        {
            return await _CFDIContext.Receptor.ToListAsync();
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
