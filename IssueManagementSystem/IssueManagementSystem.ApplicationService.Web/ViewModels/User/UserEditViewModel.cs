using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.User
{
    /// <summary>
    /// ユーザー編集ViewModel
    /// </summary>
    public class UserEditViewModel : UserViewModel
    {
        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ(View用)
        /// </summary>
        public UserEditViewModel() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="user">ユーザー</param>
        private UserEditViewModel(DomainModel.Auth.User user)
        {
            UserId = user.UserId;
            LastName = user.LastName;
            FirstName = user.FirstName;
        }
        #endregion

        #region Factories
        /// <summary>
        /// ユーザーを元にユーザー編集ViewModelを生成する。
        /// </summary>
        /// <param name="user">ユーザー</param>
        /// <returns>ユーザー編集ViewModel</returns>
        public static UserEditViewModel CreateByUser(DomainModel.Auth.User user)
            => new UserEditViewModel(user);
        #endregion

        #endregion
    }
}
