using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.Platform.Security
{
    /// <summary>
    /// パスワードハッシュ
    /// </summary>
    public class PasswordHasher : IPasswordHasher
    {
        /// <summary>
        /// パスワードをハッシュ化する。
        /// </summary>
        /// <param name="password">ハッシュ化するパスワード</param>
        /// <returns>ハッシュ化パスワード</returns>
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// パスワードが一致するか判定する。
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <param name="hashPassword">ハッシュパスワード</param>
        /// <returns>一致有無</returns>
        public bool MatchPassword(string password, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }
    }
}
