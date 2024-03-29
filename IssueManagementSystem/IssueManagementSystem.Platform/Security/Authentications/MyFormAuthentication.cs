﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.Platform.Security.Authentications
{
    /// <summary>
    /// Form認証
    /// </summary>
    public class MyFormAuthentication : IMyAuthentication
    {
        #region メソッド
        /// <summary>
        /// 認証する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        public void Authenticate(string userId)
        {
            FormsAuthentication.SetAuthCookie(userId, false);
        }

        /// <summary>
        /// 認証を解除する。
        /// </summary>
        public void CancelAuthorization()
        {
            FormsAuthentication.SignOut();
        }
        #endregion
    }
}
