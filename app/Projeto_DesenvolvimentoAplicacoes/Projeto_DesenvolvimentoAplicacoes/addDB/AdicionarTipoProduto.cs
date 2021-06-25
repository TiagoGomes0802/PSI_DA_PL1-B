using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DesenvolvimentoAplicacoes.addDB
{
    class AdicionarTipoProduto
    {
        BD_Projeto_DAContainer basedados;

        public AdicionarTipoProduto()
        {
            basedados = new BD_Projeto_DAContainer();
        }

        public TipoProduto AddTipoProduto(string tipo)
        {
            var tipoProduto = new TipoProduto()
            {
                Tipo = tipo,
            };

            basedados.TipoProduto.Add(tipoProduto);
            basedados.SaveChanges();

            return tipoProduto;
        }

        public List<TipoProduto> GetTipoProduto()
        {
            var obj = basedados.TipoProduto.OfType<TipoProduto>().Where(e => e is TipoProduto).ToList();

            return obj;
        }

        public void RemTipoProduto(int id)
        {
            var tipoProduto = basedados.TipoProduto.Where(p => p is TipoProduto && p.CodTipoProduto == id).FirstOrDefault();

            basedados.TipoProduto.Remove(tipoProduto);
            basedados.SaveChanges();
        }

        public void AltTipoProduto(int id, string tipo)
        {
            var tipoProduto = basedados.TipoProduto.OfType<TipoProduto>().FirstOrDefault(p => p.CodTipoProduto == id);

            tipoProduto.Tipo = tipo;

            basedados.SaveChanges();
        }
    }
}
