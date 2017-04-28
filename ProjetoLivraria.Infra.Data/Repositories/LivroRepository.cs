using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;

namespace ProjetoLivraria.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
    }
}
