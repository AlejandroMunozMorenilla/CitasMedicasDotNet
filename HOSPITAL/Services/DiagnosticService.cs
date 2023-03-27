using AutoMapper;
using HOSPITAL.Data;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;

namespace HOSPITAL.Services
{
    public class DiagnosticService
    {
        private readonly IDiagnosticoRepository _repo;
        private readonly HospitalContext _context;
        private readonly IMapper _mapper;

        public DiagnosticService(IDiagnosticoRepository services, HospitalContext context, IMapper mapper)
        {
            _repo = services;
            _context = context;
            _mapper = mapper;
        }

        public ICollection<DiagnosticoDTO> GetDiagnosticos()
        {
            return _mapper.Map<ICollection<Diagnostico>, ICollection<DiagnosticoDTO>>(_repo.GetAll());
        }
        public DiagnosticoDTO GetDiagnosticoById(int id)
        {
            return _mapper.Map<Diagnostico, DiagnosticoDTO>(_repo.GetById(id));
        }
        public DiagnosticoDTO InsertDiagnostico(DiagnosticoDTO diagnosticoDTO)
        {
            _repo.Insert(_mapper.Map<DiagnosticoDTO, Diagnostico>(diagnosticoDTO));
            return diagnosticoDTO;
        }
        public DiagnosticoDTO DeleteDiagnostico(int id)
        {
            return _mapper.Map<Diagnostico, DiagnosticoDTO>(_repo.Delete(id));
        }
        public DiagnosticoDTO UpdateDiagnostico(DiagnosticoDTO diagnosticoDTO)
        {
            Diagnostico paciente = _mapper.Map<DiagnosticoDTO, Diagnostico>(diagnosticoDTO);
            return _mapper.Map<Diagnostico, DiagnosticoDTO>(_repo.Update(paciente));
        }

    }
}
