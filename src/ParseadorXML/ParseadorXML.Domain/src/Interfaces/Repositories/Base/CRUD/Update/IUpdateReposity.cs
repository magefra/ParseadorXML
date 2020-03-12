using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD
{
    public interface IUpdateReposity<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);
    }
}
