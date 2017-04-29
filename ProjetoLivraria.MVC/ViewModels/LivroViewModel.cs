using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLivraria.MVC.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Preencha o campo Título")]
        [MaxLength(250, ErrorMessage = "{0} com no máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "{0} com no mínimo {1} caracteres")]
        public string Titulo { get; set; }

        public int AutorId { get; set; }
        [DisplayName("Autor")]
        public virtual AutorViewModel Autor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Ano")]
        [Range(typeof(int),"1000", "9999",ErrorMessage = "{0} deve ser entre {1} e {2}")]
        public int Ano { get; set; }

        public int EditoraId { get; set; }
        [DisplayName("Editora")]
        public virtual EditoraViewModel Editora { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}