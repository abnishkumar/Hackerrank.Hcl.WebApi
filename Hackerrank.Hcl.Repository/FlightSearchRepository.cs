using Hackerrank.Hcl.Contracts;
using Hackerrank.Hcl.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using System.Linq;

namespace Hackerrank.Hcl.Repository
{
    public class FlightSearchRepository : IFlightSearchRepository
    {
        public IEnumerable<FlightResult> GetFlightResult(FlightSearch flightSearch)
        {
            var data = GetData();
            if (flightSearch.From == null || flightSearch.To == null) return data;
            var filteredResult = data.Where(x => x.From.Equals(flightSearch.From, StringComparison.InvariantCultureIgnoreCase)
            && x.To.Equals(flightSearch.To, StringComparison.InvariantCultureIgnoreCase));
            return filteredResult;
        }

        private List<FlightResult> GetData()
        {
            //get the Json filepath  
            string file = HttpContext.Current.Server.MapPath("~/App_Data/Airline.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var airlineList = ser.Deserialize<List<FlightResult>>(Json);
            return airlineList;
        }

    }
}
