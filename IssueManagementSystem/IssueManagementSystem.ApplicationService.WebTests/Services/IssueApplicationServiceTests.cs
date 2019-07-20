using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.ApplicationService.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories;

namespace IssueManagementSystem.ApplicationService.Web.Services.Tests
{
    [TestClass()]
    public class IssueApplicationServiceTests
    {
        /// <summary>
        /// 課題ApplicationService
        /// </summary>
        private IIssueApplicationService IssueApplicationService = new IssueApplicationService(new TestIssueManager(), new TestIssueRepository());

        #region メソッドテスト

        #region Search
        [TestMethod()]
        public void SearchTest()
        {
            Assert.Fail();
        }
        #endregion

        #region  Create
        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }
        #endregion

        #region Edit
        [TestMethod()]
        public void EditTest()
        {
            Assert.Fail();
        }
        #endregion

        #region Delete
        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
        #endregion

        #region GetIssueEditViewModel
        [TestMethod()]
        public void GetIssueEditViewModelTest()
        {
            Assert.Fail();
        }
        #endregion

        #endregion
    }
}