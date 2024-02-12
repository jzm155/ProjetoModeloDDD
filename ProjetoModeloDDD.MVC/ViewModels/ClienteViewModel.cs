using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email valido")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}
