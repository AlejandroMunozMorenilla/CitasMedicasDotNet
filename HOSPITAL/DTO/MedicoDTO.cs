using Hospital.Model;

namespace Hospital.DTO
{
    public class MedicoDTO : UsuarioDTO
    {
        public String NumColegiado { get; set; }
        public ICollection<PacienteDTORec> Pacientes { get; set; }
    }
}
