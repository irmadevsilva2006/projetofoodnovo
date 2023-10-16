using projetofood.Models;

namespace projetofood.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias {get;}
    }
}