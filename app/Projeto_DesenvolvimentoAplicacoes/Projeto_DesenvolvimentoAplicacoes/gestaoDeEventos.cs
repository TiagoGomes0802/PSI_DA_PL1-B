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
    public partial class gestaoDeEventos : Form
    {
        addDB.AdicionarEvento eventos = new addDB.AdicionarEvento();
        addDB.AdicionarInscricao inscricaoFilho = new addDB.AdicionarInscricao();
        addDB.AdicionarParticipacao participacaoEscola = new addDB.AdicionarParticipacao();
        addDB.AdicionarColaboracao colaboracao = new addDB.AdicionarColaboracao();

        private string QualAdicionar = "";

        BD_Projeto_DAContainer basedados;

        public gestaoDeEventos()
        {
            InitializeComponent();
            basedados = new BD_Projeto_DAContainer();

            Edata.Format = DateTimePickerFormat.Custom;
            Edata.CustomFormat = "dd-MM-yyyy HH:00:00";
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

        private void Adicionar_Click(object sender, EventArgs e)
        {

            if (QualAdicionar == "evento")
            {
                try
                {
                    eventos.AddEvento(Edescricao.Text, Elocal.Text, Edata.Value, Convert.ToInt32(Elimite.Value), Convert.ToInt32(EidadeMinima.Value), Convert.ToInt32(EidadeMaxima.Value), Etipo.Text);
                    Mostrar.DataSource = eventos.GetEvento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Edescricao.Clear();
                Elocal.Clear();
                Edata.Value = DateTime.Now;
                Elimite.Value = 0;
                EidadeMinima.Value = 0;
                EidadeMaxima.Value = 0;
                Etipo.Clear();

            }
            if (QualAdicionar == "inscricao")
            {
                var idadeI =
                    from p in basedados.Evento
                    where p.NrEvento == Iidevento.Value
                    select p.IdadeInferior;

                var idadeS =
                    from p in basedados.Evento
                    where p.NrEvento == Iidevento.Value
                    select p.IdadeSuperior;

                var IDADE =
                    from p in basedados.Pessoa.OfType<Filho>()
                    where p.IdPessoa == Iidfilho.Value
                    select p.DataNascimento;

                var nparticipantesmax =
                    from p in basedados.Evento
                    where p.NrEvento == Iidevento.Value
                    select p.LimiteParticipantes;

                var participantesInscritos =
                    from p in basedados.Inscricao
                    where p.EventosNrEvento == Iidevento.Value
                    select p;

                int idadeFilho = DateTime.Now.Year - IDADE.Single().Year;
                if (DateTime.Now.DayOfYear < IDADE.Single().DayOfYear)
                {
                    idadeFilho = idadeFilho - 1;
                }

                if (idadeI.First() <= idadeFilho && idadeS.Single() >= idadeFilho)
                {
                    if (participantesInscritos.Count() < nparticipantesmax.Single())
                    {
                        try
                        {
                            bool Iconfirmar = true;
                            inscricaoFilho.AddInscricao(Iconfirmar, Convert.ToInt32(Iidfilho.Value), Convert.ToInt32(Iidevento.Value));
                            Mostrar.DataSource = inscricaoFilho.GetInscricao();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Evento encontra se cheio");
                    }
                }
                else
                {
                    MessageBox.Show("O Filho não tem idade para participar no Evento");
                }

                Iidfilho.Value = 0;
                Iidevento.Value = 0;
            }
            if (QualAdicionar == "participacao")
            {
                try
                {
                    participacaoEscola.AddParticipacao(Convert.ToInt32(PidEscola.Value), Convert.ToInt32(PidEvento.Value));
                    Mostrar.DataSource = participacaoEscola.GetParticipacao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                PidEscola.Value = 0;
                PidEvento.Value = 0;
            }
            if (QualAdicionar == "colaboracao")
            {
                try
                {
                    colaboracao.AddColaboracao(Convert.ToInt32(CidEvento.Value), Convert.ToInt32(CidAnimador.Value));
                    Mostrar.DataSource = colaboracao.GetColaboracao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                CidAnimador.Value = 0;
                CidEvento.Value = 0;
            }
        }

        private void AdicionarEvento_Click(object sender, EventArgs e)
        {
            Geventos.Visible = true;
            Gfilho.Visible = false;
            Gescola.Visible = false;
            Ganimador.Visible = false;

            GRem.Visible = true;
            GAlt.Visible = true;

            QualAdicionar = "evento";

            Edescricao.Clear();
            Elocal.Clear();
            Edata.Value = DateTime.Now;
            Elimite.Value = 0;
            EidadeMinima.Value = 0;
            EidadeMaxima.Value = 0;
            Etipo.Clear();

            Mostrar.DataSource = eventos.GetEvento();
        }
        private void AdicionarFilho_Click(object sender, EventArgs e)
        {
            Geventos.Visible = false;
            Gfilho.Visible = true;
            Gescola.Visible = false;
            Ganimador.Visible = false;

            GRem.Visible = true;
            GAlt.Visible = false;

            QualAdicionar = "inscricao";

            Iidfilho.Value = 0;
            Iidevento.Value = 0;

            Mostrar.DataSource = inscricaoFilho.GetInscricao();
        }

        private void AdicionarEscola_Click(object sender, EventArgs e)
        {
            Geventos.Visible = false;
            Gfilho.Visible = false;
            Gescola.Visible = true;
            Ganimador.Visible = false;

            GRem.Visible = true;
            GAlt.Visible = false;

            QualAdicionar = "participacao";

            PidEscola.Value = 0;
            PidEvento.Value = 0;

            Mostrar.DataSource = participacaoEscola.GetParticipacao();
        }

        private void AdicionarColaboracao_Click(object sender, EventArgs e)
        {
            Geventos.Visible = false;
            Gfilho.Visible = false;
            Gescola.Visible = false;
            Ganimador.Visible = true;

            GRem.Visible = true;
            GAlt.Visible = false;

            QualAdicionar = "colaboracao";

            CidAnimador.Value = 0;
            CidEvento.Value = 0;

            Mostrar.DataSource = colaboracao.GetColaboracao();
        }

        private void comopreencher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!Preencha todos os campos, o \"id para alterar\" e clique em alterar!");
        }

        private void remover_Click(object sender, EventArgs e)
        {
            
            if (QualAdicionar == "evento")
            {
                try
                {
                    eventos.RemEvento(Convert.ToInt32(idremover.Value));
                    Mostrar.DataSource = eventos.GetEvento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao a eliminar este Evento(Verifique o evento não está associado a algo!)");
                }

            }
            if (QualAdicionar == "inscricao")
            {
                try
                {
                    var n =
                    from p in basedados.Inscricao
                    where p.EventosNrEvento == idremover.Value
                    select p;

                    for (int i = 0; i <= n.Count(); i++)
                    {
                        inscricaoFilho.RemInscricao(Convert.ToInt32(idremover.Value));
                    }
                    
                    Mostrar.DataSource = inscricaoFilho.GetInscricao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (QualAdicionar == "participacao")
            {
                try
                {
                    var n =
                    from p in basedados.Participacao
                    where p.NrEvento == idremover.Value
                    select p;

                    for (int i = 0; i <= n.Count(); i++)
                    {
                        participacaoEscola.RemParticipacao(Convert.ToInt32(idremover.Value));
                    }
                    Mostrar.DataSource = participacaoEscola.GetParticipacao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (QualAdicionar == "colaboracao")
            {
                try
                {
                    var n =
                    from p in basedados.Colaboracao
                    where p.NrEvento == idremover.Value
                    select p;

                    for (int i = 0; i <= n.Count(); i++)
                    {
                        colaboracao.RemColaboracao(Convert.ToInt32(idremover.Value));
                    }
                    Mostrar.DataSource = colaboracao.GetColaboracao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            try
            {
                eventos.AltEvento(Convert.ToInt32(idalterar.Value), Edescricao.Text, Elocal.Text, Edata.Value, Convert.ToInt32(Elimite.Value), Convert.ToInt32(EidadeMinima.Value), Convert.ToInt32(EidadeMaxima.Value), Etipo.Text);
                Mostrar.DataSource = eventos.GetEvento();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idalterar.Value = 0;
            Edescricao.Clear();
            Elocal.Clear();
            Edata.Value = DateTime.Now;
            Elimite.Value = 0;
            EidadeMinima.Value = 0;
            EidadeMaxima.Value = 0;
            Etipo.Clear();
        }

        private void ficha_Inscricao_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "evento")
            {
                Evento p = (Evento)Mostrar.SelectedItem;

                StreamWriter ficheiro = new StreamWriter(@"C:Ficha de incricao Evento número " + p.NrEvento + ".txt", false, Encoding.Default);
                ficheiro.WriteLine("Numero do Evento: " + p.NrEvento);
                ficheiro.WriteLine("Tipo de Evento: " + p.TipoEvento);
                ficheiro.WriteLine("Nome do Participante: __________________________________");
                ficheiro.WriteLine("Idade do participate: __________________________________(o seu participante tem que ter uma idade minima de " + p.IdadeInferior + " anos e uma idade maxima de " + p.IdadeSuperior + " anos)");
                ficheiro.WriteLine("Contacto telefonico:  __________________________________");
                ficheiro.WriteLine("| Menino | Menina |(Risque a opção errada)");
                ficheiro.WriteLine("Descrição: " + p.Descricao);
                ficheiro.WriteLine("Local: " + p.Local);
                ficheiro.WriteLine("Data e Hora: " + p.DataHora);
                ficheiro.WriteLine("Limite de participantes: " + p.LimiteParticipantes + " (Caso o evento já esteja cheio irá ser contactado)");
                ficheiro.Dispose();

                MessageBox.Show("Ficha de inscrição criada com sucesso");
            }
        }

        private void Filhos_Inscritos_Click(object sender, EventArgs e)
        {
            if (QualAdicionar == "evento")
            {
                Evento p = (Evento)Mostrar.SelectedItem;

                var participantesI =
                    from r in basedados.Inscricao
                    join f in basedados.Pessoa.OfType<Filho>()
                        on r.FilhoIdPessoa equals f.IdPessoa
                    where r.EventosNrEvento == p.NrEvento
                    select f.Nome;

                StreamWriter ficheiro = new StreamWriter(@"C:Lista de pessoas já inscritas " + p.NrEvento + ".txt", false, Encoding.Default);
                ficheiro.WriteLine("Numero do Evento: " + p.NrEvento);
                ficheiro.WriteLine("Tipo de Evento: " + p.TipoEvento);
                ficheiro.WriteLine("Pessoas inscritas para o evento: ");
                ficheiro.WriteLine("    " + participantesI.Count());
                foreach (var i in participantesI)
                {
                    ficheiro.WriteLine(i);
                }
                ficheiro.Dispose();

                MessageBox.Show("Ficha de inscrição criada com sucesso");
            }
        }
    }
}
