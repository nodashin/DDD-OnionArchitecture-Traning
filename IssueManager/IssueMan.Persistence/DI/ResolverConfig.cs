using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using IssueMan.Persistence.Repositories;
using IssueManager.DomainService.Auth;
using IssueManager.Web.ApplicationService.Services;
using Ninject;

namespace IssueMan.Persistence.DI
{
    /// <summary>
    /// リゾルバー設定
    /// </summary>
    public class ResolverConfig
    {
        /// <summary>
        /// リゾルバーを登録する。
        /// </summary>
        public static void RegisterResolvers()
        {
            var kernel = new StandardKernel();

            //ApplicationServices.
            kernel.Bind<IHomeControllerService>().To<HomeControllerService>();

            //DomainServices.
            kernel.Bind<IAuthManager>().To<AuthManager>();

            //Repositories
            kernel.Bind<IUserRepository>().To<UserRepository>();

            DependencyResolver.SetResolver(new MyDependencyResolver(kernel));
        }
    }
}
