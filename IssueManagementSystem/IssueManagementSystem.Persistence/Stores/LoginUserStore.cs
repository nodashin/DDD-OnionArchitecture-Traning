using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.Persistence.Stores
{
    /// <summary>
    /// ログインユーザーStore
    /// </summary>
    internal static class LoginUserStore
    {
        /// <summary>
        /// ログインユーザー
        /// </summary>
        public static LoginUser LoginUser { get; set; }
    }
}
