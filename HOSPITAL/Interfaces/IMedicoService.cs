using Hospital.DTO;

namespace HOSPITAL.Interfaces
{
    public interface IMedicoService
    {
        public ICollection<MedicoDTO> GetMedicos();
        public MedicoDTO GetMedicoById(int id);
        public void InsertMedico(MedicoDTO medicoDTO);
        public void DeleteMedico(int id);
        public void UpdateMedico(MedicoDTO medicoDTO);
    }
}
