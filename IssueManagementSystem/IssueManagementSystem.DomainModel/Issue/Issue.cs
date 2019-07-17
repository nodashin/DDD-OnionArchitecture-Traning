using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Issue
{
    /// <summary>
    /// 課題
    /// </summary>
    public class Issue
    {
        #region プロパティ
        /// <summary>
        /// 課題ID
        /// </summary>
        public int IssueId { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        #endregion

        #region メソッド

        #region コンストラクタ
        /// <summary>
        /// EF用コンストラクタ
        /// </summary>
        public Issue()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="content">内容</param>
        private Issue(string title, string content)
        {
            Title = title;
            Content = content;
        }
        #endregion

        #region Factories
        /// <summary>
        /// 詳細情報から課題を作成する。
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="content">内容</param>
        /// <returns>課題</returns>
        public static Issue CreateByDetails(string title, string content)
            => new Issue(title, content);
        #endregion

        #endregion
    }
}
