using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoLivraria.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
    }
}
