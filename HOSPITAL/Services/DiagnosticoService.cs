using AutoMapper;
using HOSPITAL.Data;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Interfaces;
using HOSPITAL.Exceptions;

namespace HOSPITAL.Services
{
    public class DiagnosticoService : IDiagnosticoService
    {
        private readonly IDiagnosticoRepository _repo;
        private readonly HospitalContext _context;
        private readonly IMapper _mapper;

        public DiagnosticoService(IDiagnosticoRepository services, HospitalContext context, IMapper mapper)
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
        public void InsertDiagnostico(DiagnosticoDTO diagnosticoDTO)
        {
            _repo.Insert(_mapper.Map<DiagnosticoDTO, Diagnostico>(diagnosticoDTO));
        }
        public void DeleteDiagnostico(int id)
        {
            _repo.Delete(id);
        }
        public void UpdateDiagnostico(DiagnosticoDTO diagnosticoDTO)
        {
            _repo.Update(_mapper.Map<DiagnosticoDTO, Diagnostico>(diagnosticoDTO));
        }
    }
}
