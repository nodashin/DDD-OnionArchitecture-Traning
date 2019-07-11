using IssueManager.Dmain.Auth;
using IssueManager.DomainService.Auth;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMan.Persistence.Repositories
{
    /// <summary>
    /// DBコンテキストイニシャライザー
    /// </summary>
    class MyDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        /// <summary>
        /// DBコンテキストを初期化する。
        /// </summary>
        /// <param name="context">DBコンテキスト</param>
        protected override void Seed(MyDbContext context)
        {
            //ユーザー
            var users = new List<User>()
            {
                new User()
                {
                    Id = "0227",
                    HashPassword = AuthManager.HashPassword("0227"),
                    LastName = "野田",
                    FirstName = "凛"
                },
                new User()
                {
                    Id = "0501",
                    HashPassword = AuthManager.HashPassword("0501"),
                    LastName = "野田",
                    FirstName = "柚子"
                },
                new User()
                {
                    Id = "0725",
                    HashPassword = AuthManager.HashPassword("0725"),
                    LastName = "小坂",
                    FirstName = "輝良"
                },
                new User()
                {
                    Id = "0328",
                    HashPassword = AuthManager.HashPassword("0328"),
                    LastName = "小坂",
                    FirstName = "蓮"
                },
            };
            context.Users.AddRange(users);

            context.SaveChanges();
        }
    }
}