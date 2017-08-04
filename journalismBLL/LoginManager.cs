using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using journalismDAL;
using JournalismModel;

namespace journalismBLL
{
   public class LoginManager
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public static int UserLogin(User user)
        {
            return LoginService.UserLogin(user);
        }

        }
}
