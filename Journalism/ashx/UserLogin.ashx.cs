using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using journalismBLL;
using JournalismModel;
using System.Web.SessionState;

namespace Journalism.ashx
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            User user = new User();
            user.Name = context.Request["Name"];
            user.PassWord = context.Request["PassWord"];
            int num = LoginManager.UserLogin(user);
      
            context.Response.Write(num);
            if (num==1)
            {
                context.Session["LoginName"] = user.Name;
                context.Response.Redirect("Top.ashx");
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