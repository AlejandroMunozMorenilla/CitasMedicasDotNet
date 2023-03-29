using Hospital.DTO;
using Hospital.Model;

namespace Hospital.Repository
{
    public interface ICitaRepository
    {
        public ICollection<Cita> GetAll();
        public Cita GetById(int id);
        public void Insert(Cita cita);
        public void Update(Cita cita);
        public void Delete(int id);
    }
}
