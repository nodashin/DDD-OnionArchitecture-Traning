using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Home
{
    /// <summary>
    /// ログイン後メニューViewModel
    /// </summary>
    public class LoggedInMenuViewModel
    {
        #region プロパティ
        /// <summary>
        /// ログイン有無
        /// </summary>
        public bool LoggedIn { get => LoginUser != null; }

        /// <summary>
        /// ログインユーザーID
        /// </summary>
        public string LoginUserId { get => LoginUser?.UserId; }

        /// <summary>
        /// ログインユーザー名
        /// </summary>
        public string LoginUserName { get => LoginUser?.UserId; }

        /// <summary>
        /// ログインユーザー
        /// </summary>
        private LoginUser LoginUser { get; }
        #endregion

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        private LoggedInMenuViewModel(LoginUser loginUser)
        {
            LoginUser = loginUser;
        }

        /// <summary>
        /// ログインユーザーからログイン後メニューViewModelを生成する。
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        /// <returns>ログイン後メニューViewModel</returns>
        public static LoggedInMenuViewModel CreateByLoginUser(LoginUser loginUser)
            => new LoggedInMenuViewModel(loginUser);
        #endregion
    }
}
