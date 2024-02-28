using app.Services.Command;
using app.Services.Dto;

namespace app.Pages.Produto
{
    public partial class ProdutoCreate
    {

        public ProdutoCommand Command { get; set; } = new ProdutoCommand();
    }
}
