using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;

namespace Hospital.Model
{
    public class Paciente : Usuario
    {
        [Required]
        public String NSS { get; set; }

        [Required]
        public String NumTarjeta { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}
