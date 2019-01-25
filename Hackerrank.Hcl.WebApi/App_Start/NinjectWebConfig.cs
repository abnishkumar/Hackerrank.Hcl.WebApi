using Hackerrank.Hcl.WebApi.Controllers;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Web.Http;
using System.Web.Mvc;

namespace Hackerrank.Hcl.WebApi.App_Start
{
   internal class NinjectConfig
        {
            #region Private Fields

            /// <summary>
            /// The kernel
            /// </summary>
            private IKernel _kernel;

            #endregion Private Fields

            #region Internal Methods

            internal void ConfigureNinjectKernel(IAppBuilder app)
            {
                _kernel = Configuration.CreateDependencyGraph;

                app.UseNinjectMiddleware(() => _kernel);

                ControllerBuilder.Current.SetControllerFactory(new InjectorControllerFactory(_kernel));
            }

            internal void ConfigureNinjectWebApi(IAppBuilder app, HttpConfiguration config)
            {
                app.UseNinjectWebApi(config);
            }

            #endregion Internal Methods
        }
}