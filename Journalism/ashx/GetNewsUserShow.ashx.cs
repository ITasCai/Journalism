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
    /// GetNewsUserShow 的摘要说明
    /// </summary>
    public class GetNewsUserShow : IHttpHandler
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
            List<User> list = UserManager.GetNewsUserShow();

            sbHtml.Append("<tr>");
            sbHtml.Append("<td>操作</td>");
            sbHtml.Append("<td>id</td>");
            sbHtml.Append("<td>用户名</td>");
            sbHtml.Append("<td>密码</td>");
            sbHtml.Append("<td>时间</td>");
            sbHtml.Append("</tr>");

            foreach (User user in list)
            {
                sbHtml.Append("<tr>");
                sbHtml.Append("<td><input type='checkbox' name='check'></td>");
                sbHtml.Append("<td>"+user.ID+"</td>");
                sbHtml.Append("<td>" + user.Name + "</td>");
                sbHtml.Append("<td>" + user.PassWord + "</td>");
                sbHtml.Append("<td>" + user.Date + "</td>");
                sbHtml.Append("</tr>");
            }

            return sbHtml.ToString();
        }
    }
}