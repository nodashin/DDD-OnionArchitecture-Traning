using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;

namespace IssueManagementSystem.DomainService.Auth
{
    /// <summary>
    /// ユーザーマネージャーインタフェース
    /// </summary>
    public interface IUserManager
    {
        #region メソッド
        /// <summary>
        /// ユーザーを作成する。
        /// </summary>
        /// <param name="user">作成するユーザー</param>
        void Create(User user);

        /// <summary>
        /// ユーザーのパスワード以外を修正する。
        /// </summary>
        /// <param name="user">修正するユーザー(パスワードが入っていても現在のパスワードで上書きする)</param>
        void EditWithoutPassword(User user);

        /// <summary>
        /// ユーザーを削除する。
        /// </summary>
        /// <param name="userId">削除するユーザーID</param>
        void Delete(string userId);
        #endregion

    }
}