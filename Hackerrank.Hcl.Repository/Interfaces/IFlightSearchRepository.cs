using Hackerrank.Hcl.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Hcl.Repository.Interfaces
{
    public interface IFlightSearchRepository
    {
        IEnumerable<FlightResult> GetFlightResult(FlightSearch flightSearch);
    }
}
