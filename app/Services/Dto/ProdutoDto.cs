namespace app.Services.Dto
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Valor { get; set; } = decimal.Zero;
    }
}
