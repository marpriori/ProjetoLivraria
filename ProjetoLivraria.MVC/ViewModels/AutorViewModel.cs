using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLivraria.MVC.ViewModels
{
    public class AutorViewModel
    {
        [Key]
        public int AutorId { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}