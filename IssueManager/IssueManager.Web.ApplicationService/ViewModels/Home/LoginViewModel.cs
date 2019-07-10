using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManager.Web.ApplicationService.ViewModels.Home
{
    /// <summary>
    /// ログインViewModel
    /// </summary>
    public class LoginViewModel
    {
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
    }
}
