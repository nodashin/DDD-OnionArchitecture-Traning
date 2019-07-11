using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using IssueMan.Infrastructure.Regex;

namespace IssueManager.Web.ApplicationService.Attributes
{
    /// <summary>
    /// 半角英数字のみ許容する検証属性
    /// </summary>
    public class OnlyHalfwidthAlphanumericAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OnlyHalfwidthAlphanumericAttribute() : base(RegexProvider.OnlyHalfwidthAlphanumeric)
        {
            ErrorMessage = "{0}は半角英数字で入力してください。";
        }

        /// <summary>
        /// クライアントサイドの検証ルールを取得する。
        /// </summary>
        /// <param name="metadata">Modelのメタデータ</param>
        /// <param name="context">Controllerのコンテキスト</param>
        /// <returns>検証ルール</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var errorMessage = this.FormatErrorMessage(metadata.GetDisplayName());
            yield return new ModelClientValidationRegexRule(errorMessage, this.Pattern);
        }
    }
}
