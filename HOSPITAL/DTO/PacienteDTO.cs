﻿using Hospital.Model;

namespace Hospital.DTO
{
    public class PacienteDTO : UsuarioDTO
    {
        public String NSS { get; set; }
        public String NumTarjeta { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

        public ICollection<MedicoDTO> Medicos { get; set; }
        public ICollection<CitaDTO> Citas { get; set; }

    }
}
