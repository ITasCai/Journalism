using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using journalismBLL;
using JournalismModel;

namespace Journalism.ashx
{
    /// <summary>
    /// GetNewsScience 的摘要说明
    /// </summary>
    public class GetNewsScience : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetTableRow());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public static string GetTableRow()
        {
            StringBuilder sbHtml = new StringBuilder();
            List<News> list = NewsManager.GetNewsScience();
            foreach (News news in list)
            {
                sbHtml.Append(" <tr>");
                sbHtml.Append(" <td >");
                sbHtml.Append(" <table border = '0' style = 'font-size: 9pt; width: 100%; height: 100%;' cellspacing = '0'  cellpadding = '0' >");
                sbHtml.Append("<tr>");
                sbHtml.Append("<td class='dtd2'>");
                sbHtml.Append("<a id = 'lbtnTitle' href='#'>" + news.Title + "</a>");
                sbHtml.Append("</td>");
                sbHtml.Append("<td style ='width:150px'>" + news.IssueDate + " </td>");
                sbHtml.Append("</tr>");
                sbHtml.Append("</table>");
                sbHtml.Append("</td>");
                sbHtml.Append("</tr>");


            }

            return sbHtml.ToString();
        }
    }
}