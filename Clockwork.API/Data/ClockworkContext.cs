using Clockwork.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Clockwork.API.Data
{
    public class ClockworkContext : DbContext
    {

        public ClockworkContext(DbContextOptions<ClockworkContext> options) : base (options) { }

        public DbSet<ClientLog> ClientLogs { get; set; }
    }
}