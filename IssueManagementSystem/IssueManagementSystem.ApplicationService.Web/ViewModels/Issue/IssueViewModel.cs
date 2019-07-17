using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Issue
{
    /// <summary>
    /// 課題ViewModel
    /// </summary>
    public class IssueViewModel
    {
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
