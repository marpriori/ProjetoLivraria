using ProjetoLivraria.Business.Entities;
using System.Collections.Generic;

namespace ProjetoLivraria.Business.Interfaces.Services
{
    public interface IAutorService :IServiceBase<Autor>
    {
        IDictionary<Autor, int> ListarPrincipais();
    }
}
