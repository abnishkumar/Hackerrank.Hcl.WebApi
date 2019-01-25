using Hackerrank.Hcl.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Hcl.Service.Interfaces
{
    public interface IFlightSearchService
    {
        IEnumerable<FlightResult> GetFlightResult(FlightSearch flightSearch);
    }
}
