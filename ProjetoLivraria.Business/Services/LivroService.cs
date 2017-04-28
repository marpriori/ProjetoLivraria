using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using ProjetoLivraria.Business.Interfaces.Services;

namespace ProjetoLivraria.Business.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository) :
            base(livroRepository)
        {
            _livroRepository = livroRepository;
        }
    }
}
