using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Issue;

namespace IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories
{
    /// <summary>
    /// テスト用課題Repository
    /// </summary>
    internal class TestIssueRepository : IIssueRepository
    {
        public IQueryable<Issue> FindAll()
        {
            throw new NotImplementedException();
        }

        public Issue FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Issue model)
        {
            throw new NotImplementedException();
        }

        public void Modify(Issue model)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
