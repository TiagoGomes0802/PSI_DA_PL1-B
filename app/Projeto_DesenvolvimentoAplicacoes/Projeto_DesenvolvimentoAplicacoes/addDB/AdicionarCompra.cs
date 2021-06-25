using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarCompra
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarCompra()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Compra AddCompra(DateTime data, bool UtilizouCartao, int idCliente, int Produto)
        {

            var compra = new Compra()
            {
                Data = data,
                UtilizouCartao = UtilizouCartao,
                IdCliente = idCliente,
                ProdutosCodProduto = Produto,
            };

            basedados.Compra.Add(compra);
            basedados.SaveChanges();

            return compra;
        }

        public List<Compra> GetCompra()
        {
            var obj = basedados.Compra.OfType<Compra>().Where(e => e is Compra).ToList();

            return obj;
        }

        public void RemCompra(int id)
        {
            var compra = basedados.Compra.Where(p => p is Compra && p.NrCompra == id).FirstOrDefault();

            basedados.Compra.Remove(compra);
            basedados.SaveChanges();
        }

        public void AltCompra(int id, DateTime data, bool UtilizouCartao, int idCliente, int Produto)
        {
            var compra = basedados.Compra.OfType<Compra>().FirstOrDefault(p => p.NrCompra == id);

            compra.NrCompra = id;
            compra.Data = data;
            compra.UtilizouCartao = UtilizouCartao;
            compra.IdCliente = idCliente;
            compra.ProdutosCodProduto = Produto;

            basedados.SaveChanges();

        }
    }
}
