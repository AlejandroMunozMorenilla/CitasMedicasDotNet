using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using Microsoft.EntityFrameworkCore;

namespace HOSPITAL.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HospitalContext _context;

        public MedicoRepository(HospitalContext context)
        {
            _context = context;
        }

        public Medico Delete(int id)
        {
            Medico medico = GetById(id);
            _context.Medicos.Remove(medico);
            return medico;
        }

        public ICollection<Medico> GetAll()
        {
            return _context.Medicos.ToList<Medico>();
        }

        public Medico GetById(int id)
        {
            return _context.Medicos.FirstOrDefault(medico => medico.Id == id);
        }

        public Medico Insert(Medico medico)
        {
            _context.Medicos.Add(medico);
            return GetById(medico.Id);
        }

        public Medico Update(Medico medico)
        {
            _context.Medicos.Update(medico);
            return GetById(medico.Id);
        }
    }
}
