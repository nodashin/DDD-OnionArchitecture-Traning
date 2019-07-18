using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// 認証インタフェース
    /// </summary>
    public interface IMyAuthentication
    {
        #region メソッド
        /// <summary>
        /// 認証する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        void Authenticate(string userId);

        /// <summary>
        /// 認証を解除する。
        /// </summary>
        void CancelAuthorization();
        #endregion
    }
}
