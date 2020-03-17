using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD
{
    public interface IUpdateReposityAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        Task<T> Update(T obj);
    }
}
