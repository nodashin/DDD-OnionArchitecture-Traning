using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomainLayer.TestDomainServices
{
    /// <summary>
    /// テスト用認証マネージャー
    /// </summary>
    internal class TestAuthManager : IAuthManager
    {
        /// <summary>
        /// ユーザーIDが「Test」、パスワードが「Test」の場合のみログイン成功を返す。
        /// </summary>
        /// <param name="userId">「Test」のみログイン可能</param>
        /// <param name="password">「Test」のみログイン可能</param>
        /// <returns>ユーザーIDが「Test」、パスワードが「Test」の場合のみログイン成功を返す。</returns>
        public LoginResult Login(string userId, string password)
        {
            if (userId != "Test")
                return LoginResult.UserIdDifference;
            else if (password != "Test")
                return LoginResult.PasswordDifference;
            return LoginResult.Success;
        }

        /// <summary>
        /// 固定のログインユーザーを返す。
        /// </summary>
        /// <returns>固定のログインユーザー</returns>
        public LoginUser GetLoginUser()
        {
            var user = new User()
            {
                UserId = "UserId",
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName"
            };

            return LoginUser.CreateByUser(user);
        }

        /// <summary>
        /// 何もしない。
        /// </summary>
        public void Logout()
        {
            
        }

        /// <summary>
        /// 現在のパスワードが「Test」の時だけパスワード変更に成功する。
        /// </summary>
        /// <param name="userId">未使用</param>
        /// <param name="nowPassword">現在のパスワードが「Test」の時だけパスワード変更に成功</param>
        /// <param name="newPassword">未使用</param>
        /// <returns>現在のパスワードが「Test」の時だけパスワード変更成功を返し、それ以外は失敗を返す。</returns>
        public PasswordChangeResult ChangePassword(string userId, string nowPassword, string newPassword)
        {
            if (nowPassword != "Test")
                return PasswordChangeResult.PasswordDifference;
            return PasswordChangeResult.Success;
        }
    }
}
