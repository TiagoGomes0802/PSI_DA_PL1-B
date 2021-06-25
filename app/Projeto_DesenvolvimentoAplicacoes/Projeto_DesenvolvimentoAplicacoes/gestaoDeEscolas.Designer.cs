
namespace Projeto_DesenvolvimentoAplicacoes
{
    partial class gestaoDeEscolas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label localidadeLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestaoDeEscolas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEscolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codPostal = new System.Windows.Forms.TextBox();
            this.localidade = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.morada = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.remover = new System.Windows.Forms.Button();
            this.MostrarEscola = new System.Windows.Forms.ListBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.idalterar = new System.Windows.Forms.NumericUpDown();
            this.comopreencher = new System.Windows.Forms.Button();
            codPostalLabel = new System.Windows.Forms.Label();
            localidadeLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idalterar)).BeginInit();
            this.SuspendLayout();
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Location = new System.Drawing.Point(12, 150);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(61, 13);
            codPostalLabel.TabIndex = 6;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // localidadeLabel
            // 
            localidadeLabel.AutoSize = true;
            localidadeLabel.Location = new System.Drawing.Point(12, 177);
            localidadeLabel.Name = "localidadeLabel";
            localidadeLabel.Size = new System.Drawing.Size(62, 13);
            localidadeLabel.TabIndex = 10;
            localidadeLabel.Text = "Localidade:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(12, 124);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 12;
            mailLabel.Text = "Mail:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(12, 65);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 14;
            moradaLabel.Text = "Morada:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 37);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 95);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 18;
            telefoneLabel.Text = "Telefone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(553, 177);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(84, 13);
            label12.TabIndex = 70;
            label12.Text = "Id para remover:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(553, 152);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(75, 13);
            label13.TabIndex = 91;
            label13.Text = "Id para alterar:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeClientesToolStripMenuItem,
            this.gestãoDeVendasToolStripMenuItem,
            this.gestãoDeEventosToolStripMenuItem,
            this.gestãoDeProdutosVendidosToolStripMenuItem,
            this.gestãoDeEscolasToolStripMenuItem,
            this.gestãoDeAnimadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestãoDeClientesToolStripMenuItem
            // 
            this.gestãoDeClientesToolStripMenuItem.Name = "gestãoDeClientesToolStripMenuItem";
            this.gestãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestãoDeClientesToolStripMenuItem.Text = "Gestão de Clientes";
            this.gestãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeClientesToolStripMenuItem_Click);
            // 
            // gestãoDeVendasToolStripMenuItem
            // 
            this.gestãoDeVendasToolStripMenuItem.Name = "gestãoDeVendasToolStripMenuItem";
            this.gestãoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.gestãoDeVendasToolStripMenuItem.Text = "Gestão de Vendas";
            this.gestãoDeVendasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeVendasToolStripMenuItem_Click);
            // 
            // gestãoDeEventosToolStripMenuItem
            // 
            this.gestãoDeEventosToolStripMenuItem.Name = "gestãoDeEventosToolStripMenuItem";
            this.gestãoDeEventosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestãoDeEventosToolStripMenuItem.Text = "Gestão de Eventos";
            this.gestãoDeEventosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeEventosToolStripMenuItem_Click);
            // 
            // gestãoDeProdutosVendidosToolStripMenuItem
            // 
            this.gestãoDeProdutosVendidosToolStripMenuItem.Name = "gestãoDeProdutosVendidosToolStripMenuItem";
            this.gestãoDeProdutosVendidosToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.gestãoDeProdutosVendidosToolStripMenuItem.Text = "Gestão de Produtos Vendidos";
            this.gestãoDeProdutosVendidosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProdutosVendidosToolStripMenuItem_Click);
            // 
            // gestãoDeEscolasToolStripMenuItem
            // 
            this.gestãoDeEscolasToolStripMenuItem.Name = "gestãoDeEscolasToolStripMenuItem";
            this.gestãoDeEscolasToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestãoDeEscolasToolStripMenuItem.Text = "Gestão de Escolas";
            this.gestãoDeEscolasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeEscolasToolStripMenuItem_Click);
            // 
            // gestãoDeAnimadoresToolStripMenuItem
            // 
            this.gestãoDeAnimadoresToolStripMenuItem.Name = "gestãoDeAnimadoresToolStripMenuItem";
            this.gestãoDeAnimadoresToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.gestãoDeAnimadoresToolStripMenuItem.Text = "Gestão de Animadores";
            this.gestãoDeAnimadoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAnimadoresToolStripMenuItem_Click);
            // 
            // escolaBindingSource
            // 
            this.escolaBindingSource.DataSource = typeof(Projeto_DesenvolvimentoAplicacoes.Escola);
            // 
            // codPostal
            // 
            this.codPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "CodPostal", true));
            this.codPostal.Location = new System.Drawing.Point(80, 147);
            this.codPostal.Name = "codPostal";
            this.codPostal.Size = new System.Drawing.Size(100, 20);
            this.codPostal.TabIndex = 7;
            // 
            // localidade
            // 
            this.localidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Localidade", true));
            this.localidade.Location = new System.Drawing.Point(80, 174);
            this.localidade.Name = "localidade";
            this.localidade.Size = new System.Drawing.Size(100, 20);
            this.localidade.TabIndex = 11;
            // 
            // mail
            // 
            this.mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Mail", true));
            this.mail.Location = new System.Drawing.Point(80, 121);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 13;
            // 
            // morada
            // 
            this.morada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Morada", true));
            this.morada.Location = new System.Drawing.Point(80, 62);
            this.morada.Name = "morada";
            this.morada.Size = new System.Drawing.Size(100, 20);
            this.morada.TabIndex = 15;
            // 
            // nome
            // 
            this.nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Nome", true));
            this.nome.Location = new System.Drawing.Point(80, 34);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 17;
            // 
            // telefone
            // 
            this.telefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Telefone", true));
            this.telefone.Location = new System.Drawing.Point(80, 92);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 19;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(636, 174);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 20);
            this.id.TabIndex = 72;
            // 
            // remover
            // 
            this.remover.BackColor = System.Drawing.Color.Tomato;
            this.remover.Location = new System.Drawing.Point(694, 172);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(80, 23);
            this.remover.TabIndex = 71;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // MostrarEscola
            // 
            this.MostrarEscola.FormattingEnabled = true;
            this.MostrarEscola.HorizontalScrollbar = true;
            this.MostrarEscola.Location = new System.Drawing.Point(5, 208);
            this.MostrarEscola.Name = "MostrarEscola";
            this.MostrarEscola.Size = new System.Drawing.Size(765, 329);
            this.MostrarEscola.TabIndex = 69;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(5, 535);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(765, 31);
            this.Adicionar.TabIndex = 68;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // alterar
            // 
            this.alterar.BackColor = System.Drawing.Color.Transparent;
            this.alterar.Location = new System.Drawing.Point(694, 147);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(58, 23);
            this.alterar.TabIndex = 92;
            this.alterar.Text = "alterar";
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Click += new System.EventHandler(this.alterar_Click_1);
            // 
            // idalterar
            // 
            this.idalterar.Location = new System.Drawing.Point(636, 149);
            this.idalterar.Name = "idalterar";
            this.idalterar.Size = new System.Drawing.Size(59, 20);
            this.idalterar.TabIndex = 93;
            // 
            // comopreencher
            // 
            this.comopreencher.BackColor = System.Drawing.Color.Black;
            this.comopreencher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comopreencher.Location = new System.Drawing.Point(751, 147);
            this.comopreencher.Name = "comopreencher";
            this.comopreencher.Size = new System.Drawing.Size(24, 23);
            this.comopreencher.TabIndex = 94;
            this.comopreencher.Text = " i";
            this.comopreencher.UseVisualStyleBackColor = false;
            this.comopreencher.Click += new System.EventHandler(this.comopreencher_Click_1);
            // 
            // gestaoDeEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(774, 571);
            this.Controls.Add(label13);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.idalterar);
            this.Controls.Add(this.comopreencher);
            this.Controls.Add(this.id);
            this.Controls.Add(label12);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.MostrarEscola);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostal);
            this.Controls.Add(localidadeLabel);
            this.Controls.Add(this.localidade);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mail);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.morada);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nome);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestaoDeEscolas";
            this.Text = "gestaoDeEscolas";
            this.Load += new System.EventHandler(this.gestaoDeEscolas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idalterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProdutosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEscolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAnimadoresToolStripMenuItem;
        private System.Windows.Forms.BindingSource escolaBindingSource;
        private System.Windows.Forms.TextBox codPostal;
        private System.Windows.Forms.TextBox localidade;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox morada;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.ListBox MostrarEscola;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.NumericUpDown idalterar;
        private System.Windows.Forms.Button comopreencher;
    }
}