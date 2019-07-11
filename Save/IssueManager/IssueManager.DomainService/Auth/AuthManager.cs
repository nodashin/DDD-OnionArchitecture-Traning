using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace IssueManager.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャー
    /// </summary>
    public class AuthManager : IAuthManager
    {
        /// <summary>
        /// ユーザーRepository
        /// </summary>
        private IUserRepository UserRepository { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userRepository">ユーザーRepository</param>
        public AuthManager(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン可否</returns>
        public bool Login(string userId, string password)
        {
            //ユーザーIDが一致しているか判定する。
            if(!UserRepository.Exists(userId))
                return false;

            //パスワードが一致しているか判定する。
            if (!MatchPassword(password, userId))
                return false;

            //認証する。
            FormsAuthentication.SetAuthCookie(userId, false);

            return true;
        }

        /// <summary>
        /// パスワードがユーザーIDのユーザーと一致しているか確認する。
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <param name="userId">パスワードが一致しているか確認するユーザーのユーザーID</param>
        /// <returns>一致有無</returns>
        private bool MatchPassword(string password, string userId)
        {
            var user = UserRepository.FindById(userId);
            if (user == null)
                throw new ArgumentException("指定したユーザーIDのユーザーが存在しません。");

            return BCrypt.Net.BCrypt.Verify(password, user.HashPassword);
        }

        /// <summary>
        /// パスワードをハッシュ化する。
        /// </summary>
        /// <param name="password">ハッシュ化するパスワード</param>
        /// <returns>ハッシュパスワード</returns>
        public static string HashPassword(string password)
            => BCrypt.Net.BCrypt.HashPassword(password);
    }
}
