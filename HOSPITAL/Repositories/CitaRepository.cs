using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Exceptions;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace HOSPITAL.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly HospitalContext _context;

        public CitaRepository(HospitalContext context)
        {
            _context = context;
        }

        public ICollection<Cita> GetAll()
        {
            return _context.Citas
                .Include(cita => cita.Medico)
                .Include(cita => cita.Paciente)
                .Include(cita => cita.Diagnostico)
                .ToList<Cita>();
        }

        public Cita GetById(int id)
        {
            return _context.Citas.FirstOrDefault(cita => cita.Id == id);
        }

        public void Insert(Cita cita)
        {
            _context.Citas.Add(cita);
            if (!Save())
                throw new InsertException("No se ha podido insertar la cita");
        }

        public void Update(Cita cita)
        {
            _context.Citas.Update(cita);
            if (!Save())
                throw new UpdateException("No se ha podido actualizar la cita");
        }

        public void Delete(int id)
        {
            Cita cita = GetById(id);
            _context.Citas.Remove(cita);
            if (!Save())
                throw new DeleteException("No se ha podido eliminar la cita");
        }

        public bool Save()
        {
            int resultado = _context.SaveChanges();
            return resultado > 0;
        }
    }
}
