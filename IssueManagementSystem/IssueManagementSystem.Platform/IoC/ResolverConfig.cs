﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using IssueManagementSystem.DomainService.Auth;
using IssueManagementSystem.DomainService.Issue;
using IssueManagementSystem.Persistence.Repositories;
using IssueManagementSystem.Platform.Security;
using IssueManagementSystem.Platform.Security.Authentications;
using Ninject;

namespace IssueManagementSystem.Platform.IoC
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
            kernel.Bind<IIssueApplicationService>().To<IssueApplicationService>();
            kernel.Bind<IUserApplicationService>().To<UserApplicationService>();

            //DomainService
            kernel.Bind<IAuthManager>().To<AuthManager>();
            kernel.Bind<IUserManager>().To<UserManager>();
            kernel.Bind<IIssueManager>().To<IssueManager>();

            //Repository
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<ILoginUserRepository>().To<LoginUserRepository>();
            kernel.Bind<IIssueRepository>().To<IssueRepository>();

            //Platform
            kernel.Bind<IPasswordHasher>().To<PasswordHasher>();
            kernel.Bind<IMyAuthentication>().To<MyFormAuthentication>();

            DependencyResolver.SetResolver(new MyDependencyResolver(kernel));
        }
    }
}
