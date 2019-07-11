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
        /// ユーザーID
        /// </summary>
        public string UserId { get => User.UserId; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        public string UserName { get => User.GetUserName(); }

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
        LoginUser(User user)
        {
            User = user;
        }

        /// <summary>
        /// ログインしたユーザーを元にログインユーザーを生成する。
        /// </summary>
        /// <param name="user">ログインしたユーザー</param>
        /// <returns>ログインユーザー</returns>
        public static LoginUser CreateByUser(User user)
            => new LoginUser(user);
        #endregion
    }
}
