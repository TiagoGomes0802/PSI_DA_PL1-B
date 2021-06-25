using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_DesenvolvimentoAplicacoes
{
    class connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=model;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
