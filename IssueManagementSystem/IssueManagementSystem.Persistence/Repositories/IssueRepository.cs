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
        #region プロパティ
        /// <summary>
        /// データベース
        /// </summary>
        private MyDataBase Db { get; } = new MyDataBase();
        #endregion

        #region メソッド
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
        /// 課題を追加する。
        /// </summary>
        /// <param name="issue">追加する課題</param>
        public void Add(Issue issue)
        {
            Db.Issues.Add(issue);
            Db.SaveChanges();
        }

        /// <summary>
        /// 課題を修正する。
        /// </summary>
        /// <param name="issue">修正する課題</param>
        public void Modify(Issue issue)
        {
            var origin = FindById(issue.IssueId);
            origin.Title = issue.Title;
            origin.Content = issue.Content;

            Db.Entry(origin).State = EntityState.Modified;
            Db.SaveChanges();
        }

        /// <summary>
        /// 課題を削除する。
        /// </summary>
        /// <param name="issueId">削除する課題ID</param>
        public void Remove(int issueId)
        {
            var issue = FindById(issueId);
            Db.Issues.Remove(issue);
            Db.SaveChanges();
        }
        #endregion
    }
}
