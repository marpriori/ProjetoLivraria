using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoLivraria.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> BuscarUltimosLivrosCadastrados(int quantidade)
        {
            return Db.Livros.OrderByDescending(l => l.DataCadastro).Take(quantidade);
        }
    }
}
