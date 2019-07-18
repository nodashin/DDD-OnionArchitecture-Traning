using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IssueManagementSystem.Web.Controllers
{
    /// <summary>
    /// ユーザーController
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// ユーザー一覧Viewを表示する。
        /// </summary>
        /// <returns>ユーザー一覧View</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}