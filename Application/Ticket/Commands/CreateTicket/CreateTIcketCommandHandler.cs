using Domain.Domains.Ticket;
using Domain.Repositories.Tikcet;
using MediatR;

namespace Application.Ticket.Commands.CreateTicket
{
    public class CreateTIcketCommandHandler : IRequestHandler<CreateTicketCommandRequest, CreateTicketCommandResponse>
    {
        private readonly ITicketRepository _ticketRepository;
        public CreateTIcketCommandHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public async Task<CreateTicketCommandResponse> Handle(CreateTicketCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                ///TODO: Check if User exists
                ///TODO: Check ticket type
                ///TODO: Add Resposinble
                ///TODO: Add Due Date base on type


                var ticket = TicketDomain.Create(title: request.CreateTicketCommandRequestDto.Title,
                                                 description: request.CreateTicketCommandRequestDto.Description,
                                                 authorId: request.CreateTicketCommandRequestDto.AuthorId,
                                                 responsibleId: null,
                                                 ticketType: request.CreateTicketCommandRequestDto.TicketType,
                                                 dueDate: null,
                                                 status: 1);
                
                var addedTicket = await _ticketRepository.Add(ticket);

                if (addedTicket == null) 
                {
                    return null;
                }


                return new CreateTicketCommandResponse(ticket);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
