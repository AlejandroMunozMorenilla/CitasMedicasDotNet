using Hospital.Model;
using Hospital.Repository;
using HOSPITAL.Data;

namespace HOSPITAL.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HospitalContext _context;

        public PacienteRepository(HospitalContext context)
        {
            _context = context;
        }

        public Paciente Delete(int id)
        {
            Paciente paciente = GetById(id);
            _context.Pacientes.Remove(paciente);
            return paciente;
        }

        public ICollection<Paciente> GetAll()
        {
            return _context.Pacientes.ToList<Paciente>();
        }

        public Paciente GetById(int id)
        {
            return _context.Pacientes.FirstOrDefault(paciente => paciente.Id == id);
        }

        public Paciente Insert(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            return GetById(paciente.Id);
        }

        public Paciente Update(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            return GetById(paciente.Id);
        }
    }
}
