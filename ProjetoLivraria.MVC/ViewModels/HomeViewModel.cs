using System.Collections.Generic;

namespace ProjetoLivraria.MVC.ViewModels
{
    public class HomeViewModel
    {
        public int QuantidadeLivro { get; set; }
        public int QuantidadeAutor { get; set; }
        public int QuantidadeEditora { get; set; }

        public IEnumerable<LivroViewModel> UltimosLivros { get; set; }
        public IDictionary<AutorViewModel,int> PrincipaisAutores { get; set; }
    }
}