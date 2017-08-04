using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using journalismBLL;
using JournalismModel;
using System.Text;

namespace Journalism.ashx
{
    /// <summary>
    /// GetNewsContent 的摘要说明
    /// </summary>
    public class GetNewsContent : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            News n = new News();
            n.Content = context.Request["Content"];
            context.Response.Write(GetTableRow(n));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        public static string GetTableRow(News n)
        {

            StringBuilder sbHtml = new StringBuilder();
            List<News> list = NewsManager.GetNewsContent(n);
            foreach (News news in list)
            {

                sbHtml.Append("<p>"+news.Content+"</p>");

            }

            return sbHtml.ToString();
        }
    }
}