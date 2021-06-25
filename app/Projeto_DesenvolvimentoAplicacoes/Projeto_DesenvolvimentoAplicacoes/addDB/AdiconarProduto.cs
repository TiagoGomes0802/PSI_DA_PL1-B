using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdiconarProduto
    {
        BD_Projeto_DAContainer basedados;

        public AdiconarProduto()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public Produto AddProduto(string designacao, double preco, int stock, int codProduto)
        {
            var produto = new Produto()
            {
                Designacao = designacao,
                Preco = preco,
                StockExistente = stock,
                CodTipoProduto = codProduto,
            };

            basedados.Produto.Add(produto);
            basedados.SaveChanges();

            return produto;
        }

        public List<Produto> GetProduto()
        {
            var obj = basedados.Produto.OfType<Produto>().Where(e => e is Produto).ToList();

            return obj;
        }

        public void RemProduto(int id)
        {
            var produto = basedados.Produto.Where(p => p.CodProduto == id).FirstOrDefault();

            basedados.Produto.Remove(produto);
            basedados.SaveChanges();
        }

        public void AltProduto(int id, string designacao, double preco, int stock, int codProduto)
        {
            var produto = basedados.Produto.OfType<Produto>().FirstOrDefault(p => p.CodProduto == id);

            produto.Designacao = designacao;
            produto.Preco = preco;
            produto.StockExistente = stock;
            produto.CodTipoProduto = codProduto;

            basedados.SaveChanges();

        }
    }
}
