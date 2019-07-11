using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManager.Web.ApplicationService.Services;
using IssueManager.Web.ApplicationService.ViewModels.Home;

namespace IssueManager.Web.Controllers
{
    /// <summary>
    /// ホームController
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// ホームサービス
        /// </summary>
        private IHomeControllerService HomeService { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="homeService">ホームサービス</param>
        public HomeController(IHomeControllerService homeService)
        {
            HomeService = homeService;
        }

        #region ログイン
        /// <summary>
        /// ログインViewを表示する。
        /// </summary>
        /// <param name="returnUrl">ログイン後にリダイレクトするURL</param>
        /// <returns>ログインView</returns>
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            var viewModel = LoginViewModel.CreateByReturnUrl(returnUrl);
            return View(viewModel);
        }

        /// <summary>
        /// ログインし、課題一覧View(リダイレクトURLが指定されている場合はそちらのView)を表示する。
        /// </summary>
        /// <param name="viewModel">ログインViewModel</param>
        /// <returns>課題一覧View(リダイレクトURLが指定されている場合はそちらのView)</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
                return View(viewModel);

            //ログイン可能か判定する。
            if (!HomeService.Login(viewModel))
            {
                this.ModelState.AddModelError("", "ユーザー名かパスワードが誤っています。");
                return View(viewModel);
            }

            //ログイン後のViewへリダイレクトする。
            if (Url.IsLocalUrl(viewModel.ReturnUrl))
                return Redirect(viewModel.ReturnUrl);

            return View("Index");
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