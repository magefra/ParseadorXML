using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD
{
    public interface IRemoveRepositoryAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> Remove(int id);
    }
}
