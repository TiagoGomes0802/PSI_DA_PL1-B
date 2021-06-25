using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class gestaoDeProdutosVendidos : Form
    {

        addDB.AdiconarProduto produto = new addDB.AdiconarProduto();
        addDB.AdicionarTipoProduto tipoproduto = new addDB.AdicionarTipoProduto();

        private string QualAdicionar = "";
        BD_Projeto_DAContainer basedados;
        public gestaoDeProdutosVendidos()
        {
            InitializeComponent();
            basedados = new BD_Projeto_DAContainer();

            Ppreco.DecimalPlaces = 2;
            Ppreco.Increment = 0.1M;
        }

        private void gestãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDePessoas MudarForm = new gestaoDePessoas();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void gestãoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDeVendas MudarForm = new gestaoDeVendas();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void gestãoDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDeEventos MudarForm = new gestaoDeEventos();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void gestãoDeProdutosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDeProdutosVendidos MudarForm = new gestaoDeProdutosVendidos();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void gestãoDeEscolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDeEscolas MudarForm = new gestaoDeEscolas();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void gestãoDeAnimadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestaoDeAnimadores MudarForm = new gestaoDeAnimadores();
            MudarForm.ShowDialog();
            this.Close();
        }

        private void Produto_Click(object sender, EventArgs e)
        {
            Gproduto.Visible = true;
            Gtipo.Visible = false;
            GRemAlt.Visible = true;

            Pdesignacao.Clear();
            Pidtipo.Value = 0;
            Pstock.Value = 0;
            Ppreco.Value = 0;

            QualAdicionar = "produto";

            MostrarProduto.DataSource = produto.GetProduto();
        }

        private void TipoProduto_Click(object sender, EventArgs e)
        {
            Gproduto.Visible = false;
            Gtipo.Visible = true;
            GRemAlt.Visible = false;

            QualAdicionar = "tipoproduto";

            MostrarProduto.DataSource = tipoproduto.GetTipoProduto();
        }

        private void AdicionarPessoa_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "produto")
            {
                double preco = Convert.ToDouble(Ppreco.Value);

                var n =
                    from p in basedados.Produto
                    where p.CodTipoProduto == Pidtipo.Value
                    select p;

                if (n.Count() == 0)
                {
                    try
                    {
                        produto.AddProduto(Pdesignacao.Text, preco, Convert.ToInt32(Pstock.Value), Convert.ToInt32(Pidtipo.Value));
                        MostrarProduto.DataSource = produto.GetProduto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Este produto já se encontra disponivel para venda!");
                }

                Pdesignacao.Clear();
                Pidtipo.Value = 0;
                Pstock.Value = 0;
                Ppreco.Value = 0;
               
            }
            if (QualAdicionar == "tipoproduto")
            {
                try
                {
                    tipoproduto.AddTipoProduto(Ttipo.Text);
                    MostrarProduto.DataSource = tipoproduto.GetTipoProduto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Ttipo.Clear();
            }
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "produto")
            {
                try
                {
                    produto.AltProduto(Convert.ToInt32(idalterar.Value), Pdesignacao.Text, Convert.ToInt32(Ppreco.Value), Convert.ToInt32(Pstock.Value), Convert.ToInt32(Pidtipo.Value));
                    MostrarProduto.DataSource = produto.GetProduto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                idalterar.Value = 0;
                Pdesignacao.Clear();
                Pidtipo.Value = 0;
                Pstock.Value = 0;
                Ppreco.Value = 0;

            }
        }

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }

        private void remover_Click(object sender, EventArgs e)
        {
            var idtipo =
                       from p in basedados.Produto
                       where p.CodProduto == idremover.Value
                       select p.CodTipoProduto;

            int idtipoproduto = Convert.ToInt32(idtipo.SingleOrDefault());

            if (QualAdicionar == "produto")
            {
                try
                {
                    produto.RemProduto(Convert.ToInt32(idremover.Value));

                    tipoproduto.RemTipoProduto(Convert.ToInt32(idtipoproduto));

                    MostrarProduto.DataSource = produto.GetProduto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao a eliminar este produto(Verifique se o produto não está associado a alguma compra!)");
                }
            }
        }
    }
}
