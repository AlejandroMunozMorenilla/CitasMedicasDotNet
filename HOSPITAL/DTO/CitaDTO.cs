﻿using Hospital.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.DTO
{
    public class CitaDTO
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public String MotivoCita { get; set; }
        public int Attribute11 { get; set; }
        public DiagnosticoDTO Diagnostico { get; set; }
        public MedicoDTORec Medico { get; set; }
        public PacienteDTORec Paciente { get; set; }

    }
}
