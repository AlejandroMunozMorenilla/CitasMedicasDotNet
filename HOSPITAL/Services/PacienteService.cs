using AutoMapper;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;

namespace HOSPITAL.Services
{
    public class PacienteService
    {
        private readonly IPacienteRepository _repo;
        private readonly HospitalContext _context;
        private readonly IMapper _mapper;

        public PacienteService(IPacienteRepository services, HospitalContext context, IMapper mapper)
        {
            _repo = services;
            _context = context;
            _mapper = mapper;
        }

        public ICollection<PacienteDTO> GetPacientes()
        {
            return _mapper.Map<ICollection<Paciente>, ICollection<PacienteDTO>>(_repo.GetAll());
        }
        public PacienteDTO GetPaceinteById(int id)
        {
            return _mapper.Map<Paciente, PacienteDTO>(_repo.GetById(id));
        }
        public PacienteDTO InsertPaciente(PacienteDTO paciente)
        {
            _repo.Insert(_mapper.Map<PacienteDTO, Paciente>(paciente));
            return paciente;
        }        
        public PacienteDTO DeletePaciente (int id)
        {
            return _mapper.Map<Paciente, PacienteDTO>(_repo.Delete(id));
        }
        public PacienteDTO UpdatePaciente (PacienteDTO pacienteDTO)
        {
            Paciente paciente = _mapper.Map<PacienteDTO, Paciente>(pacienteDTO);
            return _mapper.Map<Paciente, PacienteDTO>(_repo.Update(paciente));
        }
    }
}
