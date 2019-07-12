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
        /// <returns>ログイン結果</returns>
        LoginResult Login (string userId, string password);

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        /// <returns>ログインユーザー</returns>
        LoginUser GetLoginUser();

        /// <summary>
        /// ログアウトする。
        /// </summary>
        void Logout();

        /// <summary>
        /// パスワードを変更する。
        /// </summary>
        /// <param name="userId">パスワードを変更するユーザーのユーザーID</param>
        /// <param name="nowPassword">現在のパスワード</param>
        /// <param name="newPassword">新しいパスワード</param>
        /// <returns>パスワード変更結果</returns>
        PasswordChangeResult ChangePassword(string userId, string nowPassword, string newPassword);
    }
}
