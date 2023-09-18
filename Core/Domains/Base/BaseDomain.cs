using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domains.Base
{
    public class BaseDomain
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }        
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public BaseDomain(Guid id, int status, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt)
        {
            Id = id;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
        }
    }
}
