using System.ComponentModel.DataAnnotations;

namespace TicketAPI.Controllers.Ticket.Dtos
{
    public class CreateTicketDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TicketType { get; set; }
        
    }
}
