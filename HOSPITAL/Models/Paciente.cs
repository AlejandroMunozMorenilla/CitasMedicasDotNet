using System.ComponentModel.DataAnnotations;

namespace Hospital.Model
{
    public class Paciente : Usuario
    {
        public String NSS { get; set; }
        public String NumTarjeta { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public ICollection<Medico>? Medicos { get; set; }
        public ICollection<Cita>? Citas { get; set; }
    }
}
