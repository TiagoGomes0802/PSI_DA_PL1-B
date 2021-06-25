using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarColaboracao
    {

        BD_Projeto_DAContainer basedados;

        public AdicionarColaboracao()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Colaboracao AddColaboracao(int NrEvento, int IdAnimador)
        {
            var colaboracao = new Colaboracao()
            {
                NrEvento = NrEvento,
                IdAnimador = IdAnimador,
            };

            basedados.Colaboracao.Add(colaboracao);
            basedados.SaveChanges();

            return colaboracao;
        }

        public List<Colaboracao> GetColaboracao()
        {
            var obj = basedados.Colaboracao.OfType<Colaboracao>().Where(e => e is Colaboracao).ToList();

            return obj;
        }

        public void RemColaboracao(int id)
        {
            var colaboracao = basedados.Colaboracao.Where(e => e is Colaboracao && e.NrEvento == id).FirstOrDefault();

            basedados.Colaboracao.Remove(colaboracao);
            basedados.SaveChanges();
        }
    }
}
