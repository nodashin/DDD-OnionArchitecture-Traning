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
    /// テスト用ユーザーRepository
    /// </summary>
    internal class TestUserRepository : IUserRepository
    {
        /// <summary>
        /// IDに「Test」を指定した場合のみユーザーを返す。
        /// </summary>
        /// <param name="id">「Test」指定時のみユーザーを返す。</param>
        /// <returns>IDに「Test」指定時のみユーザー、それ以外指定時はnullを返す。</returns>
        public User FindById(string id)
        {
            if (id != "Test")
                return null;

            return new User()
            {
                UserId = id,
                HashPassword = "Test",
                FirstName = "Lennon",
                LastName = "McCartney"
            };
        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="model">未使用</param>
        public void Add(User model)
        {

        }

        /// <summary>
        /// 何もしない。
        /// </summary>
        /// <param name="model">未使用</param>
        public void Modify(User model)
        {

        }

        /// <summary>
        /// 何もしない
        /// </summary>
        /// <param name="model">未使用</param>
        public void Remove(string id)
        {

        }

        public IQueryable<User> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
