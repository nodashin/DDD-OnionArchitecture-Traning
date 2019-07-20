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
    /// ユーザーViewModel
    /// </summary>
    public class UserViewModel
    {
        #region プロパティ
        /// <summary>
        /// ユーザーID
        /// </summary>
        [DisplayName("ユーザーID")]
        [MyRequired]
        [RegularExpression("[0-9a-zA-Z]*", ErrorMessage ="ユーザーIDは半角英数字で入力してください。")]
        public string UserId { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [DisplayName("名字")]
        [MyRequired]
        public string LastName { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [DisplayName("名前")]
        [MyRequired]
        public string FirstName { get; set; }
        #endregion
    }
}
