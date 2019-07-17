using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Issue
{
    /// <summary>
    /// 課題編集ViewModel
    /// </summary>
    public class IssueEditViewModel : IssueViewModel
    {
        /// <summary>
        /// 課題ID
        /// </summary>
        [DisplayName("課題ID")]
        public int IssueId { get; set; }

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ(View用)
        /// </summary>
        public IssueEditViewModel() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <param name="title">タイトル</param>
        /// <param name="content">内容</param>
        private IssueEditViewModel(int issueId, string title, string content)
        {
            IssueId = issueId;
            Title = title;
            Content = content;
        }
        #endregion

        /// <summary>
        /// 課題から課題編集ViewModelを作成する。
        /// </summary>
        /// <param name="issue">課題</param>
        /// <returns>課題編集ViewModel</returns>
        public static IssueEditViewModel CreateByIssue(DomainModel.Issue.Issue issue)
            => new IssueEditViewModel(issue.IssueId, issue.Title, issue.Content);
        #endregion
    }
}
