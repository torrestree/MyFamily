using Client.Models.EF.Base.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.EF.Platform
{
    /// <summary>
    /// 账号
    /// </summary>
    public class Account : ListData
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LoginID { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
