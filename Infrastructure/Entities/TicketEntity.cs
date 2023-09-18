using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table(name: "Tickets", Schema = "public")]
    public class TicketEntity : BaseEntity
    {
        [Required]
        public string TicketNumber { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public Guid? ResposibleId { get; set; }

        [Required]
        public int TicketType { get; set; }

        public DateTime? DueDate { get; set; }

    }
}
