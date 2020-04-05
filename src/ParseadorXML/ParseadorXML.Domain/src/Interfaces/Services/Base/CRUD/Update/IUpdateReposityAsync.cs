using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Update
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
