using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.DomainService.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructureLayer.TestPersistence.TestRepositories;

namespace IssueManagementSystem.DomainService.Issue.Tests
{
    [TestClass()]
    public class IssueManagerTests
    {
        /// <summary>
        /// 課題Repository
        /// </summary>
        private IIssueManager IssueManager { get; } = new IssueManager(new TestIssueRepository());

        #region Create
        [TestMethod()]
        public void CreateTest()
        {
            var issue = new DomainModel.Issue.Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            IssueManager.Create(issue);
        }
        #endregion

        #region Edit
        [TestMethod()]
        public void EditTest()
        {
            var issue = new DomainModel.Issue.Issue()
            {
                Title = "Title",
                Content = "Content"
            };
            IssueManager.Edit(issue);
        }
        #endregion

        #region Delete
        [TestMethod()]
        public void DeleteTest()
        {
            IssueManager.Delete(0);
        }
        #endregion
    }
}