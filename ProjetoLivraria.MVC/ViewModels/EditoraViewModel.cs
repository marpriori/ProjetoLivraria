using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLivraria.MVC.ViewModels
{
    public class EditoraViewModel
    {
        [Key]
        public int EditoraId { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}