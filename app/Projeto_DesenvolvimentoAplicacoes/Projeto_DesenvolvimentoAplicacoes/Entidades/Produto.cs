using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Produto
    {
        public override string ToString()
        {
            string produto = "Codigo Produto: " + CodProduto + ", Designação : " + Designacao + ", Preço : " + Preco + ", Stock: " + StockExistente + ", Codigo tipo produto: " + CodTipoProduto + ";";
            return produto;
        }
    }
}
