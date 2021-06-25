using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarAnimador
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarAnimador()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Animador AddAnimador(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string especialidade)
        {
            var animador = new Animador()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                CodPostal = codPostal,
                Telefone = telefone,
                Telemovel = telemovel,
                Mail = mail,
                Especialidade = especialidade,
                
            };

            basedados.Pessoa.Add(animador);
            basedados.SaveChanges();

            return animador;
        }

        public List<Animador> GetAnimador()
        {
            var obj = basedados.Pessoa.Where(p => p is Animador).ToList().Select(a => (Animador)a).ToList();

            return obj;
        }

        public void RemAnimador(int id)
        {
            var animador = basedados.Pessoa.Where(p => p is Animador && p.IdPessoa == id).FirstOrDefault();

            basedados.Pessoa.Remove(animador);
            basedados.SaveChanges();
        }

        public void AltAnimador(int id, string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string especialidade)
        {
            var animador = basedados.Pessoa.OfType<Animador>().FirstOrDefault(p => p.IdPessoa == id);

            animador.Nome = nome;
            animador.Morada = morada;
            animador.Localidade = localidade;
            animador.CodPostal = codPostal;
            animador.Telefone = telefone;
            animador.Telemovel = telemovel;
            animador.Mail = mail;
            animador.Especialidade = especialidade;

            basedados.SaveChanges();

        }

    }
}
