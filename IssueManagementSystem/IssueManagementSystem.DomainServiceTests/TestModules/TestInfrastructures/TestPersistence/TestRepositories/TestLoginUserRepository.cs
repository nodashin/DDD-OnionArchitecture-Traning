using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructures.TestPersistence.TestRepositories
{
    /// <summary>
    /// テスト用ログインユーザーRepository
    /// </summary>
    internal class TestLoginUserRepository : ILoginUserRepository
    {
        /// <summary>
        /// ログインユーザーをストアではなくRepository内で管理する。
        /// </summary>
        private static LoginUser LoginUser { get; set; }

        /// <summary>
        /// ログインユーザーを設定する。
        /// </summary>
        /// <param name="loginUser">ログインユーザー</param>
        public void SaveLoginUser(LoginUser loginUser)
        {
            LoginUser = loginUser;
        }

        /// <summary>
        /// ログインユーザーを取得する。
        /// </summary>
        /// <returns>ログインユーザー</returns>
        public LoginUser GetLoginUser()
        {
            return LoginUser;
        }

        public void ClearLoginUser()
        {
            throw new NotImplementedException();
        }
    }
}
