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
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Titulo { get; set; }

        public int AutorId { get; set; }
        public virtual AutorViewModel Autor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Ano")]
        [Range(typeof(int), "1000", "9999999")]
        public int Ano { get; set; }

        public int EditoraId { get; set; }
        public virtual EditoraViewModel Editora { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}