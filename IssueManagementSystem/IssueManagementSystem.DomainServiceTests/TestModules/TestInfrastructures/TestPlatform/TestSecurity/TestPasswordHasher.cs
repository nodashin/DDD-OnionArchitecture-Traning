using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructures.TestPlatform.TestSecurity
{
    /// <summary>
    /// テスト用パスワードハッシャー
    /// </summary>
    public class TestPasswordHasher : IPasswordHasher
    {
        /// <summary>
        /// ハッシュ化せずパスワードをそのまま返す。
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <returns>引数に指定したパスワード</returns>
        public string HashPassword(string password)
        {
            return password;
        }

        /// <summary>
        /// パスワードが「Test」の場合はTrue、それ以外はFalseを返す。
        /// </summary>
        /// <param name="password">「Test」の場合はTrue、それ以外はFalseを返す</param>
        /// <param name="hashPassword">未使用</param>
        /// <returns>パスワードが「Test」の場合はTrue、それ以外はFalseを返す。</returns>
        public bool MatchPassword(string password, string hashPassword)
        {
            return password == "Test";
        }
    }
}
