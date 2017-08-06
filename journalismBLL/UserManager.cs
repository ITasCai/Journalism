using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using journalismDAL;
using JournalismModel;

namespace journalismBLL
{
    /// <summary>
    /// 对用户进行操作业务逻辑类
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int UserAdd(User user)
        {
            return UserService.UserAdd(user);
        }
        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <returns></returns>
        public static List<User> GetNewsUserShow()
        {
            return UserService.GetNewsUserShow();
        }

        }
}
