using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.Persistence.Repositories
{
    /// <summary>
    /// ログインユーザーRepository
    /// </summary>
    public class LoginUserRepository : ILoginUserRepository
    {
        /// <summary>
        /// ログインユーザー
        /// </summary>
        private static LoginUser LoginUser { get; set; }

        /// <summary>
        /// ログインユーザーを設定する。
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        public void SetLoginUser(LoginUser loginUser)
        {
            LoginUser = loginUser;
        }

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        /// <returns>ログインユーザー</returns>
        public LoginUser GetLoginUser()
        {
            return LoginUser;
        }
    }
}
