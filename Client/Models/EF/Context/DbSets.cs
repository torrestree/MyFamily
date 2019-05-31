using Client.Models.EF.Platform;
using Client.Models.Indept.Platform;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.EF.Context
{
    /// <summary>
    /// DbSets
    /// </summary>
    public class DbSets : DbContext
    {
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="conn"></param>
        protected DbSets(SqlConn conn) : base(conn.ToString())
        { }

        /// <summary>
        /// 账号
        /// </summary>
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
