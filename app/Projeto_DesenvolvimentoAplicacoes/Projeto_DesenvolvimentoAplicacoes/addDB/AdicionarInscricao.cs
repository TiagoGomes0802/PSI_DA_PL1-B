using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarInscricao
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarInscricao()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Inscricao AddInscricao(bool confirmacao, int idFilho, int NrEvento)
        {
            var inscricao = new Inscricao()
            {
                Confirmada = confirmacao,
                FilhoIdPessoa = idFilho,
                EventosNrEvento = NrEvento,
            };

            basedados.Inscricao.Add(inscricao);
            basedados.SaveChanges();

            return inscricao;
        }

        public List<Inscricao> GetInscricao()
        {
            var obj = basedados.Inscricao.OfType<Inscricao>().Where(e => e is Inscricao).ToList();

            return obj;
        }

        public void RemInscricao(int id)
        {
            var inscricao = basedados.Inscricao.Where(e => e is Inscricao && e.EventosNrEvento == id).FirstOrDefault();

            basedados.Inscricao.Remove(inscricao);
            basedados.SaveChanges();
        }
    }
}
