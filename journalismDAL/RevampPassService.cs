using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalismModel;
using JournalismCommon;
using System.Data.SqlClient;
using System.Data;

namespace journalismDAL
{
    /// <summary>
    /// 管理员密码修改数据访问类
    /// </summary>
   public class RevampPassService
    {

        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int RevampPass(User user) {
            string sql = "UPDATE dbo.tb_User SET PassWord=@PassWord WHERE Name=@Name";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@PassWord",user.PassWord),
                new SqlParameter("@Name",user.Name),

            };

            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql,pa);
        }


    }
}
