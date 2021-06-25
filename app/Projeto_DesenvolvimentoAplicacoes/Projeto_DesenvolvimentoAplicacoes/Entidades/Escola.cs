using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Escola
    {
        public override string ToString()
        {
            string escola = "ID Escola: " + IdEscola + ", Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Mail: " + Mail + ", Codigo-Postal: " + CodPostal + ";";
            return escola;
        }
    }
}
