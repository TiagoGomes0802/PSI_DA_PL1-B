using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Participacao
    {
        public override string ToString()
        {
            string participacao = "Número do Evento: " + NrEvento + ", Id Escola: " + IdEscola + ";";
            return participacao;
        }
    }
}
