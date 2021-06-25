using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Filho
    {
        public override string ToString()
        {
            string filho = "ID: " + IdPessoa + ", Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Telemovel: " + Telemovel + ", Mail: " + Mail + ", Codigo-Postal: " + CodPostal + ", Sexo: " + Sexo + ", Data de nascimento: " + DataNascimento + ", Id Progenitor: " + IdProgenitor + ", Id Escola: " + IdEscola + ";";
            return filho;
        }
    }
}
