using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.DomainModel.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Auth.Tests
{
    [TestClass()]
    public class LoginUserTests
    {
        #region プロパティテスト

        #region UserId

        #region ユーザーがNULLじゃないパターン
        [TestMethod()]
        public void UserIdTest_UserIsNotNull()
        {
            var user = new User() { UserId = "Test" };
            var loginUser = LoginUser.CreateByUser(user);

            Assert.IsNotNull(loginUser.UserId);
            Assert.AreEqual(user.UserId, loginUser.UserId);
        }
        #endregion

        #region ユーザーがNULLパターン
        [TestMethod()]
        public void UserIdTest_UserIsNull()
        {
            var loginUser = LoginUser.CreateByUser(null);
            Assert.IsNull(loginUser.UserId);
        }
        #endregion

        #endregion

        #region UserName

        #region ユーザーがNULLじゃないパターン
        [TestMethod()]
        public void UserNameTest_UserIsNotNull()
        {
            var user = new User() { FirstName = "Lennon", LastName = "McCartney" };
            var loginUser = LoginUser.CreateByUser(user);

            Assert.IsNotNull(loginUser.UserName);
            Assert.AreEqual(user.GetUserName(), loginUser.UserName);
        }
        #endregion

        #region ユーザーがNULLパターン
        [TestMethod()]
        public void UserNameTest_UserIsNull()
        {
            var loginUser = LoginUser.CreateByUser(null);
            Assert.IsNull(loginUser.UserName);
        }
        #endregion

        #endregion

        #endregion
    }
}