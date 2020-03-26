using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Infra.Data.EFRepositories.src.Context
{
    public class DbContextUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDb"></typeparam>
        /// <param name="connStr"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        public static TDb Create<TDb>(string connStr, Func<DbContextOptions<TDb>, TDb> creator) where TDb : DbContext
        {
            var options = new DbContextOptionsBuilder<TDb>()
                .UseMySql(connStr)
                .Options;

            var dbContext = creator(options);
            return dbContext;
        }
    }
}
