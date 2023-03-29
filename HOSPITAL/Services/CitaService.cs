using AutoMapper;
using HOSPITAL.Data;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Interfaces;

namespace HOSPITAL.Services
{
    public class CitaService : ICitaService
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
        public void InsertCita(CitaDTO citaDTO)
        {
            _repo.Insert(_mapper.Map<CitaDTO, Cita>(citaDTO));
        }
        public void DeleteCita(int id)
        {
            _repo.Delete(id);
        }
        public void UpdateCita(CitaDTO citaDTO)
        {
            _repo.Update(_mapper.Map<CitaDTO, Cita>(citaDTO));
        }

    }
}
