using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Hcl.Contracts
{
    public class FlightResult
    {
        public string From { get; set; }
        public string To { get; set; }
        public string DepartDate { get; set; }
        public string Airline { get; set; }
        public double Price { get; set; }
    }
}
