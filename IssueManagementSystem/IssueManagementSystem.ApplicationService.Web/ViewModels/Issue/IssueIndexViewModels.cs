﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Issue
{
    #region 課題一覧ViewModel
    /// <summary>
    /// 課題一覧ViewModel
    /// </summary>
    public class IssueIndexViewModel
    {
        #region プロパティ
        /// <summary>
        /// 検索条件
        /// </summary>
        public IssueIndexSearchConditionViewModel SearchCondition { get; set; }

        /// <summary>
        /// 課題群
        /// </summary>
        public List<IssueIndexIssueViewModel> Issues { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="searchConditionViewModel">検索条件ViewModel</param>
        /// <param name="issueViewModels">課題ViewMode群</param>
        private IssueIndexViewModel(IssueIndexSearchConditionViewModel searchConditionViewModel, List<IssueIndexIssueViewModel> issueViewModels)
        {
            SearchCondition = searchConditionViewModel;
            Issues = issueViewModels;
        }

        /// <summary>
        /// 子ViewModelを元に課題一覧ViewModelを生成する。
        /// </summary>
        /// <param name="searchConditionViewModel">検索条件ViewModel</param>
        /// <param name="issueViewModels">課題ViewModel群</param>
        /// <returns></returns>
        public static IssueIndexViewModel CreateByChildViewModels(IssueIndexSearchConditionViewModel searchConditionViewModel, 
                                                                  List<IssueIndexIssueViewModel> issueViewModels)
            => new IssueIndexViewModel(searchConditionViewModel, issueViewModels);
        #endregion
    }
    #endregion

    #region 課題一覧 - 検索条件ViewModel
    /// <summary>
    /// 課題一覧 - 検索条件ViewModel
    /// </summary>
    public class IssueIndexSearchConditionViewModel
    {
        //TODO:後で何か入れよう
    }
    #endregion

    #region 課題一覧 - 課題ViewModel
    /// <summary>
    /// 課題一覧 - 課題ViewModel
    /// </summary>
    public class IssueIndexIssueViewModel
    {
        #region プロパティ
        /// <summary>
        /// 課題ID
        /// </summary>
        [DisplayName("課題ID")]
        public int IssueId { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [DisplayName("タイトル")]
        public string Title { get; set; }

        /// <summary>
        /// 課題
        /// </summary>
        private DomainModel.Issue.Issue Issue { get; }
        #endregion

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issue">課題</param>
        private IssueIndexIssueViewModel(DomainModel.Issue.Issue issue)
        {
            Issue = issue;
        }

        /// <summary>
        /// 課題一覧 - 課題ViewModelを生成する。
        /// </summary>
        /// <param name="issue">課題</param>
        /// <returns></returns>
        public static IssueIndexIssueViewModel CreateByIssue(DomainModel.Issue.Issue issue)
            => new IssueIndexIssueViewModel(issue);
        #endregion
    }
    #endregion
}
