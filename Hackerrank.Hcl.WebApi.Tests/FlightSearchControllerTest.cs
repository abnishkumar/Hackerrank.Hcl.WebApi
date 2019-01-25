using System.Collections.Generic;
using System.Threading.Tasks;
using Hackerrank.Hcl.Contracts;
using Hackerrank.Hcl.Service.Interfaces;
using Hackerrank.Hcl.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Hackerrank.Hcl.WebApi.Tests
{
    [TestClass]
    public class FlightSearchControllerTest
    {
        private Mock<IFlightSearchService> _mockFlightSearchService;

        private FlightSearchController _flightSearchController;

        [TestInitialize]
        public void Initialize()
        {
            _mockFlightSearchService = new Mock<IFlightSearchService>();
            _flightSearchController = new FlightSearchController(_mockFlightSearchService.Object);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var searchReq = new FlightSearch() { From = "EWR", To = "MIA", DepartDate = null };
            var tbValues1 = new List<FlightResult>()
            {
                new FlightResult {Airline="Continental",From="EWR",To="MIA",DepartDate="2019-01-25",Price=239 },
            };
            _mockFlightSearchService.Setup(x => x.GetFlightResult(searchReq)).Returns(tbValues1);
            var result = _flightSearchController.Get(searchReq);
            Assert.IsNotNull(result);
        }
    }
}
