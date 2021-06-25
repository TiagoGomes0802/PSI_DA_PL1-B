using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Evento
    {
        public override string ToString()
        {
            string evento = "Numero do Evento: " + NrEvento + ", Tipo de Evento: " + TipoEvento + ", Descrição: " + Descricao + ", Local: " + Local + ", Data e Hora: " + DataHora + ", Limite de participantes: " + LimiteParticipantes + ", Idade minima: " + IdadeInferior + ", Idade maxima: " + IdadeSuperior + ";";
            return evento;
        }
    }
}
