using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public int Status { get; set; } = 1;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;   
        [Required]
        public DateTime? UpdatedAt { get; set;}
        [Required]
        public DateTime? DeletedAt { get; set; }
    }
}
