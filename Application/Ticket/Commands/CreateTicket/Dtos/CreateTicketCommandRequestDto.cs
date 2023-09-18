using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ticket.Commands.CreateTicket.Dtos
{
    public class CreateTicketCommandRequestDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TicketType { get; set; }
        public Guid AuthorId { get; set; }

        public CreateTicketCommandRequestDto(string title, string description, int ticketType, Guid authorId)
        {
            Title = title;
            Description = description;
            TicketType = ticketType;
            AuthorId = authorId;
        }
    }
}
