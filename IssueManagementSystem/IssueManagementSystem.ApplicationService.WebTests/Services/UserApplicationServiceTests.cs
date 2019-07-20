using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.ApplicationService.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories;
using IssueManagementSystem.ApplicationService.Web.ViewModels.User;

namespace IssueManagementSystem.ApplicationService.Web.Services.Tests
{
    [TestClass()]
    public class UserApplicationServiceTests
    {
        /// <summary>
        /// ユーザーApplicationService
        /// </summary>
        private IUserApplicationService UserApplicationService { get; } = new UserApplicationService(new TestUserManager(), new TestUserRepository());

        #region メソッドテスト

        #region Search
        [TestMethod()]
        public void SearchTest()
        {
            var viewModels = UserApplicationService.Search(new UserIndexSerchConditionViewModel());
            Assert.AreEqual(5, viewModels.Count);
            var loopCount = 1;
            foreach (var v in viewModels)
            {
                Assert.AreEqual("UserId" + loopCount.ToString(), v.UserId);
                Assert.AreEqual("LastName" + loopCount.ToString() + " FirstName" + loopCount, v.UserName);
                loopCount++;
            }
        }
        #endregion

        #region Create
        [TestMethod()]
        public void CreateTest()
        {
            var viewModel = new UserCreateViewModel()
            {
                UserId = "UserId",
                Password = "Password",
                PasswordForConfirmation = "Password",
                LastName = "LastName",
                FirstName = "FirstName"
            };
            UserApplicationService.Create(viewModel);
        }
        #endregion

        #region GetUserEditViewModel
        [TestMethod()]
        public void GetUserEditViewModelTest()
        {
            var viewMode = UserApplicationService.GetUserEditViewModel("Test");
            Assert.AreEqual("Test", viewMode.UserId);
            Assert.AreEqual("LastName", viewMode.LastName);
            Assert.AreEqual("FirstName", viewMode.FirstName);
        }
        #endregion

        #endregion
    }
}