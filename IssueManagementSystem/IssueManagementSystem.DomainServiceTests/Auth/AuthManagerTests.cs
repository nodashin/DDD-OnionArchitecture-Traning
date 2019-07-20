using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.DomainService.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructures.TestPersistence.TestRepositories;
using IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructures.TestPlatform.TestSecurity;

namespace IssueManagementSystem.DomainService.Auth.Tests
{
    [TestClass()]
    public class AuthManagerTests
    {
        /// <summary>
        /// 認証マネージャー
        /// </summary>
        private AuthManager AuthManager { get; } = new AuthManager(new TestUserRepository(),
                                                                   new TestLoginUserRepository(),
                                                                   new TestMyAuthentication(),
                                                                   new TestPasswordHasher());

        #region メソッドテスト

        #region Login

        #region 成功パターン
        [TestMethod()]
        public void LoginTest_Sucess()
        {
            var actual = AuthManager.Login("Test", "Test");
            Assert.AreEqual(LoginResult.Success, actual);
        }
        #endregion

        #region ユーザーID不一致パターン
        [TestMethod()]
        public void LoginTest_UserIdDifference()
        {
            var actual = AuthManager.Login("UserIdDifference", "");
            Assert.AreEqual(LoginResult.UserIdDifference, actual);
        }
        #endregion

        #region パスワード不一致パターン
        [TestMethod()]
        public void LoginTest_PasswordDifference()
        {
            var actual = AuthManager.Login("Test", "PasswordDifference");
            Assert.AreEqual(LoginResult.PasswordDifference, actual);
        }
        #endregion

        #endregion

        #region ChangePassword

        #region 成功パターン
        [TestMethod()]
        public void ChangePasswordTest_Success()
        {
            var actual = AuthManager.ChangePassword("Test", "Test", "Test");
            Assert.AreEqual(PasswordChangeResult.Success, actual);
        }
        #endregion

        #region 現在のパスワード不一致パターン
        [TestMethod()]
        public void ChangePasswordTest_NowPasswordDifference()
        {
            var actual = AuthManager.ChangePassword("Test", "PasswordDifference", "Test");
            Assert.AreEqual(PasswordChangeResult.PasswordDifference, actual);
        }
        #endregion

        #endregion

        #endregion
    }
}