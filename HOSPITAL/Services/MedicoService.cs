using AutoMapper;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Interfaces;

namespace HOSPITAL.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _repo;
        private readonly HospitalContext _context;
        private readonly IMapper _mapper;

        public MedicoService(IMedicoRepository services, HospitalContext context, IMapper mapper)
        {
            _repo = services;
            _context = context;
            _mapper = mapper;
        }

        public ICollection<MedicoDTO> GetMedicos()
        {
            return _mapper.Map<ICollection<Medico>, ICollection<MedicoDTO>>(_repo.GetAll());
        }
        public MedicoDTO GetMedicoById(int id)
        {
            return _mapper.Map<Medico, MedicoDTO>(_repo.GetById(id));
        }
        public void InsertMedico(MedicoDTO medicoDTO)
        {
            _repo.Insert(_mapper.Map<MedicoDTO, Medico>(medicoDTO));
        }        
        public void DeleteMedico(int id)
        {
            _repo.Delete(id);
        }
        public void UpdateMedico(MedicoDTO medicoDTO)
        {
            _repo.Update(_mapper.Map<MedicoDTO, Medico>(medicoDTO));
        }
    }
}
