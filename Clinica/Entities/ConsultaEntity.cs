using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Entities {
    public class ConsultaEntity {


        public int Id { get; set; }
       
        public double Preco { get; set; }

        public string Atendimento { get; set; }

        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
        public MedicoEntity? Medico { get; set; }

    }
}
