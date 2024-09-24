using ClientAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.Database
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
    }
}
