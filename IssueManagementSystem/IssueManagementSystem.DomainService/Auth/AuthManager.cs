using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャー
    /// </summary>
    public class AuthManager : IAuthManager
    {
        #region プロパティ
        /// <summary>
        /// ユーザーRepository
        /// </summary>
        private IUserRepository UserRepository { get; }

        /// <summary>
        /// パスワードハッシュ
        /// </summary>
        private IPasswordHasher PasswordHasher { get; }

        /// <summary>
        /// 認証
        /// </summary>
        public IMyAuthentication Authentication { get; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userRepository">ユーザーRepository</param>
        public AuthManager(IUserRepository userRepository, IPasswordHasher passwordHasher, IMyAuthentication authentication)
        {
            UserRepository = userRepository;
            PasswordHasher = passwordHasher;
            Authentication = authentication;
        }

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン成否</returns>
        public bool Login(string userId, string password)
        {
            var user = UserRepository.FindById(userId);
            if (user == null)
                return false;

            if (!PasswordHasher.MatchPassword(password, user.HashPassword))
                return false;

            Authentication.Authenticate(userId);

            return true;
        }
    }
}
