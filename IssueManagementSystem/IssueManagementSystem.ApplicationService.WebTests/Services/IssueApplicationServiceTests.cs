using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.ApplicationService.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Issue;

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
            var viewModels = IssueApplicationService.Search(new IssueIndexSearchConditionViewModel());
            Assert.AreEqual(5, viewModels.Count);
            int loopCount = 1;
            foreach (var viewModel in viewModels)
            {
                Assert.AreEqual(loopCount, viewModel.IssueId);
                Assert.AreEqual("Title" + loopCount, viewModel.Title);
                loopCount++;
            }
        }
        #endregion

        #region  Create
        [TestMethod()]
        public void CreateTest()
        {
            var viewModel = new IssueCreateViewModel()
            {
                Title = "Title",
                Content = "Content"
            };
            IssueApplicationService.Create(viewModel);
        }
        #endregion

        #region Edit
        [TestMethod()]
        public void EditTest()
        {
            var viewModel = new IssueEditViewModel()
            {
                IssueId = 1,
                Title = "Title",
                Content = "Content"
            };
            IssueApplicationService.Edit(viewModel);
        }
        #endregion

        #region Delete
        [TestMethod()]
        public void DeleteTest()
        {
            IssueApplicationService.Delete(1);
        }
        #endregion

        #region GetIssueEditViewModel
        [TestMethod()]
        public void GetIssueEditViewModelTest()
        {
            var viewModel = IssueApplicationService.GetIssueEditViewModel(1);
            Assert.AreEqual(1, viewModel.IssueId);
            Assert.AreEqual("Title1", viewModel.Title);
            Assert.AreEqual("Content1", viewModel.Content);
        }
        #endregion

        #endregion
    }
}