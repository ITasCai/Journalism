using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using journalismDAL;
using JournalismModel;

namespace journalismBLL
{
    public class NewsManager
    {

        /// <summary>
        /// 时事新闻查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsCategories()
        {
            return NewsService.GetNewsCategories();
        }

        /// <summary>
        /// 环球经济查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsRound()
        {
            return NewsService.GetNewsRound();
        }


        /// <summary>
        /// 科学技术查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsScience()
        {
            return NewsService.GetNewsScience();
        }


        /// <summary>
        /// 军事世界查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsMilitary()
        {
            return NewsService.GetNewsMilitary();
        }

        /// <summary>
        /// 社会百态查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsCommunity()
        {
            return NewsService.GetNewsCommunity();
        }

        /// <summary>
        /// 世界体育查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsSports()
        {
            return NewsService.GetNewsSports();
        }


        /// <summary>
        /// 娱乐综艺查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsRecreation()
        {
            return NewsService.GetNewsRecreation();
        }

        /// <summary>
        /// 生活理财查询
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsManage()
        {
            return NewsService.GetNewsManage();
        }


        /// <summary>
        /// 根据关键字查询新闻内容
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsType(News n)
        {
            return NewsService.GetNewsType(n);
        }


        /// <summary>
        /// 查询标题信息的具体内容
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<News> GetNewsContent(News n)
        {
            return NewsService.GetNewsContent(n);
        }
        /// <summary>
        /// 查询所有新闻内容
        /// </summary>
        /// <returns></returns>
        public static List<News> GetNewsShow()
        {
            return NewsService.GetNewsShow();
        }

        }
}
