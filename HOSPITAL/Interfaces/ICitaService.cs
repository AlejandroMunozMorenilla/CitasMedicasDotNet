using Hospital.DTO;

namespace HOSPITAL.Interfaces
{
    public interface ICitaService
    {
        public ICollection<CitaDTO> GetCitas();
        public CitaDTO GetCitaById(int id);
        public void InsertCita(CitaDTO citaDTO);
        public void DeleteCita(int id);
        public void UpdateCita(CitaDTO citaDTO);
    }
}
