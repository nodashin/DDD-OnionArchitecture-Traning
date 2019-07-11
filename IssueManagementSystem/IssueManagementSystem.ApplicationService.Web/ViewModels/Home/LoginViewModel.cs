using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Home
{
    /// <summary>
    /// ログインViewModel
    /// </summary>
    public class LoginViewModel
    {
        #region プロパティ
        /// <summary>
        /// ユーザーID
        /// </summary>
        [DisplayName("ユーザーID")]
        public string UserId { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        [DisplayName("パスワード")]
        public string Password { get; set; }

        /// <summary>
        /// ログイン後のリダイレクトURL
        /// </summary>
        public string ReturnUrl { get; set; }
        #endregion

        #region メソッド

        #region ファクトリー
        /// <summary>
        /// ログイン後のリダイレクトURLからログインViewModelを生成する。
        /// </summary>
        /// <param name="returnUrl">ログイン後のリダイレクトURL</param>
        /// <returns>ログインViewModel</returns>
        public static LoginViewModel CreateByReturnUrl(string returnUrl)
            => new LoginViewModel() { ReturnUrl = returnUrl };
        #endregion

        #endregion
    }
}
