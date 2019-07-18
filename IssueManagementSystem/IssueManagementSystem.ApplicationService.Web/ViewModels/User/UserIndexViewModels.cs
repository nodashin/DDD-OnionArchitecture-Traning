using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.Commons;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.User
{
    #region ユーザー一覧ViewModel
    public class UserIndexViewModel
    {
        #region プロパティ
        /// <summary>
        /// 検索条件
        /// </summary>
        public UserIndexSerchConditionViewModel SerchCondition { get; set; }

        /// <summary>
        /// ユーザー群
        /// </summary>
        /// <remarks>
        /// データが0件でもnullにはならず、Countが0の状態となる。
        /// </remarks>
        public List<UserIndexUserViewModel> Users { get; set; }
        #endregion
    }
    #endregion

    #region ユーザー一覧 - 検索条件ViewModel
    /// <summary>
    /// ユーザー一覧 - 検索条件ViewModel
    /// </summary>
    public class UserIndexSerchConditionViewModel : SearchConditionViewModel
    {
        //TODO:後でなにか入れよう。
    }
    #endregion

    #region ユーザー一覧 - ユーザーViewModel
    /// <summary>
    /// ユーザー一覧 - ユーザーViewModel
    /// </summary>
    public class UserIndexUserViewModel
    {
        #region プロパティ
        /// <summary>
        /// ユーザーID
        /// </summary>
        [DisplayName("ユーザーID")]
        public string UserId { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        [DisplayName("ユーザー名")]
        public string UserName { get; set; }
        #endregion
    }
    #endregion
}
