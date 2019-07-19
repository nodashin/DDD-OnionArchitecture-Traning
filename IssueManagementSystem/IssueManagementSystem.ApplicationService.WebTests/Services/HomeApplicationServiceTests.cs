using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.ApplicationService.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomainLayer.TestDomainServices;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;

namespace IssueManagementSystem.ApplicationService.Web.Services.Tests
{
    [TestClass()]
    public class HomeApplicationServiceTests
    {
        /// <summary>
        /// ホームApplicationService
        /// </summary>
        private IHomeApplicationService HomeApplicationService { get; } = new HomeApplicationService(new TestAuthManager());

        #region メソッドテスト

        #region Login

        #region 成功パターン
        [TestMethod()]
        public void LoginTest_Success()
        {
            var viewModel = new LoginViewModel()
            {
                UserId = "Test",
                Password = "Test"
            };
            var actual = HomeApplicationService.Login(viewModel);
            Assert.IsTrue(actual);
        }
        #endregion

        #region ユーザーID不一致パターン
        [TestMethod()]
        public void LoginTest_UserIdDifference()
        {
            var viewModel = new LoginViewModel()
            {
                UserId = "UserIdDifference",
                Password = "Test"
            };
            var actual = HomeApplicationService.Login(viewModel);
            Assert.IsFalse(actual);
        }
        #endregion

        #region パスワード不一致パターン
        [TestMethod()]
        public void LoginTest_PasswordDifference()
        {
            var viewModel = new LoginViewModel()
            {
                UserId = "Test",
                Password = "PasswordDifference"
            };
            var actual = HomeApplicationService.Login(viewModel);
            Assert.IsFalse(actual);
        }
        #endregion

        #endregion

        #region GetLoggedInMenuView
        [TestMethod()]
        public void GetLoggedInMenuViewModelTest()
        {
            var viewModel = HomeApplicationService.GetLoggedInMenuViewModel();
            Assert.IsTrue(viewModel.IsLoggedIn);
            Assert.AreEqual("UserId", viewModel.LoginUserId);
            Assert.AreEqual("LastName FirstName", viewModel.LoginUserName);
        }
        #endregion

        #region Logout
        [TestMethod()]
        public void LogoutTest()
        {
            HomeApplicationService.Logout();
        }
        #endregion

        #region ChangePassword

        #region 成功パターン
        [TestMethod()]
        public void ChangePasswordTest_Success()
        {
            var viewModel = new PasswordChangeViewModel()
            {
                UserId = "UserId",
                NowPassword = "Test",
                NewPassword = "NewPassword",
                NewPasswordForConfirmation = "NewPassword",
            };
            var expected = HomeApplicationService.ChangePassword(viewModel);
            Assert.IsTrue(expected);
        }
        #endregion

        #region 現在のパスワード不一致パターン
        [TestMethod()]
        public void ChangePasswordTest_NowPasswordDifference()
        {
            var viewModel = new PasswordChangeViewModel()
            {
                UserId = "UserId",
                NowPassword = "NowPasswordDifference",
                NewPassword = "NewPassword",
                NewPasswordForConfirmation = "NewPassword",
            };
            var expected = HomeApplicationService.ChangePassword(viewModel);
            Assert.IsFalse(expected);
        }
        #endregion

        #endregion

        #endregion
    }
}