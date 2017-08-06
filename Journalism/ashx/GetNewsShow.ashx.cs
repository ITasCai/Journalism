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
    /// GetNewsShow 的摘要说明
    /// </summary>
    public class GetNewsShow : IHttpHandler
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
            List<News> list = NewsManager.GetNewsShow();
            sbHtml.Append("<TR>");
            sbHtml.Append("<TH class=gridViewHeader style = 'WIDTH: 50px' scope=col>&nbsp;</TH>");
            sbHtml.Append("<TH class=gridViewHeader scope = col >Id</ TH >");
            sbHtml.Append("<TH class=gridViewHeader scope = col > 新闻标题 </ TH >");
            sbHtml.Append("<TH class=gridViewHeader scope = col > 新闻类别 </ TH >");
            sbHtml.Append("<TH class=gridViewHeader scope = col > 发布时间 </ TH >");
            sbHtml.Append("<TH class=gridviewHeader scope = col > 详情 </ TH >");
            sbHtml.Append("<TH class=gridviewHeader scope = col > 更新 </ TH >");
            sbHtml.Append("<TH class=gridviewHeader scope = col > 删除 </ TH >");
            sbHtml.Append("</TR >");




            foreach (News news in list)
            {

                sbHtml.Append("<TR >");
                sbHtml.Append("<TD class=gridViewItem style ='WIDTH: 50px'><IMGsrc='EmployeeMgr.files/bg_users.gif' ></TD>");
                sbHtml.Append("<TD class=gridViewItem>" + news.ID + "</TD>");
                sbHtml.Append("<TD class=gridViewItem>" + news.Title + "</TD>");
                sbHtml.Append("<TD class=gridViewItem>" + news.Categories + "</TD>");
                sbHtml.Append("<TD class=gridViewItem>" + news.IssueDate + "</TD>");
                sbHtml.Append("<TD class=gridViewItem><A class=cmdField href = '#' >  查看详情  </ A ></ TD > ");
                sbHtml.Append("<TD class=gridViewItem><A class=cmdField href = '#'>编辑</ A ></ TD > ");
                sbHtml.Append("<TD class=gridViewItem><A class=cmdField id = ctl00_ContentPlaceHolder2_GridView1_ctl02_LinkButton1 'href = '#'>删除</ A ></ TD > ");
                sbHtml.Append("</TR>");


            }

            return sbHtml.ToString();
        }
    }
}