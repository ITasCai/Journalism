using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalismModel
{
    /// <summary>
    /// 登录类
    /// </summary>
   public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { set; get; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public string Date { set; get; }

    }
}
