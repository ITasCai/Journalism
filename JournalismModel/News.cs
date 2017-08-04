using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalismModel
{

    /// <summary>
    /// 新闻类
    /// </summary>
    public class News
    {
        /// <summary>
        /// 新闻id
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title { set; get; }
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// 新闻分类
        /// </summary>
        public string Categories { set; get; }
        /// <summary>
        /// 新闻国界
        /// </summary>
        public string Type { set; get; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime IssueDate { set; get; }
    }
}
