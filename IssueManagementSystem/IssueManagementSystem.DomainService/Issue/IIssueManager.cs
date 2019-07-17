using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Issue
{
    /// <summary>
    /// 課題マネージャーインタフェース
    /// </summary>
    public interface IIssueManager
    {
        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="issue">作成する課題</param>
        void Create(DomainModel.Issue.Issue issue);

        /// <summary>
        /// 課題を修正する。
        /// </summary>
        /// <param name="issue">修正する課題</param>
        void Edit(DomainModel.Issue.Issue issue);
    }
}
