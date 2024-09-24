using ClientAPI.Database;
using ClientAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.Repository
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAll();
        Task<Client> GetById(int id);
        Task Add(Client client);
        Task Delete(int id);
    }

    public class ClientRepository : IClientRepository
    {
        private readonly ClientContext _context;

        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> GetAll() => await _context.Clients.ToListAsync();

        public async Task<Client> GetById(int id) => await _context.Clients.FindAsync(id);

        public async Task Add(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    }
}
