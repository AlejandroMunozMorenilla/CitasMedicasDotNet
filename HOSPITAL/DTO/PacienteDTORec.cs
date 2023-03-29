using Hospital.Model;

namespace Hospital.DTO
{
    public class PacienteDTORec : UsuarioDTO
    {
        public String NSS { get; set; }
        public String NumTarjeta { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
    }
}
