using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Colaboracao
    {
        public override string ToString()
        {
            string colaboracao = "Número do Evento: " + NrEvento + ", Id Animador: " + IdAnimador + ";";
            return colaboracao;
        }
    }
}
