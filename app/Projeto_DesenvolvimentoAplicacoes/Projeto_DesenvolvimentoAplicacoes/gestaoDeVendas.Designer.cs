
namespace Projeto_DesenvolvimentoAplicacoes
{
    partial class gestaoDeVendas
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
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label labelIdAlterar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestaoDeVendas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEscolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarCompra = new System.Windows.Forms.ListBox();
            this.Gcompra = new System.Windows.Forms.GroupBox();
            this.Recibo_Venda = new System.Windows.Forms.Button();
            this.Ccodproduto = new System.Windows.Forms.NumericUpDown();
            this.Cidcliente = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cdatanascimento = new System.Windows.Forms.MonthCalendar();
            this.Ccartao = new System.Windows.Forms.CheckBox();
            this.Gdetalhes = new System.Windows.Forms.GroupBox();
            this.Dcodproduto = new System.Windows.Forms.NumericUpDown();
            this.Dnrcompra = new System.Windows.Forms.NumericUpDown();
            this.Dquantidade = new System.Windows.Forms.NumericUpDown();
            this.Adicionar = new System.Windows.Forms.Button();
            this.GRem = new System.Windows.Forms.GroupBox();
            this.remover = new System.Windows.Forms.Button();
            this.idremover = new System.Windows.Forms.NumericUpDown();
            this.Compras = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.GAlt = new System.Windows.Forms.GroupBox();
            this.alterar = new System.Windows.Forms.Button();
            this.idalterar = new System.Windows.Forms.NumericUpDown();
            this.comopreencher = new System.Windows.Forms.Button();
            labelid = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelIdAlterar = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Gcompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ccodproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cidcliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Gdetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dcodproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dnrcompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dquantidade)).BeginInit();
            this.GRem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idremover)).BeginInit();
            this.GAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idalterar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new System.Drawing.Point(15, 17);
            labelid.Name = "labelid";
            labelid.Size = new System.Drawing.Size(56, 13);
            labelid.TabIndex = 35;
            labelid.Text = "ID Cliente:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(15, 70);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(83, 13);
            label16.TabIndex = 41;
            label16.Text = "Codigo Produto:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(15, 44);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(77, 13);
            label22.TabIndex = 33;
            label22.Text = "Utilizou cartão:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 57;
            label1.Text = "Data de compra:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 11);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(84, 13);
            label12.TabIndex = 72;
            label12.Text = "Id para remover:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(15, 30);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(65, 13);
            label10.TabIndex = 83;
            label10.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 13);
            label2.TabIndex = 85;
            label2.Text = "Número da Compra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 13);
            label3.TabIndex = 87;
            label3.Text = "Codigo Produto:";
            // 
            // labelIdAlterar
            // 
            labelIdAlterar.AutoSize = true;
            labelIdAlterar.Location = new System.Drawing.Point(6, 11);
            labelIdAlterar.Name = "labelIdAlterar";
            labelIdAlterar.Size = new System.Drawing.Size(75, 13);
            labelIdAlterar.TabIndex = 79;
            labelIdAlterar.Text = "Id para alterar:";
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
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 3;
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
            // MostrarCompra
            // 
            this.MostrarCompra.FormattingEnabled = true;
            this.MostrarCompra.HorizontalScrollbar = true;
            this.MostrarCompra.Location = new System.Drawing.Point(12, 273);
            this.MostrarCompra.Name = "MostrarCompra";
            this.MostrarCompra.Size = new System.Drawing.Size(765, 264);
            this.MostrarCompra.TabIndex = 59;
            // 
            // Gcompra
            // 
            this.Gcompra.Controls.Add(this.Recibo_Venda);
            this.Gcompra.Controls.Add(this.Ccodproduto);
            this.Gcompra.Controls.Add(this.Cidcliente);
            this.Gcompra.Controls.Add(label1);
            this.Gcompra.Controls.Add(this.groupBox1);
            this.Gcompra.Controls.Add(this.Ccartao);
            this.Gcompra.Controls.Add(labelid);
            this.Gcompra.Controls.Add(label16);
            this.Gcompra.Controls.Add(label22);
            this.Gcompra.Location = new System.Drawing.Point(14, 25);
            this.Gcompra.Name = "Gcompra";
            this.Gcompra.Size = new System.Drawing.Size(535, 238);
            this.Gcompra.TabIndex = 60;
            this.Gcompra.TabStop = false;
            this.Gcompra.Text = "Compra";
            this.Gcompra.Visible = false;
            // 
            // Recibo_Venda
            // 
            this.Recibo_Venda.Location = new System.Drawing.Point(398, 206);
            this.Recibo_Venda.Name = "Recibo_Venda";
            this.Recibo_Venda.Size = new System.Drawing.Size(131, 23);
            this.Recibo_Venda.TabIndex = 94;
            this.Recibo_Venda.Text = "Criar recibo da Compra";
            this.Recibo_Venda.UseVisualStyleBackColor = true;
            this.Recibo_Venda.Click += new System.EventHandler(this.Recibo_Venda_Click);
            // 
            // Ccodproduto
            // 
            this.Ccodproduto.Location = new System.Drawing.Point(98, 68);
            this.Ccodproduto.Name = "Ccodproduto";
            this.Ccodproduto.Size = new System.Drawing.Size(100, 20);
            this.Ccodproduto.TabIndex = 65;
            // 
            // Cidcliente
            // 
            this.Cidcliente.Location = new System.Drawing.Point(98, 15);
            this.Cidcliente.Name = "Cidcliente";
            this.Cidcliente.Size = new System.Drawing.Size(100, 20);
            this.Cidcliente.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cdatanascimento);
            this.groupBox1.Location = new System.Drawing.Point(99, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 136);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Cdatanascimento
            // 
            this.Cdatanascimento.Location = new System.Drawing.Point(-5, -6);
            this.Cdatanascimento.Name = "Cdatanascimento";
            this.Cdatanascimento.TabIndex = 53;
            // 
            // Ccartao
            // 
            this.Ccartao.AutoSize = true;
            this.Ccartao.Location = new System.Drawing.Point(98, 44);
            this.Ccartao.Name = "Ccartao";
            this.Ccartao.Size = new System.Drawing.Size(15, 14);
            this.Ccartao.TabIndex = 43;
            this.Ccartao.UseVisualStyleBackColor = true;
            // 
            // Gdetalhes
            // 
            this.Gdetalhes.Controls.Add(this.Dcodproduto);
            this.Gdetalhes.Controls.Add(label3);
            this.Gdetalhes.Controls.Add(this.Dnrcompra);
            this.Gdetalhes.Controls.Add(label2);
            this.Gdetalhes.Controls.Add(this.Dquantidade);
            this.Gdetalhes.Controls.Add(label10);
            this.Gdetalhes.Location = new System.Drawing.Point(14, 25);
            this.Gdetalhes.Name = "Gdetalhes";
            this.Gdetalhes.Size = new System.Drawing.Size(535, 238);
            this.Gdetalhes.TabIndex = 66;
            this.Gdetalhes.TabStop = false;
            this.Gdetalhes.Text = "Detalhes Compras";
            this.Gdetalhes.Visible = false;
            // 
            // Dcodproduto
            // 
            this.Dcodproduto.Location = new System.Drawing.Point(119, 81);
            this.Dcodproduto.Name = "Dcodproduto";
            this.Dcodproduto.Size = new System.Drawing.Size(100, 20);
            this.Dcodproduto.TabIndex = 88;
            // 
            // Dnrcompra
            // 
            this.Dnrcompra.Location = new System.Drawing.Point(119, 55);
            this.Dnrcompra.Name = "Dnrcompra";
            this.Dnrcompra.Size = new System.Drawing.Size(100, 20);
            this.Dnrcompra.TabIndex = 86;
            // 
            // Dquantidade
            // 
            this.Dquantidade.Location = new System.Drawing.Point(119, 28);
            this.Dquantidade.Name = "Dquantidade";
            this.Dquantidade.Size = new System.Drawing.Size(100, 20);
            this.Dquantidade.TabIndex = 84;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(12, 535);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(765, 31);
            this.Adicionar.TabIndex = 58;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.AdicionarPessoa_Click);
            // 
            // GRem
            // 
            this.GRem.Controls.Add(this.remover);
            this.GRem.Controls.Add(label12);
            this.GRem.Controls.Add(this.idremover);
            this.GRem.Location = new System.Drawing.Point(549, 233);
            this.GRem.Name = "GRem";
            this.GRem.Size = new System.Drawing.Size(231, 30);
            this.GRem.TabIndex = 90;
            this.GRem.TabStop = false;
            this.GRem.Visible = false;
            // 
            // remover
            // 
            this.remover.BackColor = System.Drawing.Color.Tomato;
            this.remover.Location = new System.Drawing.Point(149, 6);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(81, 23);
            this.remover.TabIndex = 77;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // idremover
            // 
            this.idremover.Location = new System.Drawing.Point(91, 8);
            this.idremover.Name = "idremover";
            this.idremover.Size = new System.Drawing.Size(59, 20);
            this.idremover.TabIndex = 78;
            // 
            // Compras
            // 
            this.Compras.Location = new System.Drawing.Point(655, 25);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(122, 23);
            this.Compras.TabIndex = 92;
            this.Compras.Text = "Compra";
            this.Compras.UseVisualStyleBackColor = true;
            this.Compras.Click += new System.EventHandler(this.Compras_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Location = new System.Drawing.Point(655, 55);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(122, 23);
            this.Detalhes.TabIndex = 91;
            this.Detalhes.Text = "Detalhes Compras";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // GAlt
            // 
            this.GAlt.Controls.Add(labelIdAlterar);
            this.GAlt.Controls.Add(this.alterar);
            this.GAlt.Controls.Add(this.idalterar);
            this.GAlt.Controls.Add(this.comopreencher);
            this.GAlt.Location = new System.Drawing.Point(549, 208);
            this.GAlt.Name = "GAlt";
            this.GAlt.Size = new System.Drawing.Size(231, 33);
            this.GAlt.TabIndex = 93;
            this.GAlt.TabStop = false;
            this.GAlt.Visible = false;
            // 
            // alterar
            // 
            this.alterar.BackColor = System.Drawing.Color.Transparent;
            this.alterar.Location = new System.Drawing.Point(149, 7);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(58, 23);
            this.alterar.TabIndex = 80;
            this.alterar.Text = "alterar";
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // idalterar
            // 
            this.idalterar.Location = new System.Drawing.Point(91, 8);
            this.idalterar.Name = "idalterar";
            this.idalterar.Size = new System.Drawing.Size(59, 20);
            this.idalterar.TabIndex = 81;
            // 
            // comopreencher
            // 
            this.comopreencher.BackColor = System.Drawing.Color.Black;
            this.comopreencher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comopreencher.Location = new System.Drawing.Point(206, 7);
            this.comopreencher.Name = "comopreencher";
            this.comopreencher.Size = new System.Drawing.Size(24, 23);
            this.comopreencher.TabIndex = 82;
            this.comopreencher.Text = " i";
            this.comopreencher.UseVisualStyleBackColor = false;
            this.comopreencher.Click += new System.EventHandler(this.comopreencher_Click);
            // 
            // gestaoDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(789, 567);
            this.Controls.Add(this.Gdetalhes);
            this.Controls.Add(this.GAlt);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.GRem);
            this.Controls.Add(this.MostrarCompra);
            this.Controls.Add(this.Gcompra);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestaoDeVendas";
            this.Text = "gestaoDeVendas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gcompra.ResumeLayout(false);
            this.Gcompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ccodproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cidcliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Gdetalhes.ResumeLayout(false);
            this.Gdetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dcodproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dnrcompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dquantidade)).EndInit();
            this.GRem.ResumeLayout(false);
            this.GRem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idremover)).EndInit();
            this.GAlt.ResumeLayout(false);
            this.GAlt.PerformLayout();
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
        private System.Windows.Forms.ListBox MostrarCompra;
        private System.Windows.Forms.GroupBox Gcompra;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.CheckBox Ccartao;
        private System.Windows.Forms.NumericUpDown Cidcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar Cdatanascimento;
        private System.Windows.Forms.NumericUpDown Ccodproduto;
        private System.Windows.Forms.GroupBox GRem;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.NumericUpDown idremover;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.GroupBox Gdetalhes;
        private System.Windows.Forms.NumericUpDown Dcodproduto;
        private System.Windows.Forms.NumericUpDown Dnrcompra;
        private System.Windows.Forms.NumericUpDown Dquantidade;
        private System.Windows.Forms.GroupBox GAlt;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.NumericUpDown idalterar;
        private System.Windows.Forms.Button comopreencher;
        private System.Windows.Forms.Button Recibo_Venda;
    }
}