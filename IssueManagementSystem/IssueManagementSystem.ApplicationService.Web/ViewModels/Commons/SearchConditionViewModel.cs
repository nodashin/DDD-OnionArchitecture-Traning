using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Commons
{
    /// <summary>
    /// 検索条件ViewModel
    /// </summary>
    /// <remarks>
    /// 全ての検索条件で共通なる項目を定義する。
    /// ただし画面に表示させる項目は定義しない。
    /// </remarks>
    public class SearchConditionViewModel
    {
        /// <summary>
        /// ページ番号
        /// </summary>
        /// <remarks>1～</remarks>
        public int PageNumner { get; set; } = 1;

        /// <summary>
        /// ページサイズ
        /// </summary>
        public int PageSize { get; set; } = 10;
    }
}
