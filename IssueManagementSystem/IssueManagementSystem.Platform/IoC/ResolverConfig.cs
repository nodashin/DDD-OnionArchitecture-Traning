﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using IssueManagementSystem.ApplicationService.Web.Services;
using IssueManagementSystem.DomainService.Auth;
using IssueManagementSystem.Persistence.Repositories;
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

            //DomainService
            kernel.Bind<IAuthManager>().To<AuthManager>();

            //Repository
            kernel.Bind<IUserRepository>().To<UserRepository>();

            DependencyResolver.SetResolver(new MyDependencyResolver(kernel));
        }
    }
}