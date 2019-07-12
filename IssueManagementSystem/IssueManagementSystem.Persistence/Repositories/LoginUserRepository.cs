using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;
using IssueManagementSystem.Persistence.Stores;

namespace IssueManagementSystem.Persistence.Repositories
{
    /// <summary>
    /// ログインユーザーRepository
    /// </summary>
    public class LoginUserRepository : ILoginUserRepository
    {

        /// <summary>
        /// ログインユーザーを保存する。
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        public void SaveLoginUser(LoginUser loginUser)
        {
            LoginUserStore.LoginUser = loginUser;
        }

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        public LoginUser GetLoginUser()
        {
            return LoginUserStore.LoginUser;
        }

        /// <summary>
        /// ログインユーザーをクリアする。
        /// </summary>
        public void ClearLoginUser()
        {
            LoginUserStore.LoginUser = null;
        }
    }
}
