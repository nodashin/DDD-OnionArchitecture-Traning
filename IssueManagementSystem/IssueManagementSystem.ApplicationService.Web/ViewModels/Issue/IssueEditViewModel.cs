﻿using System;
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
        public int IsseuId { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="isseuId">課題ID</param>
        /// <param name="title">タイトル</param>
        /// <param name="content">内容</param>
        private IssueEditViewModel(int isseuId, string title, string content)
        {
            IsseuId = isseuId;
            Title = title;
            Content = content;
        }

        /// <summary>
        /// 課題から課題編集ViewModelを作成する。
        /// </summary>
        /// <param name="issue">課題</param>
        /// <returns>課題編集ViewModel</returns>
        public static IssueEditViewModel CreateByIssue(DomainModel.Issue.Issue issue)
            => new IssueEditViewModel(issue.IssueId, issue.Title, issue.Content);
    }
}
