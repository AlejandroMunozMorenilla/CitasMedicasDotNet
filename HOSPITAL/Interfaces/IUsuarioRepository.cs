using Hospital.Model;

namespace Hospital.Repository
{
    public interface IUsuarioRepository
    {
        public ICollection<Usuario> GetAll();
        public Usuario GetById(int id);
        public void Insert(Usuario usuario);
        public void Update(Usuario usuario);
        public void Delete(int id);
        public void Save();
    }
}
