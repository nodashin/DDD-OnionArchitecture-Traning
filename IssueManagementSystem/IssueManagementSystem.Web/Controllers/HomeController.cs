using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Home;

namespace IssueManagementSystem.Web.Controllers
{
    /// <summary>
    /// ホームController
    /// </summary>
    public class HomeController : Controller
    {
        #region ログイン
        /// <summary>
        /// ログインViewを表示数r。
        /// </summary>
        /// <param name="returnUrl">ログイン後のリダイレクトURL</param>
        /// <returns>ログインView</returns>
        public ActionResult Login(string returnUrl)
        {
            var viewModel = LoginViewModel.CreateByReturnUrl(returnUrl);
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