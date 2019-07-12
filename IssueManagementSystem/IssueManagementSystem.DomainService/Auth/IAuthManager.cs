using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャーインターフェース
    /// </summary>
    public interface IAuthManager
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン成否</returns>
        bool Login(string userId, string password);

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        /// <returns>ログインユーザー</returns>
        LoginUser GetLoginUser();

        /// <summary>
        /// ログアウトする。
        /// </summary>
        void Logout();
    }
}
