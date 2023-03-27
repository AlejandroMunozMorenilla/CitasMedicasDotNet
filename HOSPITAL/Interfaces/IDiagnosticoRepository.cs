using Hospital.Model;

namespace Hospital.Repository
{
    public interface IDiagnosticoRepository
    {
        ICollection<Diagnostico> GetAll();
        Diagnostico GetById(int id);
        Diagnostico Insert(Diagnostico diagnostico);
        Diagnostico Update(Diagnostico diagnostico);
        Diagnostico Delete(int id);
    }
}
