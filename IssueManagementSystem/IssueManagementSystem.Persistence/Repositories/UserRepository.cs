using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;
using IssueManagementSystem.Persistence.DataBaseContext;

namespace IssueManagementSystem.Persistence.Repositories
{
    /// <summary>
    /// ユーザーRepository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// データベース
        /// </summary>
        private readonly MyDataBase Db = new MyDataBase();

        /// <summary>
        /// ユーザーIDからユーザーを取得する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザー</returns>
        public User FindById(string userId)
        {
            return Db.Users.SingleOrDefault(u => u.UserId == userId);
        }
    }
}
