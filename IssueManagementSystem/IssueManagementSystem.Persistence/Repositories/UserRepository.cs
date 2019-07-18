using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainService.Auth;
using IssueManagementSystem.Persistence.DataBaseContext;

namespace IssueManagementSystem.Persistence.Repositories
{
    /// <summary>
    /// ユーザーRepository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        #region プロパティ
        /// <summary>
        /// データベース
        /// </summary>
        private readonly MyDataBase Db = new MyDataBase();
        #endregion

        #region メソッド
        /// <summary>
        /// 全ユーザーを取得する。
        /// </summary>
        /// <returns>全ユーザー</returns>
        public IQueryable<User> FindAll()
        {
            return Db.Users;
        }

        /// <summary>
        /// ユーザーIDからユーザーを取得する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザー</returns>
        public User FindById(string userId)
        {
            return FindAll().SingleOrDefault(u => u.UserId == userId);
        }

        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="user">ユーザー</param>
        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ユーザーを修正する。
        /// </summary>
        /// <param name="user">修正するユーザー</param>
        public void Modify(User user)
        {
            Db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
