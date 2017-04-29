using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLivraria.Infra.Data.Repositories
{
    public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public IDictionary<Autor,int> ListarPrincipais()
        {
            var lista = from autor in Db.Autores
                                 join livro in Db.Livros on autor.AutorId equals livro.AutorId
                                 group autor by autor into aut
                                 orderby aut.Count()
                                 select new { autor = aut.Key, quantidade = aut.Count() };
            return lista.Take(5).ToDictionary(r=> r.autor,c=> c.quantidade);
        }
    }
}
