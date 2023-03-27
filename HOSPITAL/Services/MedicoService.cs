using AutoMapper;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;

namespace HOSPITAL.Services
{
    public class MedicoService
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
        public MedicoDTO InsertMedico(MedicoDTO medicoDTO)
        {
            _repo.Insert(_mapper.Map<MedicoDTO, Medico>(medicoDTO));
            return medicoDTO;
        }        
        public MedicoDTO DeleteMedico(int id)
        {
            return _mapper.Map<Medico, MedicoDTO>(_repo.Delete(id));
        }
        public MedicoDTO UpdateMedico(MedicoDTO medicoDTO)
        {
            Medico paciente = _mapper.Map<MedicoDTO, Medico>(medicoDTO);
            return _mapper.Map<Medico, MedicoDTO>(_repo.Update(paciente));
        }
    }
}
