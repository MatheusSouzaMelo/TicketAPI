using Domain.Domains.Ticket;
using Domain.Repositories.Generic;

namespace Domain.Repositories.Tikcet
{
    public interface ITicketRepository : IGenericRepository<TicketDomain>
    {
    }
}
