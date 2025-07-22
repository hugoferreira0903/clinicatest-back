using System.ComponentModel.DataAnnotations;

namespace Clinica.Entities {
    public class ClientEntity {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string cpf { get; set; }
        public string password { get; set; }

        public ICollection<ConsultaClientEntity>? Consultas { get; set; } = new List<ConsultaClientEntity>();
    }
}
