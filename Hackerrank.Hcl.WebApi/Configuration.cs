using Hackerrank.Hcl.Repository;
using Hackerrank.Hcl.Repository.Interfaces;
using Hackerrank.Hcl.Service;
using Hackerrank.Hcl.Service.Interfaces;
using Ninject;

namespace Hackerrank.Hcl.WebApi
{
    public class Configuration
    {
        public static IKernel CreateDependencyGraph
        {
            get
            {
                var kernel = new StandardKernel();
                Configure(kernel);
                return kernel;
            }
        }

        internal static void Configure(IKernel kernel)
        {
            kernel.Bind<IFlightSearchService>().To<FlightSearchService>();
            kernel.Bind<IFlightSearchRepository>().To<FlightSearchRepository>();
        }
    }
}