using Hospital.Model;

namespace Hospital.DTO
{
    public class MedicoDTO : UsuarioDTO
    {
        public String NumColegiado { get; set; }
        public ICollection<PacienteDTO> Pacientes { get; set; }
        public ICollection<CitaDTO> Citas { get; set; }
    }
}
