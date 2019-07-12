using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using IssueManagementSystem.DomainModel.Auth;

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
        /// ログインユーザーRepository
        /// </summary>
        public ILoginUserRepository LoginUserRepository { get; }

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
        /// <param name="loginUserRepository"></param>
        /// <param name="authentication"></param>
        /// <param name="passwordHasher"></param>
        public AuthManager(IUserRepository userRepository, 
                           ILoginUserRepository loginUserRepository, 
                           IPasswordHasher passwordHasher, 
                           IMyAuthentication authentication)
        {
            UserRepository = userRepository;
            LoginUserRepository = loginUserRepository;
            PasswordHasher = passwordHasher;
            Authentication = authentication;
        }

        #region ログイン
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

            //認証する。
            Authentication.Authenticate(userId);

            //ログインユーザーを保存する。
            var loginUser = LoginUser.CreateByUser(user);
            LoginUserRepository.SaveLoginUser(loginUser);

            return true;
        }

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        /// <returns>ログインユーザー</returns>
        public LoginUser GetLoginUser()
        {
            return LoginUserRepository.GetLoginUser();
        }
        #endregion

        #region ログアウト
        /// <summary>
        /// ログイアウトする。
        /// </summary>
        public void Logout()
        {
            //認証を解除する。
            Authentication.CancelAuthorization();

            //ログインユーザーをクリアする。
            LoginUserRepository.ClearLoginUser();
        }
        #endregion
    }
}
