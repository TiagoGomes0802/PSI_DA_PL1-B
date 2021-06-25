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
    public partial class gestaoDePessoas : Form
    {
        addDB.AdicionarClientes clientes = new addDB.AdicionarClientes();
        addDB.AdicionarFilho filho = new addDB.AdicionarFilho();
        
        private string QualAdicionar = "";

        public gestaoDePessoas()
        {
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

        private void AdicionarPessoa_Click(object sender, EventArgs e)
        {
            if(QualAdicionar == "cliente")
            {
                try
                {
                    clientes.AddCliente(Cnome.Text, Cmorada.Text, Clocalidade.Text, CcodPostal.Text, Ctelemovel.Text, Ctelefone.Text, Cmail.Text, CnrCartao.Text, CvalorOferta.Text);
                    MostrarPessoa.DataSource = clientes.GetCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cnome.Clear();
                Cmorada.Clear();
                Clocalidade.Clear();
                CcodPostal.Clear();
                Ctelemovel.Clear();
                Ctelefone.Clear();
                Cmail.Clear();
                CnrCartao.Clear();
                CvalorOferta.Clear();
            }
            if (QualAdicionar == "filho")
            {
                try
                {
                    filho.AddFilho(Fnome.Text, Fmorada.Text, Flocalidade.Text, FcodPostal.Text, Ftelemovel.Text, Ftelefone.Text, Fmail.Text, Fsexo.Text, Fdatanascimento.SelectionStart, Convert.ToInt32(FidEscola.Value), Convert.ToInt32(FidProgenitor.Value));
                    MostrarPessoa.DataSource = filho.GetFilho();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Fnome.Clear();
                Fmorada.Clear();
                Flocalidade.Clear();
                FcodPostal.Clear();
                Ftelemovel.Clear();
                Ftelefone.Clear();
                Fmail.Clear();
                Fsexo.SelectedIndex = -1;
                Fdatanascimento.ShowToday = true;
                FidEscola.Value = 0;
                FidProgenitor.Value = 0;
            }        
        }

        private void AdicionarCliente_Click(object sender, EventArgs e)
        {
            groupBoxCliente.Visible = true;
            groupBoxFilho.Visible = false;
            AdicionarPessoa.Visible = true;
            GRemAlt.Visible = true;

            Cnome.Clear();
            Cmorada.Clear();
            Clocalidade.Clear();
            CcodPostal.Clear();
            Ctelemovel.Clear();
            Ctelefone.Clear();
            Cmail.Clear();
            CnrCartao.Clear();
            CvalorOferta.Clear();

            MostrarPessoa.DataSource = clientes.GetCliente();

            QualAdicionar = "cliente";
        }

        private void AdicionarFilho_Click(object sender, EventArgs e)
        {
            groupBoxFilho.Visible = true;
            groupBoxCliente.Visible = false;
            AdicionarPessoa.Visible = true;
            GRemAlt.Visible = true;

            Fnome.Clear();
            Fmorada.Clear();
            Flocalidade.Clear();
            FcodPostal.Clear();
            Ftelemovel.Clear();
            Ftelefone.Clear();
            Fmail.Clear();
            Fsexo.SelectedIndex = -1;
            Fdatanascimento.ShowToday = true;
            FidEscola.Value = 0;
            FidProgenitor.Value = 0;

            MostrarPessoa.DataSource = filho.GetFilho();

            QualAdicionar = "filho";
        }  

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "cliente")
            {
                try
                {
                    clientes.AltCliente(Convert.ToInt32(idalterar.Value), Cnome.Text, Cmorada.Text, Clocalidade.Text, CcodPostal.Text, Ctelemovel.Text, Ctelefone.Text, Cmail.Text, CnrCartao.Text, CvalorOferta.Text);
                    MostrarPessoa.DataSource = clientes.GetCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                idalterar.Value = 0;
                Cnome.Clear();
                Cmorada.Clear();
                Clocalidade.Clear();
                CcodPostal.Clear();
                Ctelemovel.Clear();
                Ctelefone.Clear();
                Cmail.Clear();
                CnrCartao.Clear();
                CvalorOferta.Clear();
            }
            if (QualAdicionar == "filho")
            {
                try
                {
                    filho.AltFilho(Convert.ToInt32(idalterar.Value), Fnome.Text, Fmorada.Text, Flocalidade.Text, FcodPostal.Text, Ftelemovel.Text, Ftelefone.Text, Fmail.Text, Fsexo.Text, Fdatanascimento.SelectionStart, Convert.ToInt32(FidEscola.Value), Convert.ToInt32(FidProgenitor.Value));
                    MostrarPessoa.DataSource = filho.GetFilho();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                idalterar.Value = 0;
                Fnome.Clear();
                Fmorada.Clear();
                Flocalidade.Clear();
                FcodPostal.Clear();
                Ftelemovel.Clear();
                Ftelefone.Clear();
                Fmail.Clear();
                Fsexo.SelectedIndex = -1;
                Fdatanascimento.ShowToday = true;
                FidEscola.Value = 0;
                FidProgenitor.Value = 0;
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "cliente")
            {
                try
                {
                    clientes.RemCliente(Convert.ToInt32(id.Value));
                    MostrarPessoa.DataSource = clientes.GetCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao a eliminar este cliente(Verifique se o cliente não está associado a algum filho ou a alguma compra!)");
                }
            }
            if (QualAdicionar == "filho")
            {
                try
                {
                    filho.RemFilho(Convert.ToInt32(id.Value));
                    MostrarPessoa.DataSource = filho.GetFilho();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao a eliminar este filho(Verifique se o filho não está inscrito em nenhum evento!)");
                }
            }

            
        }
    }
}
