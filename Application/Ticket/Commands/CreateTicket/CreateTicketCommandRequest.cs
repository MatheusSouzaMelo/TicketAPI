using Application.Ticket.Commands.CreateTicket.Dtos;
using MediatR;

namespace Application.Ticket.Commands.CreateTicket
{
    public class CreateTicketCommandRequest : IRequest<CreateTicketCommandResponse>
    {
        public CreateTicketCommandRequestDto CreateTicketCommandRequestDto { get; set; }
        public CreateTicketCommandRequest(CreateTicketCommandRequestDto createTicketCommandRequestDto)
        {
            CreateTicketCommandRequestDto = createTicketCommandRequestDto;
        }
    }
}
