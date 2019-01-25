using Hackerrank.Hcl.Contracts;
using Hackerrank.Hcl.Repository.Interfaces;
using Hackerrank.Hcl.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Hackerrank.Hcl.Service
{
    public class FlightSearchService : IFlightSearchService
    {
        private readonly IFlightSearchRepository repository;

        public FlightSearchService(IFlightSearchRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<FlightResult> GetFlightResult(FlightSearch flightSearch)
        {
            var result = this.repository.GetFlightResult(flightSearch);
            return result;
        }
    }
}
