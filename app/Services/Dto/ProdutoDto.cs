using app.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Services.Dto
{

    public class ProdutoDto
    {
        [TableColumn("#")]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        [TableColumn("Valor de Venda", false)]
        public decimal Valor { get; set; }

    }
}
