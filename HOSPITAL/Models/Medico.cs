using System.ComponentModel.DataAnnotations;

namespace Hospital.Model
{
    public class Medico : Usuario
    {
        [Required]
        public String NumColegiado { get; set; }

        public ICollection<Paciente>? Pacientes { get; set; }
    }
}
