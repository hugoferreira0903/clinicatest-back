using Clinica.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase {


        private readonly IUnitOfWork _unitOfWork;

        public ClientController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] Entities.ClientEntity client) {
            
            var cliente = new Entities.ClientEntity {
                Name = client.Name,
                Email = client.Email,
                Phone = client.Phone,
                cpf = client.cpf,
                password = client.password
            };
            
        await _unitOfWork.ClientRepository.Add(cliente);
            await _unitOfWork.SaveChangesAsync();
        return CreatedAtAction(nameof(GetClientById), new { id = cliente.Id }, cliente);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById(int id) {
            var client = await _unitOfWork.ClientRepository.FindById(id);
            if (client == null) {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClients() {
            var clients = await _unitOfWork.ClientRepository.FindAll();
            return Ok(clients);
        }

    }
}
