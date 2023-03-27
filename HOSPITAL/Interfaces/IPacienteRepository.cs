using Hospital.Model;

namespace Hospital.Repository
{
    public interface IPacienteRepository
    {
        ICollection<Paciente> GetAll();
        Paciente GetById(int id);
        Paciente Insert(Paciente paciente);
        Paciente Update(Paciente paciente);
        Paciente Delete(int id);
    }
}
