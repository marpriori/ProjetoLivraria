using ProjetoLivraria.Business.Entities;
using System.Collections.Generic;

namespace ProjetoLivraria.Business.Interfaces.Repository
{
    public interface IAutorRepository : IRepositoryBase<Autor>
    {
        IDictionary<Autor, int> ListarPrincipais();
    }
}
