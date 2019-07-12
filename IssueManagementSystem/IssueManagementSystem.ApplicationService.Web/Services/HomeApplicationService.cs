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
        /// <summary>
        /// 認証マネージャー
        /// </summary>
        private IAuthManager AuthManager { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="authManager">認証マネージャー</param>
        public HomeApplicationService(IAuthManager authManager)
        {
            AuthManager = authManager;
        }

        #region ログイン
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>ログイン成否</returns>
        public bool Login(LoginViewModel viewModel)
        {
            return AuthManager.Login(viewModel.UserId, viewModel.Password);
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
    }
}
