using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// ログインユーザーRepository
    /// </summary>
    public interface ILoginUserRepository
    {
        /// <summary>
        /// ログインユーザー
        /// </summary>
        void SetLoginUser(LoginUser loginUser);

        /// <summary>
        /// ログインユーザー
        /// </summary>
        LoginUser GetLoginUser();
    }
}
