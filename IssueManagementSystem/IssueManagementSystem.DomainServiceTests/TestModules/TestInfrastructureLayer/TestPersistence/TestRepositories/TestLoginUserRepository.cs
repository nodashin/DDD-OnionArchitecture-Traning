using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructureLayer.TestPersistence.TestRepositories
{
    /// <summary>
    /// テスト用ログインユーザーRepository
    /// </summary>
    public class TestLoginUserRepository : ILoginUserRepository
    {
        public void ClearLoginUser()
        {
            throw new NotImplementedException();
        }

        public LoginUser GetLoginUser()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 何もしない。
        /// </summary>
        /// <param name="loginUser">未使用</param>
        public void SaveLoginUser(LoginUser loginUser)
        {
            
        }
    }
}
