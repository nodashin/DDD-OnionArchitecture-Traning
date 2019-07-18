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
        #region メソッド
        /// <summary>
        /// ログインユーザーを保存する。
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        void SaveLoginUser(LoginUser loginUser);

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        LoginUser GetLoginUser();

        /// <summary>
        /// ログインユーザーをクリアする。
        /// </summary>
        void ClearLoginUser();
        #endregion
    }
}
