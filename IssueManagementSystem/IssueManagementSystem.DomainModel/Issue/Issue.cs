using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string IssueId { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
