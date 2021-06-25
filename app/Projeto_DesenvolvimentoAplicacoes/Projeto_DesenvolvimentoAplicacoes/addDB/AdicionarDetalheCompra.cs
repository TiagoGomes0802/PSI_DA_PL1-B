using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarDetalheCompra
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarDetalheCompra()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public DetalheCompra AddDetalheCompra(int quantidade, int nCompra, int codProduto)
        {
            var detalhes = new DetalheCompra()
            {
                Quantidade = quantidade,
                ComprasNrCompra = nCompra,
                ProdutosCodProduto = codProduto,
            };

            basedados.DetalheCompra.Add(detalhes);
            basedados.SaveChanges();

            return detalhes;
        }

        public List<DetalheCompra> GetDetalheCompra()
        {
            var obj = basedados.DetalheCompra.OfType<DetalheCompra>().Where(e => e is DetalheCompra).ToList();

            return obj;
        }

        public void RemDetalheCompra(int id)
        {
            var detalhes = basedados.DetalheCompra.Where(p => p is DetalheCompra && p.ComprasNrCompra == id).FirstOrDefault();

            basedados.DetalheCompra.Remove(detalhes);
            basedados.SaveChanges();
        }

        public void AltDetalheCompra(int id, int quantidade, int nCompra, int codProduto)
        {
            var DetalheCompra = basedados.DetalheCompra.OfType<DetalheCompra>().FirstOrDefault(p => p.ProdutosCodProduto == id);

            DetalheCompra.Quantidade = quantidade;
            DetalheCompra.ComprasNrCompra = nCompra;
            DetalheCompra.ProdutosCodProduto = codProduto;

            basedados.SaveChanges();
        }
    }
}
