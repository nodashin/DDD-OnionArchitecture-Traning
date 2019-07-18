using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.Persistence.DataBaseContext;
using IssueManagementSystem.DomainModel.Issue;

namespace IssueManagementSystem.Persistence.Repositories.Tests
{
    [TestClass()]
    public class IssueRepositoryTests
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private MyDataBase Db { get; } = new MyDataBase();

        /// <summary>
        /// 課題Repository
        /// </summary>
        private IssueRepository IssueRepository { get; } = new IssueRepository();

        [TestInitialize]
        public void TestInitialize()
        {
            Db.Issues.RemoveRange(Db.Issues);
            Db.SaveChanges();
        }

        #region メソッドテスト

        #region FindAll
        [TestMethod()]
        public void FindAllTest()
        {
            //テストデータを準備する。
            for (int i = 1; i <= 5; i++)
            {
                var issue = new Issue()
                {
                    Title = "Title" + i.ToString(),
                    Content = "Content" + i.ToString(),
                };
                Db.Issues.Add(issue);
            }
            Db.SaveChanges();

            //テストする。
            var actualData = IssueRepository.FindAll().ToList();
            Assert.AreEqual(5, actualData.Count);
            var loopCount = 1;
            foreach (var actual in actualData)
            {
                Assert.AreEqual("Title" + loopCount.ToString(), actual.Title);
                Assert.AreEqual("Content" + loopCount.ToString(), actual.Content);
                loopCount++;
            }
        }
        #endregion

        #region FindById

        #region 課題ID一致パターン
        [TestMethod()]
        public void FindByIdTest_MatchId()
        {
            //テストデータを準備する。
            var issue = new Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            Db.Issues.Add(issue);
            Db.SaveChanges();

            //テストする。
            var issueId = Db.Issues.Single().IssueId;
            var actual = IssueRepository.FindById(issueId);
            Assert.IsNotNull(actual);
            Assert.AreEqual(issueId, actual.IssueId);
            Assert.AreEqual("Title", actual.Title);
            Assert.AreEqual("Content", actual.Content);
        }
        #endregion

        #region 課題ID不一致パターン
        [TestMethod()]
        public void FindByIdTest_UnMatchId()
        {
            //テストデータを準備する。
            var issue = new Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            Db.Issues.Add(issue);
            Db.SaveChanges();

            //テストする。
            var issueId = Db.Issues.Single().IssueId;
            var actual = IssueRepository.FindById(issueId + 1); //課題ID+1し強制的に不一致のIDで検索する。
            Assert.IsNull(actual);
        }
        #endregion

        #endregion

        #region Add
        [TestMethod()]
        public void AddTest()
        {
            //テストデータを準備する。
            var issue = new Issue()
            {
                Title = "Title",
                Content = "Content"
            };

            //テストする。
            IssueRepository.Add(issue);
            var actual = Db.Issues.Single();
            Assert.AreEqual("Title", actual.Title);
            Assert.AreEqual("Content", actual.Content);
        }
        #endregion

        #region Modify
        [TestMethod()]
        public void ModifyTest()
        {
            //テストデータを準備する。
            var issue = new Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            Db.Issues.Add(issue);
            Db.SaveChanges();
            issue = Db.Issues.Single();
            var issueId = issue.IssueId;

            //テストする。
            issue.Title += "Modify";
            issue.Content += "Modify";
            IssueRepository.Modify(issue);
            var actual = Db.Issues.Single();
            Assert.AreEqual(issueId, actual.IssueId);
            Assert.AreEqual("TitleModify", actual.Title);
            Assert.AreEqual("ContentModify", actual.Content);
        }
        #endregion

        #region Remove
        [TestMethod()]
        public void RemoveTest()
        {
            //テストデータを準備する。
            var issue = new Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            Db.Issues.Add(issue);
            Db.SaveChanges();
            var issueId = Db.Issues.Single().IssueId;

            //テストする。
            IssueRepository.Remove(issueId);
            var actual = Db.Issues.ToList();
            Assert.AreEqual(0, actual.Count);
        }
        #endregion

        #endregion
    }
}