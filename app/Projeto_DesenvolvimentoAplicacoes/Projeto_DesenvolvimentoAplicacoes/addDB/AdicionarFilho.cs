using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarFilho
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarFilho()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Filho AddFilho(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string sexo, DateTime DataNascimento, int idEscola, int idProgenitor)
        {
            var filho = new Filho()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                CodPostal = codPostal,
                Telefone = telefone,
                Telemovel = telemovel,
                Mail = mail,
                Sexo = sexo,
                DataNascimento = DataNascimento,
                IdEscola = idEscola,
                IdProgenitor = idProgenitor,
            };

            basedados.Pessoa.Add(filho);
            basedados.SaveChanges();

            return filho;
        }
        public List<Filho> GetFilho()
        {
            var obj = basedados.Pessoa.Where(p => p is Filho).ToList().Select(f => (Filho)f).ToList();

            return obj;
        }

        public void RemFilho(int id)
        {
            var filho = basedados.Pessoa.Where(p => p is Filho && p.IdPessoa == id).FirstOrDefault();

            basedados.Pessoa.Remove(filho);
            basedados.SaveChanges();
        }

        public void AltFilho(int id, string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string sexo, DateTime DataNascimento, int idEscola, int idProgenitor)
        {
            var filho = basedados.Pessoa.OfType<Filho>().FirstOrDefault(p => p.IdPessoa == id);

            filho.IdPessoa = id;
            filho.Nome = nome;
            filho.Morada = morada;
            filho.Localidade = localidade;
            filho.CodPostal = codPostal;
            filho.Telefone = telefone;
            filho.Telemovel = telemovel;
            filho.Mail = mail;
            filho.Sexo = sexo;
            filho.DataNascimento = DataNascimento;
            filho.IdEscola = idEscola;
            filho.IdProgenitor = idProgenitor;

            basedados.SaveChanges();
        }
    }
}
