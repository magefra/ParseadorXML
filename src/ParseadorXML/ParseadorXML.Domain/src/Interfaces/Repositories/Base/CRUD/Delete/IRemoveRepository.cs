using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD
{
    public interface IRemoveRepository<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Remove(int id);
    }
}
