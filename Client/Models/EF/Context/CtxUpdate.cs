namespace Client.Models.EF.Context
{
    using Client.Migrations;
    using Client.Models.Statics.Platform;
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// CtxUpdate
    /// </summary>
    public class CtxUpdate : DbSets
    {
        /// <summary>
        /// ππ‘Ï
        /// </summary>
        public CtxUpdate() : base(LoginInfo.SqlConn)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CtxUpdate, Configuration>());
        }
    }
}