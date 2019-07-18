using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.Persistence.DataBaseContext;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.Persistence.Repositories.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private MyDataBase Db { get; } = new MyDataBase();

        /// <summary>
        /// 課題Repository
        /// </summary>
        private UserRepository UserRepository { get; } = new UserRepository();

        [TestInitialize]
        public void TestInitialize()
        {
            Db.Users.RemoveRange(Db.Users);
            Db.SaveChanges();
        }

        #region メソッドテスト

        #region FindAll
        [TestMethod()]
        public void FindAllTest()
        {
            //テストデータを準備する。
            for (int i = 1; i <= 5; i++)
            {
                var user = new User()
                {
                    UserId = "UserId" + i.ToString(),
                    HashPassword = "HashPassword" + i.ToString(),
                    LastName = "LastName" + i.ToString(),
                    FirstName = "FirstName" + i.ToString(),
                };
                Db.Users.Add(user);
            }
            Db.SaveChanges();

            //テストする。
            var actualData = UserRepository.FindAll().ToList();
            Assert.AreEqual(5, actualData.Count);
            var loopCount = 1;
            foreach (var actual in actualData)
            {
                Assert.AreEqual("UserId" + loopCount.ToString(), actual.UserId);
                Assert.AreEqual("HashPassword" + loopCount.ToString(), actual.HashPassword);
                Assert.AreEqual("LastName" + loopCount.ToString(), actual.LastName);
                Assert.AreEqual("FirstName" + loopCount.ToString(), actual.FirstName);
                loopCount++;
            }
        }
        #endregion

        #region FindById

        #region ユーザーID一致パターン
        [TestMethod()]
        public void FindByIdTest_MatchId()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName",
            };
            Db.Users.Add(user);
            Db.SaveChanges();

            //テストする。
            var actual = UserRepository.FindById("UserId");
            Assert.IsNotNull(actual);
            Assert.AreEqual("UserId", actual.UserId);
            Assert.AreEqual("HashPassword", actual.HashPassword);
            Assert.AreEqual("LastName", actual.LastName);
            Assert.AreEqual("FirstName", actual.FirstName);
        }
        #endregion

        #region ユーザーID不一致パターン
        [TestMethod()]
        public void FindByIdTest_UnMatchId()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName",
            };
            Db.Users.Add(user);
            Db.SaveChanges();

            //テストする。
            var actual = UserRepository.FindById("UnMatchId");
            Assert.IsNull(actual);
        }
        #endregion

        #endregion

        #region Add
        [TestMethod()]
        public void AddTest()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName",
            };

            //テストする。
            UserRepository.Add(user);
            var actual = Db.Users.Single();
            Assert.AreEqual("UserId", actual.UserId);
            Assert.AreEqual("HashPassword", actual.HashPassword);
            Assert.AreEqual("LastName", actual.LastName);
            Assert.AreEqual("FirstName", actual.FirstName);
        }
        #endregion

        #region Modify
        [TestMethod()]
        public void ModifyTest()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName",
            };
            Db.Users.Add(user);
            Db.SaveChanges();
            user = Db.Users.Single();

            //テストする。
            user.HashPassword += "Modify";
            user.LastName += "Modify";
            user.FirstName += "Modify";
            UserRepository.Modify(user);
            var actual = Db.Users.Single();
            Assert.AreEqual("UserId", actual.UserId);
            Assert.AreEqual("HashPasswordModify", actual.HashPassword);
            Assert.AreEqual("LastNameModify", actual.LastName);
            Assert.AreEqual("FirstNameModify", actual.FirstName);
        }
        #endregion

        #region Remove
        [TestMethod()]
        public void RemoveTest()
        {
            //テストデータを準備する。
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName",
            };
            Db.Users.Add(user);
            Db.SaveChanges();

            //テストする。
            UserRepository.Remove("UserId");
            var actual = Db.Users.ToList();
            Assert.AreEqual(0, actual.Count);
        }
        #endregion

        #endregion
    }
}