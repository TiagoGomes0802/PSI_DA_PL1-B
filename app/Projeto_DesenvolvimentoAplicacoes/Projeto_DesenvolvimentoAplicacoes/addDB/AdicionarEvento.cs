using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarEvento
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarEvento()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Evento AddEvento(string descricao, string local, DateTime datahora, int limite, int idadeMinima, int idadeMaxima, string tipoEvento)
        {
            var evento = new Evento()
            {
                Descricao = descricao,
                Local = local,
                DataHora = datahora,
                LimiteParticipantes = limite,
                IdadeInferior = idadeMinima,
                IdadeSuperior = idadeMaxima,
                TipoEvento = tipoEvento,
            };

            basedados.Evento.Add(evento);
            basedados.SaveChanges();

            return evento;
        }

        public List<Evento> GetEvento()
        {
            var obj = basedados.Evento.OfType<Evento>().Where(e => e is Evento).ToList();

            return obj;
        }

        public void RemEvento(int id)
        {
            var evento = basedados.Evento.Where(e => e is Evento && e.NrEvento == id).FirstOrDefault();

            basedados.Evento.Remove(evento);
            basedados.SaveChanges();
        }


        public void AltEvento(int nr, string descricao, string local, DateTime datahora, int limite, int idadeMinima, int idadeMaxima, string tipoEvento)
        {
            var evento = basedados.Evento.OfType<Evento>().FirstOrDefault(p => p.NrEvento == nr);

            evento.NrEvento = nr;
            evento.Descricao = descricao;
            evento.Local = local;
            evento.DataHora = datahora;
            evento.LimiteParticipantes = limite;
            evento.IdadeInferior = idadeMinima;
            evento.IdadeSuperior = idadeMaxima;
            evento.TipoEvento = tipoEvento;

            basedados.SaveChanges();
        }
    }
}

