using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Animador
    {
        public override string ToString()
        {
            string animador = "ID: " + IdPessoa + ", Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Telemovel: " + Telemovel + ", Mail: " + Mail + ", Codigo-Postal: " + CodPostal + ", Especialidade: " + Especialidade + ";";
            return animador;
        }
    }
}
