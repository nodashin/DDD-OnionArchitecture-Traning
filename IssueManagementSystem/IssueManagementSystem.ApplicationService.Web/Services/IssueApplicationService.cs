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
        /// 検索する。
        /// </summary>
        /// <param name="searchConditionViewModel">検索条件ViewModel</param>
        /// <returns>検索条件に一致する課題群</returns>
        public List<IssueIndexIssueViewModel> Search(IssueIndexSearchConditionViewModel searchConditionViewModel)
        {
            var issues = IssueRepository.FindAll();

            var issueViewModels = new List<IssueIndexIssueViewModel>();
            foreach (var issue in issues)
            {
                issueViewModels.Add(IssueIndexIssueViewModel.CreateByIssue(issue));
            }

            return issueViewModels;
        }
    }
}
