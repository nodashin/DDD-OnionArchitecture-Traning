using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;

namespace IssueManagementSystem.Web.Controllers
{
    /// <summary>
    /// ホームController
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// ホームApplicationService
        /// </summary>
        private IHomeApplicationService HomeApplicationService { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="homeApplicationService">ホームApplicationService</param>
        public HomeController(IHomeApplicationService homeApplicationService)
        {
            HomeApplicationService = homeApplicationService;
        }

        #region ログイン
        /// <summary>
        /// ログインViewを表示数r。
        /// </summary>
        /// <param name="returnUrl">ログイン後のリダイレクトURL</param>
        /// <returns>ログインView</returns>
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            var viewModel = LoginViewModel.CreateByReturnUrl(returnUrl);
            return View(viewModel);
        }

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>課題一覧View(リダイレクト先が指定されている場合はリダイレクト先View)</returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include ="UserId,Password,ReturnUrl")]LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            if(!HomeApplicationService.Login(viewModel))
            {
                ModelState.AddModelError("", "ユーザーIDかパスワードが誤っています。");
                return View(viewModel);
            }

            if (Url.IsLocalUrl(viewModel.ReturnUrl))
                return Redirect(viewModel.ReturnUrl);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// ログイン後メニューViewを表示する。
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        [AllowAnonymous]
        public ActionResult LoggedInMenu()
        {
            var viewModel = HomeApplicationService.GetLoggedInMenuViewModel();
            return PartialView("_LoggedInMenu", viewModel);
        }
        #endregion

        #region あとで消す
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}