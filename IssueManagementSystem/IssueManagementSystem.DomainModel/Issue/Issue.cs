using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Issue
{
    /// <summary>
    /// 課題
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// 課題ID
        /// </summary>
        public int IssueId { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
