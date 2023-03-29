using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Exceptions;
using Microsoft.CodeAnalysis;
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

        public ICollection<Medico> GetAll()
        {
            return _context.Medicos.ToList<Medico>();
        }

        public Medico GetById(int id)
        {
            return _context.Medicos.FirstOrDefault(medico => medico.Id == id);
        }

        public void Insert(Medico medico)
        {
            _context.Medicos.Add(medico);
            if (!Save())
                throw new InsertException("No se ha podido insertar el medico");
        }

        public void Update(Medico medico)
        {
            _context.Medicos.Update(medico);
            if (!Save()) 
                throw new UpdateException("No se ha podido actualizar el medico");
        }

        public void Delete(int id)
        {
            Medico medico = GetById(id);
            _context.Medicos.Remove(medico);
            if (!Save())
                throw new DeleteException("No se ha podido eliminar el medico");
        }

        public bool Save()
        {
            int resultado = _context.SaveChanges();
            return resultado > 0;
        }
    }
}
