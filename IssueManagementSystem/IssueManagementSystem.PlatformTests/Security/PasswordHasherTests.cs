using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.Platform.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.Platform.Security.Tests
{
    [TestClass()]
    public class PasswordHasherTests
    {
        /// <summary>
        /// パスワードハッシャー
        /// </summary>
        private PasswordHasher PasswordHasher { get; } = new PasswordHasher();

        #region メソッドテスト

        #region HashPassword
        [TestMethod()]
        public void HashPasswordTest()
        {
            var hashPassword = PasswordHasher.HashPassword("Test");
            Assert.AreNotEqual("Test", hashPassword);
            Assert.IsTrue(BCrypt.Net.BCrypt.Verify("Test", hashPassword));
        }
        #endregion

        #region MatchPassword
        [TestMethod()]
        public void MatchPasswordTest()
        {
            var hashPassword = BCrypt.Net.BCrypt.HashPassword("Test");
            Assert.IsTrue(PasswordHasher.MatchPassword("Test", hashPassword));
            Assert.IsFalse(PasswordHasher.MatchPassword("Password", hashPassword));
        }
        #endregion

        #endregion
    }
}