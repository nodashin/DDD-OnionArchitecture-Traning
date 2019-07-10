using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace IssueManager.Web.Extensions
{
    /// <summary>
    /// Viewヘルパーの拡張メソッド
    /// </summary>
    public static class ViewHelperExtension
    {
        /// <summary>
        /// ValidationSummaryの結果を、BootstrapのAlert形式で出力する。
        /// </summary>
        /// <param name="htmlHelper">HTMLヘルパー</param>
        /// <returns>BootstrapのAlert形式のValidationSummary</returns>
        public static IHtmlString ValidationSummaryAlert(this HtmlHelper htmlHelper)
        {
            //ValidationSummaryのHTMLを取得する。
            var html = htmlHelper.ValidationSummary(true, "", new { @class = "alert alert-dismissible alert-danger" });
            if (html == null)
                return html;

            //表示するエラーが無い場合、HTMLは生成されるが「display:none」sytleが適用されている。
            //適用されるのは<li>のみで<div>には適用されず、エラーが無い場合でもアラート枠のみ表示されてしまう。
            //アラート枠を出さないため、アラートclassとHTMLから取り除く。
            //※ホントにこのやり方しかないの？他に良い方法がありそう。
            if (html.ToString().Contains("display:none"))
                return MvcHtmlString.Create(html.ToString().Replace("alert alert-dismissible alert-danger", ""));

            return html;
        }
    }
}