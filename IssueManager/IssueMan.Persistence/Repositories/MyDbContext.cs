using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManager.Dmain.Auth;

namespace IssueMan.Persistence.Repositories
{
    /// <summary>
    /// DBコンテキスト
    /// </summary>
    public class MyDbContext : DbContext
    {
        /// <summary>
        /// ユーザー
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
