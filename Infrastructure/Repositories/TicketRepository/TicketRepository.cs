using AutoMapper;
using Domain.Domains.Ticket;
using Infrastructure.DatabaseContext;
using Infrastructure.Entities;
using Infrastructure.Repositories.Generic;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories.TicketRepository
{
    internal class TicketRepository : GenericRepository<TicketEntity, TicketDomain>
    {
        TicketDbContext _dbContext;
        public TicketRepository(TicketDbContext ticketDbContext, ILogger logger, IMapper mapper) : base(ticketDbContext, logger, mapper)
        {
            _dbContext = ticketDbContext;
        }


    }
}
