using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Issue;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// 課題AppicationServiceインタフェース
    /// </summary>
    public interface IIssueApplicationService
    {
        /// <summary>
        /// 課題を検索する。
        /// </summary>
        /// <param name="searchConditionViewModel">課題一覧 - 検索条件ViewModel</param>
        /// <returns>検索条件に一致する課題一覧 - 課題ViewModel</returns>
        List<IssueIndexIssueViewModel> Search(IssueIndexSearchConditionViewModel searchConditionViewModel);

        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="viewModel">課題作成ViewModel</param>
        void Create(IssueCreateViewModel viewModel);

        /// <summary>
        /// 課題を編集する。
        /// </summary>
        /// <param name="viewModel">課題編集ViewModel</param>
        void Edit(IssueEditViewModel viewModel);

        /// <summary>
        /// 課題を削除する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        void Delete(int issueId);

        /// <summary>
        /// 課題編集ViewModelを取得する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns>課題編集ViewModel</returns>
        IssueEditViewModel GetIssueEditViewModel(int issueId);
    }
}
