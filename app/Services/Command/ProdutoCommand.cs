namespace app.Services.Command
{
    public class ProdutoCommand
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal QuantidadeEmEstoque { get; set; } = decimal.Zero;
        public decimal Valor { get; set; } = decimal.Zero;
    }
}
