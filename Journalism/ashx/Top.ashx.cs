using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Journalism.ashx
{
    /// <summary>
    /// Top 的摘要说明
    /// </summary>
    public class Top : IHttpHandler,IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
       
            if (context.Session==null)
            {
                context.Response.Redirect("../login.html");
            }
            else
            {
                string username =(string) context.Session["LoginName"];
                context.Response.Write(username);
            }


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}