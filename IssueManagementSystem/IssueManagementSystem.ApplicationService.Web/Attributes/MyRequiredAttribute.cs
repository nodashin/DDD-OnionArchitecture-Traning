using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IssueManagementSystem.ApplicationService.Web.Attributes
{
    /// <summary>
    /// 必須属性
    /// </summary>
    internal class MyRequiredAttribute : RequiredAttribute, IClientValidatable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MyRequiredAttribute() : base()
        {
            ErrorMessage = "{0}を入力してください。";
        }

        /// <summary>
        /// 検証ルールを取得する。
        /// </summary>
        /// <param name="metadata">Modelのメタデータ</param>
        /// <param name="context">Controllerのコンテキスト</param>
        /// <returns>検証ルール</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRequiredRule(FormatErrorMessage(metadata.GetDisplayName()));
        }
    }
}
