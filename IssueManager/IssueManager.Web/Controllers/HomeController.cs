using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManager.Web.ApplicationService.ViewModels.Home;

namespace IssueManager.Web.Controllers
{
    /// <summary>
    /// ホームController
    /// </summary>
    public class HomeController : Controller
    {
        #region ログイン
        /// <summary>
        /// ログインViewを表示する。
        /// </summary>
        /// <param name="returnUrl">ログイン後にリダイレクトするURL</param>
        /// <returns>ログインView</returns>
        public ActionResult Login(string returnUrl)
        {
            var viewMode = LoginViewModel.CreateByReturnUrl(returnUrl);
            return View(viewMode);
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