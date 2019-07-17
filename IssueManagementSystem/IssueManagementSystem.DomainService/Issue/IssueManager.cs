﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Issue;

namespace IssueManagementSystem.DomainService.Issue
{
    /// <summary>
    /// 課題マネージャー
    /// </summary>
    public class IssueManager : IIssueManager
    {
        /// <summary>
        /// 課題Repository
        /// </summary>
        private IIssueRepository IssueRepository { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueRepository">課題Repository</param>
        public IssueManager(IIssueRepository issueRepository)
        {
            IssueRepository = issueRepository;
        }

        /// <summary>
        /// 課題を作成する。
        /// </summary>
        /// <param name="issue">作成する課題</param>
        public void Create(DomainModel.Issue.Issue issue)
        {
            IssueRepository.Create(issue);
        }
    }
}
