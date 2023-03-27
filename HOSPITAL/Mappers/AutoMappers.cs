using AutoMapper;
using Hospital.DTO;
using Hospital.Model;

namespace HOSPITAL.Mappers
{
    public class AutoMappers : Profile
    {
        public AutoMappers()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<Cita, CitaDTO>();
            CreateMap<Paciente, PacienteDTO>();
            CreateMap<Medico, MedicoDTO>();
            CreateMap<Diagnostico, DiagnosticoDTO>();
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<CitaDTO, Cita>();
            CreateMap<PacienteDTO, Paciente>();
            CreateMap<MedicoDTO, Medico>();
            CreateMap<DiagnosticoDTO, Diagnostico>();
        }
    }
}
