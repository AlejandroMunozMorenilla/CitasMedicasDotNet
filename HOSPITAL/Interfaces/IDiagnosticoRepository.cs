using Hospital.Model;

namespace Hospital.Repository
{
    public interface IDiagnosticoRepository
    {
        public ICollection<Diagnostico> GetAll();
        public Diagnostico GetById(int id);
        public void Insert(Diagnostico diagnostico);
        public void Update(Diagnostico diagnostico);
        public void Delete(int id);
    }
}
