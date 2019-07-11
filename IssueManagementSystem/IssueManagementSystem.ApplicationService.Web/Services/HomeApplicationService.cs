using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ホームApplicationService
    /// </summary>
    public class HomeApplicationService : IHomeApplicationService
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="loginViewModel">ログインViewModel</param>
        /// <returns>ログイン成否
        public bool Login(LoginViewModel loginViewModel)
        {
            return false;
        }
    }
}
