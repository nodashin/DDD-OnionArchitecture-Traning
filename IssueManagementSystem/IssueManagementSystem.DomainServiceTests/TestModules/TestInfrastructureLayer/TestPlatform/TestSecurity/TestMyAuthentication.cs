using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.DomainServiceTests.TestModules.TestInfrastructureLayer.TestPlatform.TestSecurity
{
    /// <summary>
    /// テスト用認証
    /// </summary>
    public class TestMyAuthentication : IMyAuthentication
    {
        /// <summary>
        /// 何もしない。
        /// </summary>
        /// <param name="userId">未使用</param>
        public void Authenticate(string userId)
        {
            
        }

        public void CancelAuthorization()
        {
            throw new NotImplementedException();
        }
    }
}
