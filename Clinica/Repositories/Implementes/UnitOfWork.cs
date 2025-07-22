
using Clinica.Data;

namespace Clinica.Repositories.Implementes {
    public class UnitOfWork : IUnitOfWork {
        
        private readonly AppDbContext _context;

        public IClientRepository ClientRepository { get; }

        public UnitOfWork(AppDbContext context) {
            _context = context;
            ClientRepository = new ClientRepository(_context);
        }

        public void Dispose() {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync() {
            return await _context.SaveChangesAsync();
        }
    }
}
