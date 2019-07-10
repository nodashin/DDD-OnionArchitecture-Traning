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

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HomeController() : this(new HomeControllerService())
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="homeService">ホームサービス</param>
        public HomeController(IHomeControllerService homeService)
        {
            HomeService = homeService;
        }
        #endregion

        #region ログイン
        /// <summary>
        /// ログインViewを表示する。
        /// </summary>
        /// <param name="returnUrl">ログイン後にリダイレクトするURL</param>
        /// <returns>ログインView</returns>
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
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
                return View(viewModel);

            //ログイン可能か判定する。
            if(!HomeService.Login(viewModel))
            {
                this.ModelState.AddModelError("", "ユーザー名かパスワードが誤っています。");
                return View(viewModel);
            }

            return View(viewModel);
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