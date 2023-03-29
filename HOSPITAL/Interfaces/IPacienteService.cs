using Hospital.DTO;

namespace HOSPITAL.Interfaces
{
    public interface IPacienteService
    {
        public ICollection<PacienteDTO> GetPacientes();
        public PacienteDTO GetPaceinteById(int id);
        public void InsertPaciente(PacienteDTO paciente);
        public void DeletePaciente(int id);
        public void UpdatePaciente(PacienteDTO pacienteDTO);
    }
}
