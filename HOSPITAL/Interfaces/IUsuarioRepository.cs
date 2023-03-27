using Hospital.Model;

namespace Hospital.Repository
{
    public interface IUsuarioRepository
    {
        ICollection<Usuario> GetAll();
        Usuario GetById(int id);
        void Insert(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
        void Save();
    }
}
