using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;

namespace HOSPITAL.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly HospitalContext _context;

        public CitaRepository(HospitalContext context)
        {
            _context = context;
        }

        public Cita Delete(int id)
        {
            Cita cita = GetById(id);
            _context.Citas.Remove(cita);
            return cita;
        }

        public ICollection<Cita> GetAll()
        {
            return _context.Citas.ToList<Cita>();
        }

        public Cita GetById(int id)
        {
            return _context.Citas.FirstOrDefault(cita => cita.Id == id);
        }

        public Cita Insert(Cita cita)
        {
            _context.Citas.Add(cita);
            return GetById(cita.Id);
        }

        public Cita Update(Cita cita)
        {
            _context.Citas.Update(cita);
            return GetById(cita.Id);
        }
    }
}
