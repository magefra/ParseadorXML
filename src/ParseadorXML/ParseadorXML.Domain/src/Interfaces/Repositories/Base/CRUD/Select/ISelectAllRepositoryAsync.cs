﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Repositories.Base.CRUD
{
    public interface ISelectAllRepositoryAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> SelectAll();
    }
}
