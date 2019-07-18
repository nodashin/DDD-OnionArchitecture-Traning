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
        /// ログインユーザーID
        /// </summary>
        public string UserId { get => User?.UserId; }

        /// <summary>
        /// ログインユーザー名
        /// </summary>
        public string UserName { get => User?.GetUserName(); }

        /// <summary>
        /// ユーザー
        /// </summary>
        private User User { get; }
        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="user">ログインしたユーザー</param>
        private LoginUser(User user)
        {
            User = user;
        }
        #endregion

        #region Factory
        /// <summary>
        /// ユーザーからログインユーザーを生成する。
        /// </summary>
        /// <param name="user">ログインしたユーザー</param>
        /// <returns>ログインユーザー</returns>
        public static LoginUser CreateByUser(User user)
            => new LoginUser(user);
        #endregion

        #endregion
    }
}
