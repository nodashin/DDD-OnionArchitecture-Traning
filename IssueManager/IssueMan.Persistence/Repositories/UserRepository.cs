using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.Dmain.Auth;
using IssueManager.DomainService.Auth;

namespace IssueMan.Persistence.Repositories
{
    /// <summary>
    /// ユーザーRepository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private MyDbContext Db { get; } = new MyDbContext();

        /// <summary>
        /// ユーザーIDからユーザーを取得する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザー</returns>
        public User FindById(string userId)
        {
            return this.Db.Users.SingleOrDefault(u => u.Id == userId);
        }
    }
}
