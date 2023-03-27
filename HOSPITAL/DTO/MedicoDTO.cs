using Hospital.Model;

namespace Hospital.DTO
{
    public class MedicoDTO : PacienteDTO
    {
        public String NumColegiado { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}
