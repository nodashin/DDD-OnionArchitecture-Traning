using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.DomainService.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructureLayer.TestPersistence.TestRepositories;
using IssueManagementSystem.DomainModel.Auth;

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
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName"
            };
            UserManager.Create(user);
        }
        #endregion

        #region EditWithoutPasswordEdit
        [TestMethod()]
        public void EditWithoutPasswordTest()
        {
            var user = new User()
            {
                UserId = "Test", //Testを設定しないとTestUserRepositoryでユーザー無しと判定されてしまう。
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName"
            };
            UserManager.Create(user);
        }
        #endregion

        #region Delete

        #region 削除対象ログインユーザーではないパターン
        [TestMethod()]
        public void DeleteTest_NotLoginUser()
        {
            UserManager.Delete("UserId");
        }
        #endregion

        #region 削除対象がログインユーザーパターン
        [TestMethod()]
        public void DeleteTest_LoginUser()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName"
            };
            var loginUser = LoginUser.CreateByUser(user);
            new TestLoginUserRepository().SaveLoginUser(loginUser);

            //テストメソッドを実行する。
            var isSuucess = false;
            try
            {
                UserManager.Delete("UserId");
            }
            catch (InvalidOperationException ex)
            {
                isSuucess = ex.Message == "ログイン中のユーザーは削除できません。";
            }
            Assert.IsTrue(isSuucess);
        }
        #endregion

        #endregion

        #endregion
    }
}