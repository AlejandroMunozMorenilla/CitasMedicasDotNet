using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace HOSPITAL.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HospitalContext _context;

        public PacienteRepository(HospitalContext context)
        {
            _context = context;
        }

        public ICollection<Paciente> GetAll()
        {
            return _context.Pacientes.Include(paciente => paciente.Medicos).ToList<Paciente>();
        }

        public Paciente GetById(int id)
        {
            return _context.Pacientes.Include(paciente => paciente.Medicos).FirstOrDefault(paciente => paciente.Id == id);
        }

        public void Insert(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            if (!Save())
                throw new InsertException("No se ha podido insertar el paciente");
        }

        public void Update(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            if (!Save())
                throw new UpdateException("No se ha podido actualizar el paceinte");
        }

        public void Delete(int id)
        {
            Paciente paciente = GetById(id);
            _context.Pacientes.Remove(paciente);
            if (!Save())
                throw new DeleteException("No se ha podido eliminar el paciente");
        }

        public bool Save()
        {
            int resultado = _context.SaveChanges();
            return resultado > 0;
        }
    }
}
