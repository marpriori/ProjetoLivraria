using System;
using System.Collections.Generic;
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

        public IEnumerable<Livro> BuscarUltimosLivrosCadastrados(int quantidade)
        {
            return _livroRepository.BuscarUltimosLivrosCadastrados(quantidade);
        }
    }
}
