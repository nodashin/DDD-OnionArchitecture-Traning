using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャーインターフェース
    /// </summary>
    public interface IAuthManager
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン成否</returns>
        bool Login(string userId, string password);
    }
}
