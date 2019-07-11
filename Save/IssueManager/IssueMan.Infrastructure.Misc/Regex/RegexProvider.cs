using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMan.Infrastructure.Regex
{
    /// <summary>
    /// 正規表現プロパイダー
    /// </summary>
    public static class RegexProvider
    {
        /// <summary>
        /// 半角英数字のみの正規表現
        /// </summary>
        public static string OnlyHalfwidthAlphanumeric { get => "[0-9a-zA-Z]*"; }
    }
}
