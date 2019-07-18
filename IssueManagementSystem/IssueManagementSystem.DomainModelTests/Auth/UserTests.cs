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
    public class UserTests
    {
        #region メソッドテスト

        #region GetUserName
        [TestMethod()]
        public void GetUserNameTest()
        {
            var user = new User() { FirstName = "Lennon", LastName = "McCartney" };
            Assert.AreEqual("McCartney Lennon", user.GetUserName());
        }
        #endregion

        #endregion
    }
}