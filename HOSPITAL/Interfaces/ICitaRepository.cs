using Hospital.DTO;
using Hospital.Model;

namespace Hospital.Repository
{
    public interface ICitaRepository
    {
        ICollection<Cita> GetAll();
        Cita GetById(int id);
        Cita Insert(Cita cita);
        Cita Update(Cita cita);
        Cita Delete(int id);
    }
}
