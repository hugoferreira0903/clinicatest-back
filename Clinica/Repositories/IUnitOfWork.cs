namespace Clinica.Repositories {
    public interface IUnitOfWork : IDisposable {

        
        IClientRepository ClientRepository { get; }

        Task<int> SaveChangesAsync();

    }
}
