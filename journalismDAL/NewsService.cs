using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalismModel;
using JournalismCommon;
using System.Data;
using System.Data.SqlClient;

namespace journalismDAL
{
    /// <summary>
    /// 新闻页面数据访问类（实现数据的增删改查）
    /// </summary>
    public class NewsService
    {

        /// <summary>
        /// 时事新闻查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsCategories() {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='时事新闻' ORDER BY IssueDate DESC";

          SqlDataReader dr=  SqlHelper.ExecuteReader(CommandType.Text,sql,null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate= Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 环球经济查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsRound()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='环球经济' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 科学技术查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsScience()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='科学技术' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }
        /// <summary>
        /// 军事世界查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsMilitary()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='军事世界' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }
        /// <summary>
        /// 社会百态查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsCommunity()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='社会百态' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 世界体育查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsSports()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='世界体育' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 娱乐综艺查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsRecreation()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='娱乐综艺' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 生活理财查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsManage()
        {
            List<News> list = new List<News>();
            string sql = "SELECT TOP 4* FROM dbo.tb_News WHERE Categories='生活理财' ORDER BY IssueDate DESC";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }


        /// <summary>
        /// 根据关键字查询新闻内容
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsType(News n)
        {
            List<News> list = new List<News>();
            string sql = string.Format("select * from tb_News where Categories like '%{0}%' and Title like '%{1}%'", n.Categories, n.Title);

          
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }

        /// <summary>
        /// 查询标题信息的具体内容
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<News> GetNewsContent(News n) {
            List<News> list = new List<News>();
            string sql = "SELECT*FROM dbo.tb_News WHERE Title=@Title";

            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@Title",n.Content)
            };

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, pa);

            while (dr.Read())
            {
                News news = new News();
                news.ID = Convert.ToInt32(dr["ID"]);
                news.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                news.Title = dr["Title"].ToString();
                news.Content = dr["Content"].ToString();
                news.Type = dr["Type"].ToString();
                news.Categories = dr["Categories"].ToString();
                list.Add(news);
            }
            return list;
        }


    }
}
