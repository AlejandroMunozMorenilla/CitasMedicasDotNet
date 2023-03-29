using AutoMapper;
using HOSPITAL.Data;
using Hospital.DTO;
using Hospital.Model;
using Hospital.Repository;

namespace HOSPITAL.Interfaces
{
    public interface IDiagnosticoService
    {
        public ICollection<DiagnosticoDTO> GetDiagnosticos();
        public DiagnosticoDTO GetDiagnosticoById(int id);
        public void InsertDiagnostico(DiagnosticoDTO diagnosticoDTO);
        public void DeleteDiagnostico(int id);
        public void UpdateDiagnostico(DiagnosticoDTO diagnosticoDTO);
    }
}
