using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.DomainService.Auth;
using IssueManager.Web.ApplicationService.ViewModels.Home;

namespace IssueManager.Web.ApplicationService.Services
{
    /// <summary>
    /// ホームControllerサービス
    /// </summary>
    public class HomeControllerService : IHomeControllerService
    {
        /// <summary>
        /// 認証マネージャー
        /// </summary>
        private IAuthManager AuthManager { get; }

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HomeControllerService() : this(new AuthManager())
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="authManager">認証マネージャー</param>
        public HomeControllerService(IAuthManager authManager)
        {
            this.AuthManager = authManager;
        }
        #endregion

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>ログイン可否</returns>
        public bool Login(LoginViewModel viewModel)
        {
            return !(viewModel.Password == "1");
        }
    }
}
