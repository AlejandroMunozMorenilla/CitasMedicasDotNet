using Hospital.Model;

namespace Hospital.Repository
{
    public interface IPacienteRepository
    {
        public ICollection<Paciente> GetAll();
        public Paciente GetById(int id);
        public void Insert(Paciente paciente);
        public void Update(Paciente paciente);
        public void Delete(int id);
    }
}
