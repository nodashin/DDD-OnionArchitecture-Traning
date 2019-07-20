using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.Attributes;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.User
{
    /// <summary>
    /// ユーザー作成ViewModel
    /// </summary>
    public class UserCreateViewModel : UserViewModel
    {
        #region プロパティ
        /// <summary>
        /// パスワード
        /// </summary>
        [DisplayName("パスワード")]
        [DataType(DataType.Password)]
        [MyRequired]
        public string Password { get; set; }

        /// <summary>
        /// パスワード(確認用)
        /// </summary>
        [DisplayName("パスワード(確認用)")]
        [DataType(DataType.Password)]
        [MyRequired]
        [Compare("Password", ErrorMessage = "{1}と{0}が一致していません。")]
        public string PasswordForConfirmation { get; set; }
        #endregion
    }
}
