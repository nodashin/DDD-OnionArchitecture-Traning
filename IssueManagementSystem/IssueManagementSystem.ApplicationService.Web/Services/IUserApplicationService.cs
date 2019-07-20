using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.User;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ユーザーApplicationServiceインタフェース
    /// </summary>
    public interface IUserApplicationService
    {
        /// <summary>
        /// ユーザーを検索する。
        /// </summary>
        /// <param name="SerchConditionViewModel">ユーザー一覧 - 検索条件ViewModel</param>
        /// <returns>検索条件に一致するユーザー一覧 - ユーザーViewModel</returns>
        List<UserIndexUserViewModel> Search(UserIndexSerchConditionViewModel SerchConditionViewModel);

        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="viewModel">ユーザー作成ViewModel</param>
        void Create(UserCreateViewModel viewModel);

        /// <summary>
        /// ユーザー編集ViewModelを取得する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザー編集ViewModel</returns>
        UserEditViewModel GetUserEditViewModel(string userId);
    }
}
