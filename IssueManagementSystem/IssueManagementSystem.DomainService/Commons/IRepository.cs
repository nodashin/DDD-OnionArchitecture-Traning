using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainService.Commons
{
    /// <summary>
    /// Repositoryインタフェース
    /// </summary>
    /// <typeparam name="TDomainModel">取り扱うDmainModelの型</typeparam>
    /// <typeparam name="TId">DomainModelのIDの型</typeparam>
    public interface IRepository<TDomainModel, TId>
    {
        /// <summary>
        /// IDからドメインモデルを取得する。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>ドメインモデル</returns>
        TDomainModel FindById(TId id);
    }
}
