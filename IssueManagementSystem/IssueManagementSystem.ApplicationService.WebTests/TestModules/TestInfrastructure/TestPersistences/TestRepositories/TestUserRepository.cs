﻿using System;
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
        /// <summary>
        /// テスト用ユーザーを返す。
        /// </summary>
        /// <returns>テスト用ユーザー</returns>
        public IEnumerable<User> FindAll()
        {
            for (int i = 1; i <= 5; i++)
            {
                var user = new User()
                {
                    UserId = "UserId" + i.ToString(),
                    HashPassword = "HashPassword" + i.ToString(),
                    LastName = "LastName" + i.ToString(),
                    FirstName = "FirstName" + i.ToString()
                };
                yield return user;
            }
        }

        /// <summary>
        /// テスト用ユーザーを返す。
        /// </summary>
        /// <param name="id">ユーザーID。「Test」指定時にテスト用ユーザーを返す。</param>
        /// <returns>ユーザーIDに「Test」を指定した場合はテストユーザー、それ以外はNULLを返す。</returns>
        public User FindById(string id)
        {
            if (id != "Test")
                return null;

            return new User()
            {
                UserId = id,
                HashPassword = "HashPassword",
                LastName = "LastName",
                FirstName = "FirstName"
            };
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
