using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class DetalheCompra
    {
        public override string ToString()
        {
            string detalhe = "Quantidade: " + Quantidade + ", Numero da Compra: " + ComprasNrCompra + ", Codigo produto: " + ProdutosCodProduto + ";";
            return detalhe;
        }
    }
}
