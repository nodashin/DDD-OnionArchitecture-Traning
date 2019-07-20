using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using IssueManagementSystem.ApplicationService.Web.ViewModels.User;

namespace IssueManagementSystem.Web.Controllers
{
    /// <summary>
    /// ユーザーController
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// ユーザーApplicationService
        /// </summary>
        private IUserApplicationService UserApplicationService { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userApplicationService">ユーザーApplicationService</param>
        public UserController(IUserApplicationService userApplicationService)
        {
            UserApplicationService = userApplicationService;
        }

        #region ユーザー一覧
        /// <summary>
        /// ユーザー一覧Viewを表示する。
        /// </summary>
        /// <returns>ユーザー一覧View</returns>
        public ActionResult Index()
        {
            return Search(new UserIndexSerchConditionViewModel());
        }

        /// <summary>
        /// ユーザーを検索する。
        /// </summary>
        /// <param name="serchConditionViewModel">ユーザー一覧 - 検索条件ViewModel</param>
        /// <returns>ユーザー一覧View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(UserIndexSerchConditionViewModel serchConditionViewModel)
        {
            var userViewModels = UserApplicationService.Search(serchConditionViewModel);
            var viewModel = UserIndexViewModel.CreateByChildViewModels(serchConditionViewModel, userViewModels);
            return View("Index", viewModel);
        }
        #endregion

    }
}