using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;

namespace HOSPITAL.Repositories
{
    public class DiagnosticoRepository : IDiagnosticoRepository
    {
        private readonly HospitalContext _context;

        public DiagnosticoRepository(HospitalContext context)
        {
            _context = context;
        }

        public Diagnostico Delete(int id)
        {
            Diagnostico diagnostico = GetById(id);
            _context.Diagnosticos.Remove(diagnostico);
            return diagnostico;
        }

        public ICollection<Diagnostico> GetAll()
        {
            return _context.Diagnosticos.ToList<Diagnostico>();
        }

        public Diagnostico GetById(int id)
        {
            return _context.Diagnosticos.FirstOrDefault(diagnostico => diagnostico.Id == id);
        }

        public Diagnostico Insert(Diagnostico diagnostico)
        {
            _context.Diagnosticos.Add(diagnostico);
            return diagnostico;
        }

        public Diagnostico Update(Diagnostico diagnostico)
        {
            _context.Diagnosticos.Update(diagnostico);
            return GetById(diagnostico.Id);
        }
    }
}
