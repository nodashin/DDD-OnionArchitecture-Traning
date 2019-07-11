using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManager.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャーインタフェース
    /// </summary>
    public interface IAuthManager
    {
        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン可否</returns>
        bool Login(string userId, string password);
    }
}
