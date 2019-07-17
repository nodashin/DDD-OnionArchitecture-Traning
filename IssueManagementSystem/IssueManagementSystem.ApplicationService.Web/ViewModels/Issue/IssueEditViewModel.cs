using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.ApplicationService.Web.ViewModels.Issue
{
    /// <summary>
    /// 課題編集ViewModel
    /// </summary>
    public class IssueEditViewModel : IssueViewModel
    {
        /// <summary>
        /// 課題ID
        /// </summary>
        [DisplayName("課題ID")]
        public int IsseuId { get; set; }

        
    }
}
