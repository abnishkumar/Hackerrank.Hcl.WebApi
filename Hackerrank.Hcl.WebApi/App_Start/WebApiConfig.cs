using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
namespace Hackerrank.Hcl.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute(ConfigurationManager.AppSettings["CORSOrigin"], ConfigurationManager.AppSettings["CORSHeaders"], ConfigurationManager.AppSettings["CORSMethods"]) { SupportsCredentials = true });
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
