
namespace Projeto_DesenvolvimentoAplicacoes
{
    partial class gestaoDeProdutosVendidos
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
            System.Windows.Forms.Label labelid;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestaoDeProdutosVendidos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEscolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarProduto = new System.Windows.Forms.ListBox();
            this.Gproduto = new System.Windows.Forms.GroupBox();
            this.Ppreco = new System.Windows.Forms.NumericUpDown();
            this.Pdesignacao = new System.Windows.Forms.TextBox();
            this.Pidtipo = new System.Windows.Forms.NumericUpDown();
            this.Pstock = new System.Windows.Forms.NumericUpDown();
            this.Gtipo = new System.Windows.Forms.GroupBox();
            this.Ttipo = new System.Windows.Forms.TextBox();
            this.AdicionarPessoa = new System.Windows.Forms.Button();
            this.Produto = new System.Windows.Forms.Button();
            this.TipoProduto = new System.Windows.Forms.Button();
            this.GRemAlt = new System.Windows.Forms.GroupBox();
            this.alterar = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.idalterar = new System.Windows.Forms.NumericUpDown();
            this.comopreencher = new System.Windows.Forms.Button();
            this.idremover = new System.Windows.Forms.NumericUpDown();
            labelid = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Gproduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ppreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pidtipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pstock)).BeginInit();
            this.Gtipo.SuspendLayout();
            this.GRemAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idalterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idremover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new System.Drawing.Point(12, 98);
            labelid.Name = "labelid";
            labelid.Size = new System.Drawing.Size(38, 13);
            labelid.TabIndex = 35;
            labelid.Text = "Stock:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(12, 46);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(38, 13);
            label16.TabIndex = 41;
            label16.Text = "Preço:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(12, 21);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(67, 13);
            label22.TabIndex = 33;
            label22.Text = "Designação:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 13);
            label1.TabIndex = 66;
            label1.Text = "Id Tipo Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 21);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 37;
            label3.Text = "Tipo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(7, 16);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(75, 13);
            label13.TabIndex = 83;
            label13.Text = "Id para alterar:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(5, 41);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(84, 13);
            label12.TabIndex = 72;
            label12.Text = "Id para remover:";
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
            // MostrarProduto
            // 
            this.MostrarProduto.FormattingEnabled = true;
            this.MostrarProduto.HorizontalScrollbar = true;
            this.MostrarProduto.Location = new System.Drawing.Point(4, 271);
            this.MostrarProduto.Name = "MostrarProduto";
            this.MostrarProduto.Size = new System.Drawing.Size(765, 264);
            this.MostrarProduto.TabIndex = 69;
            // 
            // Gproduto
            // 
            this.Gproduto.Controls.Add(this.Ppreco);
            this.Gproduto.Controls.Add(this.Pdesignacao);
            this.Gproduto.Controls.Add(this.Pidtipo);
            this.Gproduto.Controls.Add(label1);
            this.Gproduto.Controls.Add(this.Pstock);
            this.Gproduto.Controls.Add(labelid);
            this.Gproduto.Controls.Add(label16);
            this.Gproduto.Controls.Add(label22);
            this.Gproduto.Location = new System.Drawing.Point(6, 23);
            this.Gproduto.Name = "Gproduto";
            this.Gproduto.Size = new System.Drawing.Size(535, 238);
            this.Gproduto.TabIndex = 70;
            this.Gproduto.TabStop = false;
            this.Gproduto.Text = "Produto";
            this.Gproduto.Visible = false;
            // 
            // Ppreco
            // 
            this.Ppreco.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ppreco.Location = new System.Drawing.Point(95, 44);
            this.Ppreco.Name = "Ppreco";
            this.Ppreco.Size = new System.Drawing.Size(100, 20);
            this.Ppreco.TabIndex = 71;
            // 
            // Pdesignacao
            // 
            this.Pdesignacao.Location = new System.Drawing.Point(95, 18);
            this.Pdesignacao.Name = "Pdesignacao";
            this.Pdesignacao.Size = new System.Drawing.Size(100, 20);
            this.Pdesignacao.TabIndex = 68;
            // 
            // Pidtipo
            // 
            this.Pidtipo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Pidtipo.Location = new System.Drawing.Point(95, 70);
            this.Pidtipo.Name = "Pidtipo";
            this.Pidtipo.Size = new System.Drawing.Size(100, 20);
            this.Pidtipo.TabIndex = 67;
            // 
            // Pstock
            // 
            this.Pstock.Location = new System.Drawing.Point(95, 96);
            this.Pstock.Name = "Pstock";
            this.Pstock.Size = new System.Drawing.Size(100, 20);
            this.Pstock.TabIndex = 64;
            // 
            // Gtipo
            // 
            this.Gtipo.Controls.Add(label3);
            this.Gtipo.Controls.Add(this.Ttipo);
            this.Gtipo.Location = new System.Drawing.Point(6, 23);
            this.Gtipo.Name = "Gtipo";
            this.Gtipo.Size = new System.Drawing.Size(535, 237);
            this.Gtipo.TabIndex = 69;
            this.Gtipo.TabStop = false;
            this.Gtipo.Text = "Tipo Produto";
            this.Gtipo.Visible = false;
            // 
            // Ttipo
            // 
            this.Ttipo.Location = new System.Drawing.Point(49, 18);
            this.Ttipo.Name = "Ttipo";
            this.Ttipo.Size = new System.Drawing.Size(146, 20);
            this.Ttipo.TabIndex = 38;
            // 
            // AdicionarPessoa
            // 
            this.AdicionarPessoa.Location = new System.Drawing.Point(4, 533);
            this.AdicionarPessoa.Name = "AdicionarPessoa";
            this.AdicionarPessoa.Size = new System.Drawing.Size(765, 31);
            this.AdicionarPessoa.TabIndex = 68;
            this.AdicionarPessoa.Text = "Adicionar";
            this.AdicionarPessoa.UseVisualStyleBackColor = true;
            this.AdicionarPessoa.Click += new System.EventHandler(this.AdicionarPessoa_Click);
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(647, 23);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(122, 23);
            this.Produto.TabIndex = 79;
            this.Produto.Text = "Produto";
            this.Produto.UseVisualStyleBackColor = true;
            this.Produto.Click += new System.EventHandler(this.Produto_Click);
            // 
            // TipoProduto
            // 
            this.TipoProduto.Location = new System.Drawing.Point(647, 53);
            this.TipoProduto.Name = "TipoProduto";
            this.TipoProduto.Size = new System.Drawing.Size(122, 23);
            this.TipoProduto.TabIndex = 78;
            this.TipoProduto.Text = "Tipo Produto";
            this.TipoProduto.UseVisualStyleBackColor = true;
            this.TipoProduto.Click += new System.EventHandler(this.TipoProduto_Click);
            // 
            // GRemAlt
            // 
            this.GRemAlt.Controls.Add(label13);
            this.GRemAlt.Controls.Add(this.alterar);
            this.GRemAlt.Controls.Add(this.remover);
            this.GRemAlt.Controls.Add(this.idalterar);
            this.GRemAlt.Controls.Add(label12);
            this.GRemAlt.Controls.Add(this.comopreencher);
            this.GRemAlt.Controls.Add(this.idremover);
            this.GRemAlt.Location = new System.Drawing.Point(541, 197);
            this.GRemAlt.Name = "GRemAlt";
            this.GRemAlt.Size = new System.Drawing.Size(231, 64);
            this.GRemAlt.TabIndex = 90;
            this.GRemAlt.TabStop = false;
            this.GRemAlt.Visible = false;
            // 
            // alterar
            // 
            this.alterar.BackColor = System.Drawing.Color.Transparent;
            this.alterar.Location = new System.Drawing.Point(148, 11);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(58, 23);
            this.alterar.TabIndex = 84;
            this.alterar.Text = "alterar";
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // remover
            // 
            this.remover.BackColor = System.Drawing.Color.Tomato;
            this.remover.Location = new System.Drawing.Point(148, 36);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(81, 23);
            this.remover.TabIndex = 77;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // idalterar
            // 
            this.idalterar.Location = new System.Drawing.Point(90, 13);
            this.idalterar.Name = "idalterar";
            this.idalterar.Size = new System.Drawing.Size(59, 20);
            this.idalterar.TabIndex = 85;
            // 
            // comopreencher
            // 
            this.comopreencher.BackColor = System.Drawing.Color.Black;
            this.comopreencher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comopreencher.Location = new System.Drawing.Point(205, 11);
            this.comopreencher.Name = "comopreencher";
            this.comopreencher.Size = new System.Drawing.Size(24, 23);
            this.comopreencher.TabIndex = 86;
            this.comopreencher.Text = " i";
            this.comopreencher.UseVisualStyleBackColor = false;
            this.comopreencher.Click += new System.EventHandler(this.comopreencher_Click);
            // 
            // idremover
            // 
            this.idremover.Location = new System.Drawing.Point(90, 38);
            this.idremover.Name = "idremover";
            this.idremover.Size = new System.Drawing.Size(59, 20);
            this.idremover.TabIndex = 78;
            // 
            // gestaoDeProdutosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(774, 569);
            this.Controls.Add(this.GRemAlt);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.Gtipo);
            this.Controls.Add(this.TipoProduto);
            this.Controls.Add(this.MostrarProduto);
            this.Controls.Add(this.Gproduto);
            this.Controls.Add(this.AdicionarPessoa);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestaoDeProdutosVendidos";
            this.Text = "gestaoDeProdutosVendidos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gproduto.ResumeLayout(false);
            this.Gproduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ppreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pidtipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pstock)).EndInit();
            this.Gtipo.ResumeLayout(false);
            this.Gtipo.PerformLayout();
            this.GRemAlt.ResumeLayout(false);
            this.GRemAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idalterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idremover)).EndInit();
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
        private System.Windows.Forms.ListBox MostrarProduto;
        private System.Windows.Forms.GroupBox Gproduto;
        private System.Windows.Forms.NumericUpDown Pstock;
        private System.Windows.Forms.Button AdicionarPessoa;
        private System.Windows.Forms.Button Produto;
        private System.Windows.Forms.Button TipoProduto;
        private System.Windows.Forms.TextBox Pdesignacao;
        private System.Windows.Forms.NumericUpDown Pidtipo;
        private System.Windows.Forms.GroupBox Gtipo;
        private System.Windows.Forms.TextBox Ttipo;
        private System.Windows.Forms.GroupBox GRemAlt;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.NumericUpDown idalterar;
        private System.Windows.Forms.Button comopreencher;
        private System.Windows.Forms.NumericUpDown idremover;
        private System.Windows.Forms.NumericUpDown Ppreco;
    }
}