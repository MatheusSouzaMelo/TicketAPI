using Application.Ticket.Commands.CreateTicket;
using Application.Ticket.Commands.CreateTicket.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TicketAPI.Controllers.Ticket.Dtos;

namespace TicketAPI.Controllers.Ticket
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class TicketController : Controller
    {
        IMediator _mediator;
        public TicketController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost(template: "NewTicket", Name = "NewTicket")]
        [Consumes("application/json")]
        [ProducesResponseType(statusCode: (int)HttpStatusCode.Created)]
        public async Task<IActionResult> NewTicket(CreateTicketDto createTicketDto)
        {

            ///TODO: Get User Creating the ticket
            var createTicketRequestDto = new CreateTicketCommandRequestDto(title: createTicketDto.Title,
                                                                           description: createTicketDto.Description,
                                                                           ticketType: createTicketDto.TicketType,
                                                                           authorId: Guid.NewGuid());
            var createTicketCommandRequest = new CreateTicketCommandRequest(createTicketRequestDto);
            var response = await _mediator.Send(createTicketCommandRequest);
            return StatusCode(201, response);
        }
    }
}
