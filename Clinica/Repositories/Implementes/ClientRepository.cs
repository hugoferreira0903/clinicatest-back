using Clinica.Data;
using Clinica.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repositories.Implementes {
    public class ClientRepository : IClientRepository {

        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context) {
            _context = context;
        }

        public async Task Add(ClientEntity client) {
            await _context.Clientes.AddAsync(client);
        }

        public async Task<List<ClientEntity>> FindAll() {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<ClientEntity?> FindById(int id) { // Fix: Add nullable type to match FindAsync behavior
            return await _context.Clientes.FindAsync(id);
        }
    }
}
