using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using Ninject;

namespace IssueManagementSystem.Persistence.IoC
{
    /// <summary>
    /// リゾルバー設定
    /// </summary>
    public class ResolverConfig
    {
        /// <summary>
        /// リゾルバー設定
        /// </summary>
        public static void RegisterResolvers()
        {
            var kernel = new StandardKernel();

            //ApplicationService
            kernel.Bind<IHomeApplicationService>().To<HomeApplicationService>();

            DependencyResolver.SetResolver(new MyDependencyResolver(kernel));
        }
    }
}
