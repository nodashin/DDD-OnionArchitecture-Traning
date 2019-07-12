using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainModel.Issue;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.Persistence.DataBaseContext
{
    /// <summary>
    /// DBイニシャライザー
    /// </summary>
    class MyDataBaseInitializer : DropCreateDatabaseAlways<MyDataBase>
    {
        /// <summary>
        /// DBコンテキストを初期化する。
        /// </summary>
        /// <param name="context">DBコンテキスト</param>
        protected override void Seed(MyDataBase context)
        {
            #region ユーザー
            //ユーザー
            var passwordHasher = new InitialDataPasswordHasher();
            var users = new List<User>()
            {
                new User()
                {
                    UserId = "0227",
                    HashPassword = passwordHasher.HashPassword("0227"),
                    LastName = "野田",
                    FirstName = "凛"
                },
                new User()
                {
                    UserId = "0501",
                    HashPassword = passwordHasher.HashPassword("0501"),
                    LastName = "野田",
                    FirstName = "柚子"
                },
                new User()
                {
                    UserId = "0725",
                    HashPassword = passwordHasher.HashPassword("0725"),
                    LastName = "小坂",
                    FirstName = "輝良"
                },
                new User()
                {
                    UserId = "0328",
                    HashPassword = passwordHasher.HashPassword("0328"),
                    LastName = "小坂",
                    FirstName = "蓮"
                },
            };
            context.Users.AddRange(users);
            #endregion

            #region 課題
            var issues = new List<Issue>();
            for (int i = 1; i <= 20; i++)
            {
                var issue = new Issue()
                {
                    Title = "タイトル" + i.ToString(),
                    Content = "内容" + i.ToString()
                };
                issues.Add(issue);
            }
            context.Issues.AddRange(issues);
            #endregion

            context.SaveChanges();
        }

        /// <summary>
        /// 初期データ用パスワードハッシュ
        /// </summary>
        /// <remarks>
        /// 循環参照になるため、IssueManagementSystem.Platform.Security.PasswordHasherは実装しない。
        /// </remarks>
        class InitialDataPasswordHasher : IPasswordHasher
        {
            /// <summary>
            /// パスワードをハッシュ化する。
            /// </summary>
            /// <param name="password">ハッシュ化するパスワード</param>
            /// <returns>ハッシュ化パスワード</returns>
            public string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }

            public bool MatchPassword(string password, string hashPassword)
            {
                throw new NotImplementedException();
            }
        }
    }
}
