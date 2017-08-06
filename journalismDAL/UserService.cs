using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JournalismCommon;
using JournalismModel;

namespace journalismDAL
{
    /// <summary>
    /// 对用户进行操作数据访问类
    /// </summary>
  public  class UserService
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int UserAdd(User user) {
            string sql = @"INSERT INTO dbo.tb_User
                            ( Name, PassWord, Date )
                    VALUES  (@Name,@PassWord,@Date )";

            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@PassWord",user.PassWord),
                new SqlParameter("@Date",user.Date),
            };

            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,pa);
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <returns></returns>
        public static List<User> GetNewsUserShow()
        {
            List<User> list = new List<User>();
            string sql = "SELECT*FROM dbo.tb_User";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                User user = new User();
                user.ID = Convert.ToInt32(dr["ID"]);
                user.Name =dr["Name"].ToString();
                user.PassWord = dr["PassWord"].ToString();
                user.Date = dr["Date"].ToString();
               
                list.Add(user);
            }
            return list;
        }

    }
}
