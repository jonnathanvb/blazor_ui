using System.ComponentModel.DataAnnotations;

namespace app.Services.Command
{
    public class ProdutoCommand
    {

        public int Id { get; set; }

        [Required()]
        [RegularExpression(@"^[a-zA-Z0-9]+(\s[a-zA-Z0-9]+)?", ErrorMessage = "O produto só pode ter nome e sobrenome")]
        public string Nome { get; set; } = string.Empty;

        [Required()]
        public string Descricao { get; set; } = string.Empty;

        [Range(1,999)]
        [Required()]
        public decimal QuantidadeEmEstoque { get; set; } = decimal.Zero;

        [Range(1, 99)]
        [Required()]
        public decimal Valor { get; set; } = decimal.Zero;
    }
}
