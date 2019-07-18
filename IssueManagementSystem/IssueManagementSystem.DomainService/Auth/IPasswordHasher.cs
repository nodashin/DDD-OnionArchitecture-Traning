using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// パスワードハッシャーインタフェース
    /// </summary>
    public interface IPasswordHasher
    {
        /// <summary>
        /// パスワードをハッシュ化する。
        /// </summary>
        /// <param name="password">ハッシュ化するパスワード</param>
        /// <returns>ハッシュ化パスワード</returns>
        string HashPassword(string password);

        /// <summary>
        /// パスワードが一致するか判定する。
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <param name="hashPassword">ハッシュパスワード</param>
        /// <returns>一致有無</returns>
        bool MatchPassword(string password, string hashPassword);
    }
}
