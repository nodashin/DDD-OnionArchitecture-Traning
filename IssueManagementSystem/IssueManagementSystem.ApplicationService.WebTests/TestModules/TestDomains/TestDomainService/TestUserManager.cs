using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService
{
    /// <summary>
    /// テスト用ユーザーマネージャー
    /// </summary>
    internal class TestUserManager : IUserManager
    {
        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="user">未使用</param>
        public void Create(User user)
        {
            
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="user">未使用</param>
        public void Delete(string userId)
        {
            
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="user">未使用</param>
        public void EditWithoutPassword(User user)
        {
            
        }
    }
}
