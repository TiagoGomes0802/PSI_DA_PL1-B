using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DesenvolvimentoAplicacoes
{
    public partial class gestaoDeVendas : Form
    {
        addDB.AdicionarCompra compra = new addDB.AdicionarCompra();
        addDB.AdicionarDetalheCompra detalhes = new addDB.AdicionarDetalheCompra();

        private string QualAdicionar = "";

        BD_Projeto_DAContainer basedados;

        public gestaoDeVendas()
        {
            basedados = new BD_Projeto_DAContainer();

            InitializeComponent();
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

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            

            if (QualAdicionar == "compra")
            {
                try
                {
                    compra.AltCompra(Convert.ToInt32(idalterar.Value), Cdatanascimento.SelectionStart, Ccartao.Checked, Convert.ToInt32(Cidcliente.Value), Convert.ToInt32(Ccodproduto.Value));
                    MostrarCompra.DataSource = compra.GetCompra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                idalterar.Value = 0;

                Ccartao.Checked = false;
                Cidcliente.Value = 0;
                Ccodproduto.Value = 0;
                Cdatanascimento.ShowToday = true;

            }
        }

        private void AdicionarPessoa_Click(object sender, EventArgs e)
        {

            if (QualAdicionar == "compra")
            {
                try
                {
                    compra.AddCompra(Cdatanascimento.SelectionStart, Ccartao.Checked, Convert.ToInt32(Cidcliente.Value), Convert.ToInt32(Ccodproduto.Value));
                    MostrarCompra.DataSource = compra.GetCompra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Ccartao.Checked = false;
                Cidcliente.Value = 0;
                Ccodproduto.Value = 0;
                Cdatanascimento.ShowToday = true;

            }
            if (QualAdicionar == "detalhe")
            {
                try
                {
                    detalhes.AddDetalheCompra(Convert.ToInt32(Dquantidade.Value), Convert.ToInt32(Dnrcompra.Value), Convert.ToInt32(Dcodproduto.Value));
                    MostrarCompra.DataSource = detalhes.GetDetalheCompra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Dquantidade.Value = 0;
                Dnrcompra.Value = 0;
                Dcodproduto.Value = 0;

            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            try
            {
                var nDetalhes =
                    from p in basedados.DetalheCompra
                    where p.ComprasNrCompra == idremover.Value
                    select p;

                for (int i = 0; i <= nDetalhes.Count(); i++)
                {
                    detalhes.RemDetalheCompra(Convert.ToInt32(idremover.Value));
                }
                compra.RemCompra(Convert.ToInt32(idremover.Value));
                MostrarCompra.DataSource = compra.GetCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            Gcompra.Visible = true;
            Gdetalhes.Visible = false;
            GRem.Visible = true;
            GAlt.Visible = true;

            Ccartao.Checked = false;
            Cidcliente.Value = 0;
            Ccodproduto.Value = 0;
            Cdatanascimento.ShowToday = true;

            QualAdicionar = "compra";
            MostrarCompra.DataSource = compra.GetCompra();
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {
            Gcompra.Visible = false;
            Gdetalhes.Visible = true;
            GRem.Visible = false;
            GAlt.Visible = true;

            Dquantidade.Value = 0;
            Dnrcompra.Value = 0;
            Dcodproduto.Value = 0;

            QualAdicionar = "detalhe";
            MostrarCompra.DataSource = detalhes.GetDetalheCompra();
        }

        private void Recibo_Venda_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "compra")
            {
                float precototal = 0;
                float preco = 0;

                Compra p = (Compra)MostrarCompra.SelectedItem;

                var ClienteCompra =
                    from c in basedados.Pessoa.OfType<Cliente>()
                    where c.IdPessoa == p.IdCliente
                    select c.Nome;

                string cliente = ClienteCompra.Single();

                

                var ClienteCompraQuantidade =
                    from c in basedados.DetalheCompra
                    where c.ComprasNrCompra == p.NrCompra
                    select c.Quantidade;

                var ClienteCompraDesignacao =
                    from c in basedados.DetalheCompra
                    join f in basedados.Produto
                         on c.ProdutosCodProduto equals f.CodProduto
                    where c.ComprasNrCompra == p.NrCompra && c.ProdutosCodProduto == f.CodProduto
                    select f.Designacao;

                var ClienteCompraPreco =
                    from c in basedados.DetalheCompra
                    join f in basedados.Produto
                         on c.ProdutosCodProduto equals f.CodProduto
                    where c.ComprasNrCompra == p.NrCompra && c.ProdutosCodProduto == f.CodProduto
                    select f.Preco;

                dados_fatura[] dados = new dados_fatura[Convert.ToInt32(ClienteCompraQuantidade.Count())];

                int n = 0;
                foreach (var i in ClienteCompraQuantidade)
                {
                    
                    dados[n].quantidade_produto = (int)i;
                    n++;
                }

                n = 0;
                foreach (var i in ClienteCompraDesignacao)
                {
                    dados[n].nome_produto = (string)i;
                    n++;
                }

                n = 0;
                foreach (var i in ClienteCompraPreco)
                {
                    dados[n].preco_produto = (float)i;
                    n++;
                }

                StreamWriter ficheiro = new StreamWriter(@"C:Recibo da Compra número" + p.NrCompra + ".txt", false, Encoding.Default);
                ficheiro.WriteLine("Numero da Compra: " + p.NrCompra);
                ficheiro.WriteLine("Data da compra: " + p.Data);
                ficheiro.WriteLine("Sr(a)." + ClienteCompra.Single());
                ficheiro.WriteLine("Utilizou cartão: " + p.UtilizouCartao);
                ficheiro.WriteLine("Itens comprados:");
                for (int i = 0; i < Convert.ToInt32(ClienteCompraQuantidade.Count()); i++)
                {
                    preco = 0;
                    preco = dados[i].quantidade_produto * dados[i].preco_produto;

                    precototal = precototal + preco;

                    ficheiro.WriteLine("         " + dados[i].quantidade_produto + "| " + dados[i].nome_produto + "\t\t|" + preco + "€");
                }
                ficheiro.WriteLine("                                        Total: " + precototal + "€");
                ficheiro.Dispose();

                MessageBox.Show("Recibo da Compra número " + p.NrCompra + " criado com sucesso");
            }
        }

        struct dados_fatura
        {
            public string nome_produto;
            public int quantidade_produto;
            public float preco_produto;
        }

    }
}
