using ParseadorXML.Domain.src.Interfaces.Services;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class ReceptorService : IReceptorService
    {

        public ReceptorService()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Task Insert(ReceptorDTo obj)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ReceptorDTo>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
