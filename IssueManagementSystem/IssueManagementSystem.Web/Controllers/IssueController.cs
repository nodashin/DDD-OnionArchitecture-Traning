﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Issue;

namespace IssueManagementSystem.Web.Controllers
{
    /// <summary>
    /// 課題Controller
    /// </summary>
    public class IssueController : Controller
    {
        /// <summary>
        /// 課題ApplicationService
        /// </summary>
        private IIssueApplicationService IssueApplicationService { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueApplicationService">課題ApplicationService</param>
        public IssueController(IIssueApplicationService issueApplicationService)
        {
            IssueApplicationService = issueApplicationService;
        }

        #region 課題一覧
        /// <summary>
        /// 課題一覧Viewを表示する。
        /// </summary>
        /// <returns>課題一覧View</returns>
        public ActionResult Index()
        {
            return Search(new IssueIndexSearchConditionViewModel());
        }

        /// <summary>
        /// 検索する。
        /// </summary>
        /// <returns>課題一覧View</returns>
        public ActionResult Search(IssueIndexSearchConditionViewModel searchConditionViewModel)
        {
            var issueViewModels = IssueApplicationService.Search(searchConditionViewModel);
            var viewModel = IssueIndexViewModel.CreateByChildViewModels(searchConditionViewModel, issueViewModels);
            
            return View("Index", viewModel);
        }
        #endregion
    }
}