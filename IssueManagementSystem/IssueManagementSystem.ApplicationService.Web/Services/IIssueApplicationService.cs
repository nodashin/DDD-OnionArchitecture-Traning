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
        /// 検索する。
        /// </summary>
        /// <param name="searchConditionViewModel">検索条件ViewModel</param>
        /// <returns>検索条件に一致する課題群</returns>
        List<IssueIndexIssueViewModel> Search(IssueIndexSearchConditionViewModel searchConditionViewModel);
    }
}
