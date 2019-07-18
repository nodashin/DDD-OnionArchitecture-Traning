using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.Attributes;

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
        [MyRequired]
        [RegularExpression("[0-9a-zA-Z]*", ErrorMessage ="{0}は半角英数字で入力してください。")]
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
        /// <summary>
        /// ログイン後のリダイレクトURLからログインViewModelを生成する。
        /// </summary>
        /// <param name="returnUrl">ログイン後のリダイレクトURL</param>
        /// <returns>ログインViewModel</returns>
        public static LoginViewModel CreateByReturnUrl(string returnUrl)
            => new LoginViewModel() { ReturnUrl = returnUrl };
        #endregion
    }
}
