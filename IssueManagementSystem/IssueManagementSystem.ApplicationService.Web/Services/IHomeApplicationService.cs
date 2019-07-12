using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ホームApplicationServiceインタフェース
    /// </summary>
    public interface IHomeApplicationService
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="loginViewModel">ログインViewModel</param>
        /// <returns>ログイン成否</returns>
        bool Login(LoginViewModel loginViewModel);

        /// <summary>
        /// ログイン後メニューViewModelを取得する。
        /// </summary>
        /// <returns>ログイン後メニューViewModel</returns>
        LoggedInMenuViewModel GetLoggedInMenuViewModel();

        /// <summary>
        /// ログアウトする。
        /// </summary>
        void Logout();
    }
}
