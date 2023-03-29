using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Exceptions;
using HOSPITAL.Interfaces;

namespace HOSPITAL.Repositories
{
    public class DiagnosticoRepository : IDiagnosticoRepository
    {
        private readonly HospitalContext _context;

        public DiagnosticoRepository(HospitalContext context)
        {
            _context = context;
        }

        public ICollection<Diagnostico> GetAll()
        {
            return _context.Diagnosticos.ToList<Diagnostico>();
        }

        public Diagnostico GetById(int id)
        {
            Diagnostico diagnostico = _context.Diagnosticos.FirstOrDefault(diagnostico => diagnostico.Id == id);
            return (diagnostico != null)?diagnostico: throw new NotFoundException();
        }   

        public void Insert(Diagnostico diagnostico)
        {
            _context.Diagnosticos.Add(diagnostico);
            if (!Save()) 
                throw new InsertException("No se ha podido insertar el diagnostico");
        }

        public void Update(Diagnostico diagnostico)
        {
            _context.Diagnosticos.Update(diagnostico);
            if (!Save()) 
                throw new UpdateException("No se ha podido actualizar el diagnostico");
        }

        public void Delete(int id)
        {
            Diagnostico diagnostico = GetById(id);
            _context.Diagnosticos.Remove(diagnostico);
            if (!Save())
                throw new DeleteException("No se ha podido eliminar el diagnostico");
        }

        public bool Save()
        { 
            int resultado = _context.SaveChanges();
            return resultado > 0;
        }
    }
}
