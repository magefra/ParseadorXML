using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Insert
{
    public interface IInsertServceAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        Task Insert(T obj);
    }
}
