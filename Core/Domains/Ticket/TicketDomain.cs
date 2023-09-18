using Domain.Domains.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domains.Ticket
{
    public class TicketDomain : BaseDomain
    {
        public string TicketNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid AuthorId { get; set; }
        public Guid? ResposibleId { get; set; }
        public int TicketType { get; set; }
        public DateTime? DueDate { get; set; }

        public TicketDomain(Guid id,
                            string ticketNumber,
                            string title,
                            string description,
                            Guid authorId,
                            Guid? responsibleId,
                            int ticketType,
                            DateTime? dueDate,
                            int status,
                            DateTime createdAt,
                            DateTime? updatedAt,
                            DateTime? deletedAt) : base(id, status, createdAt, updatedAt, deletedAt)
        {
            Id = id;
            TicketNumber = ticketNumber;
            Title = title;
            Description = description;
            AuthorId = authorId;
            ResposibleId = responsibleId;
            TicketType = ticketType;
            DueDate = dueDate;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
        }
        
        public static TicketDomain Create(
                            string title,
                            string description, 
                            Guid authorId,
                            Guid? responsibleId,
                            int ticketType,
                            DateTime? dueDate,
                            int status)
        {
            return new TicketDomain(id: Guid.NewGuid(),
                                    ticketNumber: "#",
                                    title: title,
                                    description: description,
                                    authorId: authorId,
                                    responsibleId: responsibleId,
                                    ticketType: ticketType,
                                    dueDate: dueDate,
                                    status: status,
                                    createdAt: DateTime.UtcNow,
                                    updatedAt: null,
                                    deletedAt: null);
        }
    }
}
