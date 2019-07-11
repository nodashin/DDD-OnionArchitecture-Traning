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

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>ログイン成否</returns>
        public bool Login(LoginViewModel viewModel)
        {
            return AuthManager.Login(viewModel.UserId, viewModel.Password);
        }
    }
}
