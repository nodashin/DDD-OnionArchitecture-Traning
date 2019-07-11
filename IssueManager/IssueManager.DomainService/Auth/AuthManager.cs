using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManager.DomainService.Auth
{
    /// <summary>
    /// 認証マネージャー
    /// </summary>
    public class AuthManager : IAuthManager
    {
        /// <summary>
        /// ユーザーRepository
        /// </summary>
        private IUserRepository UserRepository { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userRepository">ユーザーRepository</param>
        public AuthManager(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        /// <summary>
        /// ログインする。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログイン可否</returns>
        public bool Login(string userId, string password)
        {
            //ユーザーIDが一致しているか判定する。
            if(!UserRepository.Exists(userId))
                return false;

            //パスワードが一致しているか判定する。
            if (!MatchPassword(password, userId))
                return false;



            return true;
        }

        /// <summary>
        /// パスワードがユーザーIDのユーザーと一致しているか確認する。
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <param name="userId">パスワードが一致しているか確認するユーザーのユーザーID</param>
        /// <returns>一致有無</returns>
        private bool MatchPassword(string password, string userId)
        {
            var user = UserRepository.FindById(userId);
            if (user == null)
                throw new ArgumentException("指定したユーザーIDのユーザーが存在しません。");

            var hashPassword = BCrypt.Net.BCrypt.HashPassword(password);

            return hashPassword == user.HashPassword;
        }
    }
}
