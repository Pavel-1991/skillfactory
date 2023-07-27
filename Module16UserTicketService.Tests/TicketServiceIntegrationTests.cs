using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            ticketServiceTest.DeleteTicket(newTicket);

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
