using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// パスワード変更結果
    /// </summary>
    public enum PasswordChangeResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success,

        /// <summary>
        /// パスワード違い
        /// </summary>
        PasswordDifference
    }
}
