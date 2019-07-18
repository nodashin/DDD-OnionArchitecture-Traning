using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.DomainService.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructureLayer.TestPersistence.TestRepositories;

namespace IssueManagementSystem.DomainService.Auth.Tests
{
    [TestClass()]
    public class UserManagerTests
    {
        /// <summary>
        /// ユーザーマネージャー
        /// </summary>
        private IUserManager UserManager { get; } = new UserManager(new TestUserRepository(), new TestLoginUserRepository());

        #region メソッドテスト

        #region Create
        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }
        #endregion

        #region EditWithoutPasswordEdit
        [TestMethod()]
        public void EditWithoutPasswordTest()
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

        #endregion
    }
}