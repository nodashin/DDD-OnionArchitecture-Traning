using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;

namespace IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories
{
    /// <summary>
    /// テスト用ユーザーRepository
    /// </summary>
    internal class TestUserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public User FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(User model)
        {
            throw new NotImplementedException();
        }

        public void Modify(User model)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
