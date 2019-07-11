using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ninject;

namespace IssueManagementSystem.Platform.IoC
{
    /// <summary>
    /// 依存性リゾルバー
    /// </summary>
    public class MyDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// カーネル
        /// </summary>
        private IKernel Kernel { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="kernel">カーネル</param>
        public MyDependencyResolver(IKernel kernel)
        {
            Kernel = kernel;
        }

        /// <summary>
        /// 単一のサービスを解決する。
        /// </summary>
        /// <param name="serviceType">サービスの型</param>
        /// <returns>サービス</returns>
        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        /// <summary>
        /// 複数のサービスを解決する。
        /// </summary>
        /// <param name="serviceType">サービスの型</param>
        /// <returns>サービス群</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }
    }
}
