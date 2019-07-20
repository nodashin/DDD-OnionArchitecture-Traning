using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Issue;

namespace IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService
{
    /// <summary>
    /// テスト用課題マネージャー
    /// </summary>
    public class TestIssueManager : IIssueManager
    {
        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="issue">未使用</param>
        public void Create(Issue issue)
        {
            
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="issue">未使用</param>
        public void Edit(Issue issue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="issueId">未使用</param>
        public void Delete(int issueId)
        {
            throw new NotImplementedException();
        }
    }
}
