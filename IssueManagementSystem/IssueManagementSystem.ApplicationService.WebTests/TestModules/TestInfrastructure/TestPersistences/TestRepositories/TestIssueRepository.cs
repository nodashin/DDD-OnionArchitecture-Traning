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
        /// <summary>
        /// テスト用課題を返す。
        /// </summary>
        /// <returns>テスト用課題</returns>
        public IEnumerable<Issue> FindAll()
        {
            for (int i = 1; i <= 5; i++)
            {
                var issue = new Issue()
                {
                    IssueId = i,
                    Title = "Title" + i.ToString(),
                    Content = "Content" + i.ToString(),
                };
                yield return issue;
            }
        }

        /// <summary>
        /// 課題IDが1のときだけ課題を返す。
        /// </summary>
        /// <param name="id">課題ID。1のときだけ課題を返す。</param>
        /// <returns>課題IDが1のときだけ課題を返す。</returns>
        public Issue FindById(int id)
        {
            if (id != 1)
                return null;

            return new Issue()
            {
                IssueId = id,
                Title = "Title" + id.ToString(),
                Content = "Content" + id.ToString()
            };
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
