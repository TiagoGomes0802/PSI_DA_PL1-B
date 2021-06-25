using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class Inscricao
    {
        public override string ToString()
        {
            string inscricao = "Confirmada: " + Confirmada + ", IdFilho : " + FilhoIdPessoa + ", Número evento : " + EventosNrEvento + ";";
            return inscricao;
        }
    }
}
