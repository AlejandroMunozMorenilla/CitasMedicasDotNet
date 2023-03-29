using AutoMapper;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Interfaces;

namespace HOSPITAL.Services
{
    public class PacienteService : IPacienteService
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
        public void InsertPaciente(PacienteDTO paciente)
        {
            _repo.Insert(_mapper.Map<PacienteDTO, Paciente>(paciente));
        }        
        public void DeletePaciente (int id)
        {
            _repo.Delete(id);
        }
        public void UpdatePaciente (PacienteDTO pacienteDTO)
        {
            _repo.Update(_mapper.Map<PacienteDTO, Paciente>(pacienteDTO));
        }
    }
}
