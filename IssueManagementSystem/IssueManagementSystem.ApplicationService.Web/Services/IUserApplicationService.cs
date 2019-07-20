using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.Web.ViewModels.User;

namespace IssueManagementSystem.ApplicationService.Web.Services
{
    /// <summary>
    /// ユーザーApplicationServiceインタフェース
    /// </summary>
    public interface IUserApplicationService
    {
        List<UserIndexUserViewModel> Search(UserIndexSerchConditionViewModel SerchConditionViewModel);
    }
}
