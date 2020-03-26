using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorXML.Domain.src.Interfaces.Repositories
{
    public interface IRepositoryAsync<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        Task Insert(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        Task Update(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task Remove(int id);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Select(string id);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> SelectAll();
    }
}
