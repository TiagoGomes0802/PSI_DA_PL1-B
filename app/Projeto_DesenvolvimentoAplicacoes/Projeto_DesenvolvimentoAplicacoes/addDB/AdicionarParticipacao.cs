using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarParticipacao
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarParticipacao()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Participacao AddParticipacao(int idEscola, int nrEvento)
        {
            var participacao = new Participacao()
            {
                IdEscola = idEscola,
                NrEvento = nrEvento,
            };

            basedados.Participacao.Add(participacao);
            basedados.SaveChanges();

            return participacao;
        }

        public List<Participacao> GetParticipacao()
        {
            var obj = basedados.Participacao.OfType<Participacao>().Where(e => e is Participacao).ToList();

            return obj;
        }

        public void RemParticipacao(int id)
        {
            var participacao = basedados.Participacao.Where(e => e is Participacao && e.NrEvento == id).FirstOrDefault();

            basedados.Participacao.Remove(participacao);
            basedados.SaveChanges();
        }
    }
}

