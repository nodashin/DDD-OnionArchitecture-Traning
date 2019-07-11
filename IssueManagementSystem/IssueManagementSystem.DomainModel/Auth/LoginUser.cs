using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Auth
{
    /// <summary>
    /// ログインユーザー
    /// </summary>
    public class LoginUser
    {
        #region プロパティ
        /// <summary>
        /// ログインしているか。
        /// </summary>
        public bool IsLoggedIn { get => User != null; }

        /// <summary>
        /// ログインユーザーID
        /// </summary>
        public string UserId { get => User?.UserId; }

        /// <summary>
        /// ログインユーザー名
        /// </summary>
        public string UserName { get => GetLoginUserName(); }

        /// <summary>
        /// ユーザー
        /// </summary>
        private User User { get; }
        #endregion

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="user">ログインしたユーザー</param>
        private LoginUser(User user)
        {
            User = user;
        }

        /// <summary>
        /// ログインユーザー名を取得する。
        /// </summary>
        /// <returns>ログインユーザー名</returns>
        private string GetLoginUserName()
        {
            if (User == null)
                return null;

            return User.LastName + " " + User.FirstName;
        }

        /// <summary>
        /// ユーザーからログインユーザーを生成する。
        /// </summary>
        /// <param name="user">ログインしたユーザー</param>
        /// <returns>ログインユーザー</returns>
        public static LoginUser CreateByUser(User user)
            => new LoginUser(user);
        #endregion
    }
}
