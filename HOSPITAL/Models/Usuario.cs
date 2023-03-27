using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Model
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellidos { get; set; }
        [Required]
        public String NombreUsuario { get; set; }
        [Required]
        public String Clave { get; set; }

    }
}
