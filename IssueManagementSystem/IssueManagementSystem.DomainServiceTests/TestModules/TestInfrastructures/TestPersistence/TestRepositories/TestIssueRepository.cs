using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Issue;

namespace IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructures.TestPersistence.TestRepositories
{
    /// <summary>
    /// テスト用課題Repository
    /// </summary>
    internal class TestIssueRepository : IIssueRepository
    {
        public IEnumerable<Issue> FindAll()
        {
            throw new NotImplementedException();
        }

        public Issue FindById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="model">未使用</param>
        public void Add(Issue model)
        {
            
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="model">未使用</param>
        public void Modify(Issue model)
        {
            
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="model">未使用</param>
        public void Remove(int id)
        {
            
        }
    }
}
