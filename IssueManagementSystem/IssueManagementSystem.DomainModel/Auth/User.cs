using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Auth
{
    /// <summary>
    /// ユーザー
    /// </summary>
    public class User
    {
        #region プロパティ
        /// <summary>
        /// ユーザーID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        [Required]
        public string HashPassword { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ(EF用)
        /// </summary>
        public User() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="lastName">名字</param>
        /// <param name="firstName">名前</param>
        private User(string userId, string lastName, string firstName)
        {
            UserId = userId;
            LastName = lastName;
            FirstName = firstName;
        }
        #endregion

        /// <summary>
        /// ユーザー名を取得する。
        /// </summary>
        /// <returns>ユーザー名</returns>
        public string GetUserName()
            => LastName + " " + FirstName;

        #region Factories
        /// <summary>
        /// 詳細情報からユーザーを作成する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="lastName">名字</param>
        /// <param name="firstName">名前</param>
        /// <returns>ユーザー</returns>
        public static User CreateByDetailInfo(string userId, string lastName, string firstName)
            => new User(userId, lastName, firstName);
        #endregion

        #endregion
    }
}
