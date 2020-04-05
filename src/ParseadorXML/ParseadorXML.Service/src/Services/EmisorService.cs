using ParseadorXML.Domain.src.Interfaces.Services.Base;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Service.src.Services
{
    public class EmisorService : IEmisorService
    {

        public EmisorService()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Task Insert(EmisorDTO obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<EmisorDTO>> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
