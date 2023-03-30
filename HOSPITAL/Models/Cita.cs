using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Hospital.Model
{
    public class Cita
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public String MotivoCita { get; set; }
        public int Attribute11 { get; set; }

        [ForeignKey("DiagnosticoId")]
        public Diagnostico Diagnostico { get; set; }
        public int DiagnosticoId { get; set; }
        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
    }
}
