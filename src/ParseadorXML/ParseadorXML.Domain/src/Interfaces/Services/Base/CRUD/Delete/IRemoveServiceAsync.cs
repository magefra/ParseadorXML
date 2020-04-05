using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Delete
{
    public interface IRemoveServiceAsync
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> Remove(int id);
    }
}
