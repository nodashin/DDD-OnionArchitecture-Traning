using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Issue;
using IssueManagementSystem.Persistence.DataBaseContext;

namespace IssueManagementSystem.Persistence.Repositories
{
    /// <summary>
    /// 課題Repository
    /// </summary>
    public class IssueRepository : IIssueRepository
    {
        /// <summary>
        /// データベース
        /// </summary>
        private MyDataBase Db { get; } = new MyDataBase();

        /// <summary>
        /// 全課題を取得する。
        /// </summary>
        /// <returns>全課題</returns>
        public IQueryable<Issue> FindAll()
        {
            return Db.Issues;
        }

        public Issue FindById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="issue">課題</param>
        public void Create(Issue issue)
        {
            Db.Issues.Add(issue);
            Db.SaveChanges();
        }

        public void Modify(Issue model)
        {
            throw new NotImplementedException();
        }
    }
}
