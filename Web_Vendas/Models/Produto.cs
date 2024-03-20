using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Vendas.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo não permite no Máximo 100 carateres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        [StringLength(400, ErrorMessage = "O campo não permite no Máximo 400 carateres.")]
        public string Descricao { get; set; }
       [Required(ErrorMessage = "O campo preço é obrigatório!")]
        [Range (0.01, double.MaxValue, ErrorMessage = "O campo preço deve ter um valor positivo.")]
        public decimal Preco { get; set; }
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
