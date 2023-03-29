using Hospital.Model;

namespace Hospital.Repository
{
    public interface IMedicoRepository
    {
        public ICollection<Medico> GetAll();
        public Medico GetById(int id);
        public void Insert(Medico medico);
        public void Update(Medico medico);
        public void Delete(int id);
    }
}
