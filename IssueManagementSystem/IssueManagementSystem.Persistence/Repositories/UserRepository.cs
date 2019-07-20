using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public IEnumerable<User> FindAll()
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
        /// ユーザーを追加する。
        /// </summary>
        /// <param name="user">追加するユーザー</param>
        public void Add(User user)
        {
            Db.Users.Add(user);
            Db.SaveChanges();
        }

        /// <summary>
        /// ユーザーを修正する。
        /// </summary>
        /// <param name="user">修正するユーザー</param>
        public void Modify(User user)
        {
            var origin = FindById(user.UserId);
            origin.HashPassword = user.HashPassword;
            origin.LastName = user.LastName;
            origin.FirstName = user.FirstName;

            Db.Entry(origin).State = EntityState.Modified;
            Db.SaveChanges();
        }

        /// <summary>
        /// ユーザーを削除する。
        /// </summary>
        /// <param name="userId">削除するユーザーID</param>
        public void Remove(string userId)
        {
            var user = FindById(userId);
            Db.Users.Remove(user);
            Db.SaveChanges();
        }
        #endregion
    }
}
