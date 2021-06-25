using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarEscola
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarEscola()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Escola AddEscola(string nome, string morada, string telefone, string mail, string codPostal, string localidade)
        {
            var escola = new Escola()
            {
                Nome = nome,
                Morada = morada,
                Telefone = telefone,
                Mail = mail,
                CodPostal = codPostal,
                Localidade = localidade,
            };

            basedados.Escola.Add(escola);
            basedados.SaveChanges();

            return escola;
        }

        public List<Escola> GetEscola()
        {
            var obj = basedados.Escola.OfType<Escola>().Where(e => e is Escola).ToList();

            return obj;
        }

        public void RemEscola(int id)
        {
            var escola = basedados.Escola.Where(e => e is Escola && e.IdEscola == id).FirstOrDefault();

            basedados.Escola.Remove(escola);
            basedados.SaveChanges();
        }

        public void AltEscola(int id, string nome, string morada, string telefone, string mail, string codPostal, string localidade)
        {
            var escola = basedados.Escola.OfType<Escola>().FirstOrDefault(p => p.IdEscola == id);

            escola.IdEscola = id;
            escola.Nome = nome;
            escola.Morada = morada;
            escola.Telefone = telefone;
            escola.Mail = mail;
            escola.CodPostal = codPostal;
            escola.Localidade = localidade;

            basedados.SaveChanges();

        }
    }
}
