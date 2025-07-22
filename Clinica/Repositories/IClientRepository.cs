using Clinica.Entities;

namespace Clinica.Repositories {
    public interface IClientRepository {

        Task<ClientEntity> FindById(int id);

        Task<List<ClientEntity>> FindAll();

        Task Add(ClientEntity client);

    }
}
