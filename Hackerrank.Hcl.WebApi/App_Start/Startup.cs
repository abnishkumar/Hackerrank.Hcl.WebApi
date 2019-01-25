using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hackerrank.Hcl.WebApi.App_Start.Startup))]

namespace Hackerrank.Hcl.WebApi.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();
            var ninjectConfig = new NinjectConfig();
            ninjectConfig.ConfigureNinjectKernel(app);
            WebApiConfig.Register(config);
            ninjectConfig.ConfigureNinjectWebApi(app, config);
        }
    }
}
