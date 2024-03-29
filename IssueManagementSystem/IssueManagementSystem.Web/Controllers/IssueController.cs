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
        /// 課題を検索する。
        /// </summary>
        /// <param name="searchConditionViewModel">課題一覧 - 検索条件ViewModel</param>
        /// <returns>課題一覧View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(IssueIndexSearchConditionViewModel searchConditionViewModel)
        {
            var issueViewModels = IssueApplicationService.Search(searchConditionViewModel);
            var viewModel = IssueIndexViewModel.CreateByChildViewModels(searchConditionViewModel, issueViewModels);
            
            return View("Index", viewModel);
        }
        #endregion

        #region 課題作成
        /// <summary>
        /// 課題作成Viewを表示する。
        /// </summary>
        /// <returns>課題作成View</returns>
        public ActionResult Create()
        {
            return View(new IssueCreateViewModel());
        }

        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="viewModel">課題作成ViewModel</param>
        /// <returns>課題一覧ViewModel</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IssueCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            IssueApplicationService.Create(viewModel);

            return RedirectToAction("Index");
        }
        #endregion

        #region 課題編集・削除
        /// <summary>
        /// 課題編集Viewを表示する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns>課題編集View</returns>
        public ActionResult Edit(int issueId)
        {
            return View(IssueApplicationService.GetIssueEditViewModel(issueId));
        }

        /// <summary>
        /// 課題を編集する。
        /// </summary>
        /// <param name="viewModel">課題編集ViewModel</param>
        /// <returns>課題一覧View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IssueEditViewModel viewModel)
        {
            IssueApplicationService.Edit(viewModel);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 課題を削除する。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns>課題一覧View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int issueId)
        {
            IssueApplicationService.Delete(issueId);
            return RedirectToAction("Index");
        }
        #endregion
    }
}