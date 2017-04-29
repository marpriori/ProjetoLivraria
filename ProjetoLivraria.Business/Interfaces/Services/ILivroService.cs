using ProjetoLivraria.Business.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoLivraria.Business.Interfaces.Services
{
    public interface ILivroService :IServiceBase<Livro>
    {
        IEnumerable<Livro> BuscarUltimosLivrosCadastrados(int quantidade);
    }
}
