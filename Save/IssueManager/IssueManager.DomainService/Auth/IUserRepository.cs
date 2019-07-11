using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.Dmain.Auth;

namespace IssueManager.DomainService.Auth
{
    /// <summary>
    /// ユーザーRepositoryインタフェース
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// ユーザーIDからユーザーを取得する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>ユーザー</returns>
        User FindById(string userId);

        /// <summary>
        ///指定したユーザーIDのユーザーが存在するか確認する。
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <returns>存在有無</returns>
        bool Exists(string userId);
    }
}
