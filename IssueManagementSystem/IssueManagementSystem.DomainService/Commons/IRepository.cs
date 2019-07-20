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
        #region メソッド
        /// <summary>
        /// 全DomainModelを取得する。
        /// </summary>
        /// <returns>全DomainModel</returns>
        IEnumerable<TDomainModel> FindAll();

        /// <summary>
        /// IDからDmainModelを取得する。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>DmainModel</returns>
        TDomainModel FindById(TId id);

        /// <summary>
        /// DomainModelを追加する。
        /// </summary>
        /// <param name="model">追加するDomainModel</param>
        void Add(TDomainModel model);

        /// <summary>
        /// DmainModelを修正する。
        /// </summary>
        /// <param name="model">修正するDmainModel</param>
        void Modify(TDomainModel model);

        /// <summary>
        /// DomainModelを削除する。
        /// </summary>
        /// <param name="id">削除するDomainModelのID</param>
        void Remove(TId id);
        #endregion
    }
}
