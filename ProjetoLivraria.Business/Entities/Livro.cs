using System;

namespace ProjetoLivraria.Business.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }

        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }

        public int Ano { get; set; }

        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
