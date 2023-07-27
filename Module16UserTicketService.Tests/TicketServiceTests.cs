using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Module16UserTicketService.TicketService;

namespace Module16UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GeTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GeTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicket(1));
        }

    }
}
