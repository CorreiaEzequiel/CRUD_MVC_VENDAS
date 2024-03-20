using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_Vendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo sobrenome é obrigatório!")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório!")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato 000.000.000-00.")]
        public string CPF { get; set; }

        private string _telefone;
        [Required(ErrorMessage = "O campo telefone é obrigatório!")]
        public string Telefone
        {
            get { return _telefone; }
               set { 
                _telefone = new string ((value?? "").Where(char.IsDigit).ToArray());
            }
        }
        public string TelefoneFormatado
        {
            get
            {
                if(!string.IsNullOrEmpty(Telefone) && Telefone.Length >= 10)
                {
                    return $"+55 {Telefone.Substring(0, 2)} {Telefone.Substring(2, Telefone.Length - 2)}";
                }
                return Telefone;
            }
        }
    }
}
