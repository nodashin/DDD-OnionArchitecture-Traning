using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ホームApplicationService
    /// </summary>
    public class HomeApplicationService : IHomeApplicationService
    {
        #region プロパティ
        /// <summary>
        /// 認証マネージャー
        /// </summary>
        private IAuthManager AuthManager { get; }
        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="authManager">認証マネージャー</param>
        public HomeApplicationService(IAuthManager authManager)
        {
            AuthManager = authManager;
        }
        #endregion

        #region ログイン
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>ログイン成否</returns>
        public bool Login(LoginViewModel viewModel)
        {
            return AuthManager.Login(viewModel.UserId, viewModel.Password) == LoginResult.Success;
        }

        /// <summary>
        /// ログイン後メニューViewModelを取得する。
        /// </summary>
        /// <returns>ログイン後メニューViewModel</returns>
        public LoggedInMenuViewModel GetLoggedInMenuViewModel()
        {
            var loginUser = AuthManager.GetLoginUser();
            return LoggedInMenuViewModel.CreateByLoginUser(loginUser);
        }
        #endregion

        #region ログアウト
        /// <summary>
        /// ログアウトする。
        /// </summary>
        public void Logout()
        {
            AuthManager.Logout();
        }
        #endregion

        #region パスワード変更
        /// <summary>
        /// パスワードを変更する。
        /// </summary>
        /// <param name="viewModel">パスワード変更ViewModel</param>
        /// <returns>パスワード変更成否</returns>
        public bool ChangePassword(PasswordChangeViewModel viewModel)
        {
            return AuthManager.ChangePassword(viewModel.UserId, viewModel.NowPassword, viewModel.NewPassword) == PasswordChangeResult.Success;
        }
        #endregion

        #endregion
    }
}
