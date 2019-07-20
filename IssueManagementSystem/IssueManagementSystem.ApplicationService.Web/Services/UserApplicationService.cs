using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.User;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ユーザーApplicationService
    /// </summary>
    public class UserApplicationService : IUserApplicationService
    {
        #region プロパティ
        /// <summary>
        /// ユーザーマネージャー
        /// </summary>
        private IUserManager UserManager { get; }

        /// <summary>
        /// ユーザーRepository
        /// </summary>
        private IUserRepository UserRepository { get; }
        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userManager">ユーザーマネージャー</param>
        /// <param name="userRepository">ユーザーRepository</param>
        public UserApplicationService(IUserManager userManager, IUserRepository userRepository)
        {
            UserManager = userManager;
            UserRepository = userRepository;
        }
        #endregion

        /// <summary>
        /// ユーザーを検索する。
        /// </summary>
        /// <param name="SerchConditionViewModel">ユーザー一覧 - 検索条件ViewModel</param>
        /// <returns>検索条件に一致するユーザー一覧 - ユーザーViewModel</returns>
        public List<UserIndexUserViewModel> Search(UserIndexSerchConditionViewModel SerchConditionViewModel)
        {
            var users = UserRepository.FindAll().OrderBy(u => u.UserId);

            //TODO:ここで検索条件でフィルタリングをかける。

            var userIndexViewModels = new List<UserIndexUserViewModel>();
            foreach (var u in users)
            {
                userIndexViewModels.Add(UserIndexUserViewModel.CreateByUser(u));
            }

            return userIndexViewModels;
        }

        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="viewModel">ユーザー作成ViewModel</param>
        public void Create(UserCreateViewModel viewModel)
        {
            var user = User.CreateByDetailInfo(viewModel.UserId, viewModel.LastName, viewModel.FirstName);
            UserManager.Create(user, viewModel.Password);
        }

        #endregion
    }
}
