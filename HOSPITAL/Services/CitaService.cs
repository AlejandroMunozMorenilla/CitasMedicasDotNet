using AutoMapper;
using HOSPITAL.Data;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;

namespace HOSPITAL.Services
{
    public class CitaService
    {
        private readonly ICitaRepository _repo;
        private readonly IMapper _mapper;

        public CitaService(ICitaRepository services, IMapper mapper)
        {
            _repo = services;
            _mapper = mapper;
        }

        public ICollection<CitaDTO> GetCitas()
        {
            return _mapper.Map<ICollection<Cita>, ICollection<CitaDTO>>(_repo.GetAll());
        }
        public CitaDTO GetCitaById(int id)
        {
            return _mapper.Map<Cita, CitaDTO>(_repo.GetById(id));
        }
        public CitaDTO InsertCita(CitaDTO citaDTO)
        {
            _repo.Insert(_mapper.Map<CitaDTO, Cita>(citaDTO));
            return citaDTO;
        }
        public CitaDTO DeleteCita(int id)
        {
            return _mapper.Map<Cita, CitaDTO>(_repo.Delete(id));
        }
        public CitaDTO UpdateCita(CitaDTO citaDTO)
        {
            Cita paciente = _mapper.Map<CitaDTO, Cita>(citaDTO);
            return _mapper.Map<Cita, CitaDTO>(_repo.Update(paciente));
        }

    }
}
