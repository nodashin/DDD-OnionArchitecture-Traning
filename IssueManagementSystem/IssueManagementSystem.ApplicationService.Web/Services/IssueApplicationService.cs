using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Issue;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Issue;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// 課題ApplicationService
    /// </summary>
    public class IssueApplicationService : IIssueApplicationService
    {
        /// <summary>
        /// 課題マネージャー
        /// </summary>
        private IIssueManager IssueManager { get; }

        /// <summary>
        /// 課題Repository
        /// </summary>
        private IIssueRepository IssueRepository { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueManager">課題マネージャー</param>
        /// <param name="issueRepository">課題Repository</param>
        public IssueApplicationService(IIssueManager issueManager, IIssueRepository issueRepository)
        {
            IssueManager = issueManager;
            IssueRepository = issueRepository;
        }

        /// <summary>
        /// 課題を検索する。
        /// </summary>
        /// <param name="searchConditionViewModel">課題一覧 - 検索条件ViewModel</param>
        /// <returns>検索条件に一致する課題一覧 - 課題ViewModel</returns>
        public List<IssueIndexIssueViewModel> Search(IssueIndexSearchConditionViewModel searchConditionViewModel)
        {
            var issues = IssueRepository.FindAll().OrderBy(i => i.IssueId);

            //TODO:ここで検索条件でフィルタリングをかける。

            var issueIndexIssueViewModels = new List<IssueIndexIssueViewModel>();
            foreach (var i in issues)
                issueIndexIssueViewModels.Add(IssueIndexIssueViewModel.CreateByIssue(i));
            return issueIndexIssueViewModels;
        }

        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="viewModel">課題作成ViewModel</param>
        public void Create(IssueCreateViewModel viewModel)
        {
            var issue = Issue.CreateByDetailInfo(viewModel.Title, viewModel.Content);
            IssueManager.Create(issue);
        }

        /// <summary>
        /// 課題編集ViewModelを取得する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns>課題編集ViewModel</returns>
        public IssueEditViewModel GetIssueEditViewModel(int issueId)
        {
            var issue = IssueRepository.FindById(issueId);
            return IssueEditViewModel.CreateByIssue(issue);
        }

        /// <summary>
        /// 課題を編集する。
        /// </summary>
        /// <param name="viewModel">課題編集ViewModel</param>
        public void Edit(IssueEditViewModel viewModel)
        {
            var issue = Issue.CreateByIssueInfo(viewModel.IssueId, viewModel.Title, viewModel.Content);
            IssueManager.Edit(issue);
        }
    }
}
