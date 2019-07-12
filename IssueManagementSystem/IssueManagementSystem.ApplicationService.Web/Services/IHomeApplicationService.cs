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


    }
}
