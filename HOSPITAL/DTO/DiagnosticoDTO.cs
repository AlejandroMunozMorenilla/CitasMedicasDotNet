using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.DTO
{
    public class DiagnosticoDTO
    {
        public int Id { get; set; }
        public string ValoracionEspecialista { get; set; }
        public string Enfermedad { get; set; }
    }
}
