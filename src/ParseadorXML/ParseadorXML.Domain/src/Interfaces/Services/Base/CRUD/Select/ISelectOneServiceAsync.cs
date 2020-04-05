using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Select
{
    public interface ISelectOneServiceAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> SelectOne(string id);
    }
}
