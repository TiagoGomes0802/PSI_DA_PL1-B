using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Compra
    {
        public override string ToString()
        {
            string compra = "Número da compra: " + NrCompra + ", Id Cliente: " + IdCliente + ", Data da compra: " + Data + ", Utilizou Cartão: " + UtilizouCartao + ", Codigo produto: " + ProdutosCodProduto + ";";
            return compra;
        }
    }
}
