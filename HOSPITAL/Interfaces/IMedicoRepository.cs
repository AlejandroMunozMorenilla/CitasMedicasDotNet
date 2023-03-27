using Hospital.Model;

namespace Hospital.Repository
{
    public interface IMedicoRepository
    {
        ICollection<Medico> GetAll();
        Medico GetById(int id);
        Medico Insert(Medico medico);
        Medico Update(Medico medico);
        Medico Delete(int id);
    }
}
