using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        /// <summary>
        /// 課題IDから課題を取得する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns>課題</returns>
        public Issue FindById(int issueId)
        {
            return Db.Issues.SingleOrDefault(i => i.IssueId == issueId);
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

        /// <summary>
        /// 課題を修正する。
        /// </summary>
        /// <param name="issue">課題</param>
        public void Modify(Issue issue)
        {
            var originIssue = FindById(issue.IssueId);
            originIssue.Title = issue.Title;
            originIssue.Content = issue.Content;

            Db.Entry(originIssue).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
