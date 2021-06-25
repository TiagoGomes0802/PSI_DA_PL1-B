using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarClientes
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarClientes()
        {
            basedados = new BD_Projeto_DAContainer();
        }
        public Cliente AddCliente(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string nCartao, string valorOferta)
        {
            var cliente = new Cliente()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                CodPostal = codPostal,
                Telefone = telefone,
                Telemovel = telemovel,
                Mail = mail,
                NrCartao = nCartao,
                ValorOferta = valorOferta,
            };

            basedados.Pessoa.Add(cliente);
            basedados.SaveChanges();

            return cliente;
        }

        public List<Cliente> GetCliente()
        {
            var obj = basedados.Pessoa.Where(p => p is Cliente).ToList().Select(c => (Cliente)c).ToList();

            return obj;
        }

        public void RemCliente(int id)
        {
            var cliente = basedados.Pessoa.Where(p => p is Cliente && p.IdPessoa == id).FirstOrDefault();

            basedados.Pessoa.Remove(cliente);
            basedados.SaveChanges();
        }

        public void AltCliente(int id, string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string nCartao, string valorOferta)
        {

            var cliente = basedados.Pessoa.OfType<Cliente>().FirstOrDefault(p => p.IdPessoa == id);

            cliente.Nome = nome;
            cliente.Morada = morada;
            cliente.Localidade = localidade;
            cliente.CodPostal = codPostal;
            cliente.Telefone = telefone;
            cliente.Telemovel = telemovel;
            cliente.Mail = mail;
            cliente.NrCartao = nCartao;
            cliente.ValorOferta = valorOferta;

            basedados.SaveChanges();
        }
    }
}
