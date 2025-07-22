using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Entities {
    public class ConsultaClientEntity {

        [Key]
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }

        public int ClientEntityId { get; set; }

        [ForeignKey("ClientEntityId")]
        public ClientEntity ClientEntity { get; set; }

        public int ConsultaEntityId { get; set; }

        [ForeignKey("ConsultaEntityId")]
        public ConsultaEntity ConsultaEntity { get; set; }

    }
}
