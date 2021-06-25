namespace Projeto_DesenvolvimentoAplicacoes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEscolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 100F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 164);
            this.label1.TabIndex = 0;
            this.label1.Text = "BooKids";
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
            this.menuStrip1.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(774, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bookids";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProdutosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEscolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAnimadoresToolStripMenuItem;
    }
}

