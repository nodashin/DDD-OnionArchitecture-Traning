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
    /// パスワード変更ViewModel
    /// </summary>
    public class PasswordChangeViewModel
    {
        #region プロパティ
        /// <summary>
        /// ユーザーID
        /// </summary>
        [DisplayName("ユーザーID")]
        public string UserId { get; set; }

        /// <summary>
        /// 現在のパスワード
        /// </summary>
        [DisplayName("現在のパスワード")]
        [DataType(DataType.Password)]
        [MyRequired]
        public string NowPassword { get; set; }

        /// <summary>
        /// 新しいパスワード
        /// </summary>
        [DisplayName("新しいパスワード")]
        [DataType(DataType.Password)]
        [MyRequired]
        public string NewPassword { get; set; }

        /// <summary>
        /// 新しいパスワード(確認用)
        /// </summary>
        [DisplayName("新しいパスワード(確認用)")]
        [DataType(DataType.Password)]
        [MyRequired]
        [Compare("NewPassword", ErrorMessage = "{1}と{0}が一致していません。")]
        public string NewPasswordForConfirmation { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// ユーザーIDからパスワード変更ViewModelを生成する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>パスワード変更ViewModel</returns>
        public static PasswordChangeViewModel CreateByUserId(string userId)
            => new PasswordChangeViewModel() { UserId = userId };
        #endregion
    }
}
