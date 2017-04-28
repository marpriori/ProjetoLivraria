using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using ProjetoLivraria.Business.Interfaces.Services;

namespace ProjetoLivraria.Business.Services
{
    public class AutorService : ServiceBase<Autor>, IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository) :
            base(autorRepository)
        {
            _autorRepository = autorRepository;
        }
    }
}
