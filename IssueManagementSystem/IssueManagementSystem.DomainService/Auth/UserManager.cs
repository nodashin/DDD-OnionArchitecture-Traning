using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// ユーザーマネージャー
    /// </summary>
    public class UserManager : IUserManager
    {
        #region プロパティ
        /// <summary>
        /// ユーザーRepository
        /// </summary>
        public IUserRepository UserRepository { get; }

        /// <summary>
        /// ログインユーザーRepository
        /// </summary>
        public ILoginUserRepository LoginUserRepository { get; }

        /// <summary>
        /// パスワードハッシャー
        /// </summary>
        public IPasswordHasher PasswordHasher { get; }
        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userRepository">ユーザーRepository</param>
        /// <param name="loginUserRepository">ログインユーザーRepository</param>
        public UserManager(IUserRepository userRepository, ILoginUserRepository loginUserRepository, IPasswordHasher passwordHasher)
        {
            UserRepository = userRepository;
            LoginUserRepository = loginUserRepository;
            PasswordHasher = passwordHasher;
        }
        #endregion

        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="user">作成するユーザー</param>
        /// <param name="password">作成するユーザーのパスワード</param>
        public void Create(User user, string password)
        {
            user.HashPassword = PasswordHasher.HashPassword(password);
            UserRepository.Add(user);
        }

        /// <summary>
        /// ユーザーのパスワード以外を修正する。
        /// </summary>
        /// <param name="user">修正するユーザー(パスワードが入っていても現在のパスワードで上書きする)</param>
        public void EditWithoutPassword(User user)
        {
            user.HashPassword = UserRepository.FindById(user.UserId).HashPassword;
            UserRepository.Modify(user);
        }

        /// <summary>
        /// ユーザーを削除する。
        /// </summary>
        /// <param name="userId">削除するユーザーID</param>
        public void Delete(string userId)
        {
            if (LoginUserRepository.GetLoginUser().UserId == userId)
                throw new InvalidOperationException("ログイン中のユーザーは削除できません。");

            UserRepository.Remove(userId);
        }

        #endregion
    }
}
