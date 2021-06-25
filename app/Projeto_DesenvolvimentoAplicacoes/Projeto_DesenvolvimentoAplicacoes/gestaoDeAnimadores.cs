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
    public partial class gestaoDeAnimadores : Form
    {
        addDB.AdicionarAnimador animador = new addDB.AdicionarAnimador();

        public gestaoDeAnimadores()
        {
            InitializeComponent();

            MostrarPessoa.DataSource = animador.GetAnimador();
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
            try
            {
                animador.AddAnimador(Anome.Text, Amorada.Text, Alocalidade.Text, AcodPostal.Text, Atelemovel.Text, Atelefone.Text, Amail.Text, Aespecialidade.Text);
                MostrarPessoa.DataSource = animador.GetAnimador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Anome.Clear();
            Amorada.Clear();
            Alocalidade.Clear();
            AcodPostal.Clear();
            Atelemovel.Clear();
            Atelefone.Clear();
            Amail.Clear();
            Aespecialidade.Clear();
        }

        private void remover_Click(object sender, EventArgs e)
        {

            try
            {
                animador.RemAnimador(Convert.ToInt32(remover.Value));
                MostrarPessoa.DataSource = animador.GetAnimador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao a eliminar este animador(Verifique se o animador não está associado a algum evento!)");
            }
            remover.Value = 0;

        }

        private void alterar_Click(object sender, EventArgs e)
        {
            try
            {
                animador.AltAnimador(Convert.ToInt32(idalterar.Value), Anome.Text, Amorada.Text, Alocalidade.Text, AcodPostal.Text, Atelemovel.Text, Atelefone.Text, Amail.Text, Aespecialidade.Text);
                MostrarPessoa.DataSource = animador.GetAnimador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idalterar.Value = 0;
            Anome.Clear();
            Amorada.Clear();
            Alocalidade.Clear();
            AcodPostal.Clear();
            Atelemovel.Clear();
            Atelefone.Clear();
            Amail.Clear();
            Aespecialidade.Clear();
        }

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }
    }
}
