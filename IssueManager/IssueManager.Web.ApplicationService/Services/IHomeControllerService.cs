using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.Web.ApplicationService.ViewModels.Home;

namespace IssueManager.Web.ApplicationService.Services
{
    /// <summary>
    /// ホームControllerサービス
    /// </summary>
    public interface IHomeControllerService
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>ログイン可否</returns>
        bool Login(LoginViewModel viewModel);
    }
}
