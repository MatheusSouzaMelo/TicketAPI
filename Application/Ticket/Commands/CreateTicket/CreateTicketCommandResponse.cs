using Domain.Domains.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ticket.Commands.CreateTicket
{
    public class CreateTicketCommandResponse
    {
        public TicketDomain TicketDomain { get; set; }
        public CreateTicketCommandResponse(TicketDomain ticketDomain) => TicketDomain = ticketDomain;
    }
}
