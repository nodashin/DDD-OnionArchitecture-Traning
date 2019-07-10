using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.Web.ApplicationService.Attributes;

namespace IssueManager.Web.ApplicationService.ViewModels.Home
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
        [MyRequired]
        public string UserId { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        [DisplayName("パスワード")]
        [DataType(DataType.Password)]
        [MyRequired]
        public string Password { get; set; }

        /// <summary>
        /// ログイン後のリダイレクトURL
        /// </summary>
        public string ReturnUrl { get; set; }
        #endregion
          
        #region メソッド

        #region Factory
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
