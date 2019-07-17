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
        /// 全DomainModelを取得する。
        /// </summary>
        /// <returns>全DomainModel</returns>
        IQueryable<TDomainModel> FindAll();

        /// <summary>
        /// IDからDmainModelを取得する。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>DmainModel</returns>
        TDomainModel FindById(TId id);

        /// <summary>
        /// DomainModelを作成する。
        /// </summary>
        /// <param name="model">DomainModel</param>
        void Create(TDomainModel model);

        /// <summary>
        /// DmainModelを修正する。
        /// </summary>
        /// <param name="model">DmainModel</param>
        void Modify(TDomainModel model);
    }
}
