using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","9999999999")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public long ClienteId { get; set; }

        public ClienteViewModel Cliente { get; set; }
    }
}
