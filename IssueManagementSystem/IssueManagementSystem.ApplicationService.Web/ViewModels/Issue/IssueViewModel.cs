using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.Attributes;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Issue
{
    /// <summary>
    /// 課題ViewModel
    /// </summary>
    public class IssueViewModel
    {
        #region プロパティ
        /// <summary>
        /// タイトル
        /// </summary>
        [DisplayName("タイトル")]
        [MyRequired]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("内容")]
        [MyRequired]
        public string Content { get; set; }
        #endregion
    }
}
