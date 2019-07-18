using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Commons;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// ユーザーRepositoryインタフェース
    /// </summary>
    public interface IUserRepository : IRepository<User, string>
    {
    }
}
