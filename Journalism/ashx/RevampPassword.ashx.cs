﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using journalismBLL;
using JournalismModel;

namespace Journalism.ashx
{
    /// <summary>
    /// RevampPassword 的摘要说明
    /// </summary>
    public class RevampPassword : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            User user = new User();
            user.Name= context.Request["Name"];
            user.PassWord = context.Request["PassWord"];
            context.Response.Write(RevampPassManager.RevampPass(user));
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