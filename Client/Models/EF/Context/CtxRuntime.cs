namespace Client.Models.EF.Context
{
    using Client.Models.Statics.Platform;
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// CtxRuntime
    /// </summary>
    public class CtxRuntime : DbSets
    {
        /// <summary>
        /// ππ‘Ï
        /// </summary>
        public CtxRuntime() : base(LoginInfo.SqlConn)
        { }
    }
}