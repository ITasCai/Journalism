using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using journalismDAL;
using JournalismModel;
using System.Data.SqlClient;
using System.Data;

namespace journalismBLL
{
    /// <summary>
    /// 管理员密码修改业务逻辑类
    /// </summary>
    public class RevampPassManager
    {
        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int RevampPass(User user)
        {
            return RevampPassService.RevampPass(user);

        }
        }
}
