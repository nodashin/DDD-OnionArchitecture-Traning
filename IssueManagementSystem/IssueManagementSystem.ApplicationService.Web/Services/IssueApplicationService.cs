using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Issue;
using IssueManagementSystem.DomainService.Issue;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// 課題ApplicationService
    /// </summary>
    public class IssueApplicationService : IIssueApplicationService
    {
        /// <summary>
        /// 課題Repository
        /// </summary>
        private IIssueRepository IssueRepository { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueRepository">課題Repository</param>
        public IssueApplicationService(IIssueRepository issueRepository)
        {
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
            throw new NotImplementedException();
        }
    }
}
