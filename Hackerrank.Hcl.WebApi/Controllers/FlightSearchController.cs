using Hackerrank.Hcl.Contracts;
using Hackerrank.Hcl.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hackerrank.Hcl.WebApi.Controllers
{
    [RoutePrefix("api/flightsearch")]
    public class FlightSearchController : ApiController
    {
        private readonly IFlightSearchService service;
        public FlightSearchController(IFlightSearchService service)
        {
            this.service = service;
        }

        // GET: api/FlightSeach
        public IHttpActionResult Get([FromUri] FlightSearch flightSearch)
        {
            try
            {
                var result = this.service.GetFlightResult(flightSearch);
                return Ok(result);
            }
            catch (Exception) 
            {
                return BadRequest("bad");
            }
           
        }
    }
}
