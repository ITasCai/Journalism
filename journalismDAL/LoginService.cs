using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JournalismModel;
using JournalismCommon;

namespace journalismDAL
{
    /// <summary>
    ///用户登录数据访问类
    /// </summary>
    public class LoginService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public static int UserLogin(User user) {
            string sql = "SELECT COUNT(*) FROM dbo.tb_User WHERE Name=@Name AND PassWord=@PassWord";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@PassWord",user.PassWord),
            };

            return SqlHelper.ExecuteScalar<int>(CommandType.Text,sql,pa);
        }
    }
}
