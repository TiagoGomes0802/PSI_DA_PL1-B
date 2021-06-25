using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class TipoProduto
    {
        public override string ToString()
        {
            string tipoProduto = "Codigo do Produto: " + CodTipoProduto + ", Tipo do produto: " + Tipo + ";";
            return tipoProduto;
        }
    }
}
