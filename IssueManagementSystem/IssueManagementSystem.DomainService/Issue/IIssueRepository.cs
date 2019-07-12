using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainService.Commons;

namespace IssueManagementSystem.DomainService.Issue
{
    /// <summary>
    /// 課題Repositoryインタフェース
    /// </summary>
    public interface IIssueRepository : IRepository<DomainModel.Issue.Issue, int>
    {
    }
}
