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
    public partial class gestaoDeEscolas : Form
    {
        addDB.AdicionarEscola escola = new addDB.AdicionarEscola();

        private BD_Projeto_DAContainer DataBaseDA;
        public gestaoDeEscolas()
        {
            InitializeComponent();
        }

        private void gestaoDeEscolas_Load(object sender, EventArgs e)
        {
            DataBaseDA = new BD_Projeto_DAContainer();
            lerDados();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                escola.AddEscola(nome.Text, morada.Text, telefone.Text, mail.Text, codPostal.Text, localidade.Text);
                DataBaseDA.SaveChanges();
                lerDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            nome.Clear();
            morada.Clear();
            localidade.Clear();
            codPostal.Clear();
            telefone.Clear();
            mail.Clear();
        }

        private void lerDados()
        {
            MostrarEscola.DataSource = escola.GetEscola();
        }

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            try
            {
                escola.AltEscola(Convert.ToInt32(id), nome.Text, morada.Text, localidade.Text, codPostal.Text, telefone.Text, mail.Text);
                MostrarEscola.DataSource = escola.GetEscola();

                id.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            id.Value = 0;

            nome.Clear();
            morada.Clear();
            localidade.Clear();
            codPostal.Clear();
            telefone.Clear();
            mail.Clear();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            try
            {
                escola.RemEscola(Convert.ToInt32(id.Value));
                MostrarEscola.DataSource = escola.GetEscola();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao a eliminar esta escola(Verifique se a escola não está associado a algum evento ou a algum filho!)");
            }
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                escola.AddEscola(nome.Text, morada.Text, localidade.Text, codPostal.Text, telefone.Text, mail.Text);
                MostrarEscola.DataSource = escola.GetEscola();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            nome.Clear();
            morada.Clear();
            localidade.Clear();
            codPostal.Clear();
            telefone.Clear();
            mail.Clear();
        }

        private void alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                escola.AltEscola(Convert.ToInt32(idalterar.Value), nome.Text, morada.Text, localidade.Text, codPostal.Text, telefone.Text, mail.Text);
                MostrarEscola.DataSource = escola.GetEscola();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            idalterar.Value = 0;
            nome.Clear();
            morada.Clear();
            localidade.Clear();
            codPostal.Clear();
            telefone.Clear();
            mail.Clear();
        }

        private void comopreencher_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }
    }
}
