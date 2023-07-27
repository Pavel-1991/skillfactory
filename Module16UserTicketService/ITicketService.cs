using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16UserTicketService
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
