using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.DomainModel.Auth;
using IssueManagementSystem.DomainModel.Issue;

namespace IssueManagementSystem.Persistence.DataBaseContext
{
    /// <summary>
    /// DB
    /// </summary>
    internal class MyDataBase : DbContext
    {
        #region DomainModels
        /// <summary>
        /// ユーザー
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// 課題
        /// </summary>
        public DbSet<Issue> Issues { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 初期データを投入する。
        /// </remarks>
        public MyDataBase()
        {
            Database.SetInitializer(new MyDataBaseInitializer());
        }
        #endregion
    }
}
