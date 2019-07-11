using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IssueManager.Web.ApplicationService.Attributes
{
    /// <summary>
    /// 必須属性
    /// </summary>
    public class MyRequiredAttribute : RequiredAttribute, IClientValidatable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MyRequiredAttribute():base()
        {
            ErrorMessage = "{0}を入力してください。";
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
            yield return new ModelClientValidationRequiredRule(errorMessage);
        }
    }
}
