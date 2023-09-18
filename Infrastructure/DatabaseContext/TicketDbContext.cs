using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.DatabaseContext
{
    public class TicketDbContext : DbContext
    {
        readonly string ticketsConnectionString = string.Empty;
        public TicketDbContext(IConfiguration configuration)
        {
            ticketsConnectionString = configuration.GetConnectionString("tickets") ?? string.Empty;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ticketsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<TicketEntity> Tickets { get; set; }
    }
}
