using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// ログイン結果
    /// </summary>
    public enum LoginResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success,

        /// <summary>
        /// ユーザーID違い
        /// </summary>
        UserIdDifference,

        /// <summary>
        /// パスワード違い
        /// </summary>
        PasswordDifference
    }
}
