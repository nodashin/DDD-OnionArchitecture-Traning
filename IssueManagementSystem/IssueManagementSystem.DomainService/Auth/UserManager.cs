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
        #endregion

        #region プロパティ

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userRepository">ユーザーRepository</param>
        /// <param name="loginUserRepository">ログインユーザーRepository</param>
        public UserManager(IUserRepository userRepository, ILoginUserRepository loginUserRepository)
        {
            UserRepository = userRepository;
            LoginUserRepository = loginUserRepository;
        }
        #endregion

        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="user">作成するユーザー</param>
        public void Create(User user)
        {
            UserRepository.Add(user);
        }

        /// <summary>
        /// ユーザーのパスワード以外を修正する。
        /// </summary>
        /// <param name="user">修正するユーザー(パスワードが入っていても現在のパスワードで上書きする)</param>
        public void EditWithoutPassword(User user)
        {
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
