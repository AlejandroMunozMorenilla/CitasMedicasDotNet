using Hospital.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HOSPITAL.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Hospital.DTO.CitaDTO>? CitaDTO { get; set; }
        public DbSet<Hospital.DTO.DiagnosticoDTO>? DiagnosticoDTO { get; set; }
        public DbSet<Hospital.DTO.MedicoDTO>? MedicoDTO { get; set; }
        public DbSet<Hospital.DTO.PacienteDTO>? PacienteDTO { get; set; }
        public DbSet<Hospital.DTO.UsuarioDTO>? UsuarioDTO { get; set; }
    }
}
