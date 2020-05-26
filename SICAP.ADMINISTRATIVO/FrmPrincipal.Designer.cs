namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmPrincipal
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
           this.menuStrip1 = new System.Windows.Forms.MenuStrip();
           this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadCartao = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadEquipamento = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadFabricante = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadRotas = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadTipoEquipamento = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuCadPonto = new System.Windows.Forms.ToolStripMenuItem();
           this.MnuEqObrigatorioPC = new System.Windows.Forms.ToolStripMenuItem();
           this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
           this.MnuParametro = new System.Windows.Forms.ToolStripMenuItem();
           this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
           this.MnuSair = new System.Windows.Forms.ToolStripMenuItem();
           this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.cartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.equipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.fabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.rotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.tipoDeEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.pontoDeControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
           this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.menuStrip1.SuspendLayout();
           this.SuspendLayout();
           // 
           // menuStrip1
           // 
           this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.consultasToolStripMenuItem});
           this.menuStrip1.Location = new System.Drawing.Point(0, 0);
           this.menuStrip1.Name = "menuStrip1";
           this.menuStrip1.Size = new System.Drawing.Size(729, 24);
           this.menuStrip1.TabIndex = 1;
           this.menuStrip1.Text = "menuStrip1";
           // 
           // cadastrosToolStripMenuItem
           // 
           this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadCartao,
            this.MnuCadEquipamento,
            this.MnuCadFabricante,
            this.MnuCadFornecedor,
            this.MnuCadRotas,
            this.MnuCadTipoEquipamento,
            this.MnuCadPonto,
            this.MnuEqObrigatorioPC,
            this.toolStripSeparator1,
            this.MnuParametro,
            this.toolStripSeparator2,
            this.MnuSair});
           this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
           this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
           this.cadastrosToolStripMenuItem.Text = "&Cadastros";
           // 
           // MnuCadCartao
           // 
           this.MnuCadCartao.Name = "MnuCadCartao";
           this.MnuCadCartao.Size = new System.Drawing.Size(289, 22);
           this.MnuCadCartao.Text = "&Cartão CId_S";
           this.MnuCadCartao.Click += new System.EventHandler(this.MnuCadCartao_Click);
           // 
           // MnuCadEquipamento
           // 
           this.MnuCadEquipamento.Name = "MnuCadEquipamento";
           this.MnuCadEquipamento.Size = new System.Drawing.Size(289, 22);
           this.MnuCadEquipamento.Text = "&Equipamento EPP_S";
           this.MnuCadEquipamento.Click += new System.EventHandler(this.MnuCadEquipamento_Click);
           // 
           // MnuCadFabricante
           // 
           this.MnuCadFabricante.Name = "MnuCadFabricante";
           this.MnuCadFabricante.ShowShortcutKeys = false;
           this.MnuCadFabricante.Size = new System.Drawing.Size(289, 22);
           this.MnuCadFabricante.Text = "&Fabricante";
           this.MnuCadFabricante.Visible = false;
           this.MnuCadFabricante.Click += new System.EventHandler(this.MnuCadFabricante_Click);
           // 
           // MnuCadFornecedor
           // 
           this.MnuCadFornecedor.Name = "MnuCadFornecedor";
           this.MnuCadFornecedor.Size = new System.Drawing.Size(289, 22);
           this.MnuCadFornecedor.Text = "F&ornecedor";
           this.MnuCadFornecedor.Visible = false;
           this.MnuCadFornecedor.Click += new System.EventHandler(this.MnuCadFornecedor_Click);
           // 
           // MnuCadRotas
           // 
           this.MnuCadRotas.Name = "MnuCadRotas";
           this.MnuCadRotas.Size = new System.Drawing.Size(289, 22);
           this.MnuCadRotas.Text = "Ro&tas R_USR";
           this.MnuCadRotas.Click += new System.EventHandler(this.MnuCadRotas_Click);
           // 
           // MnuCadTipoEquipamento
           // 
           this.MnuCadTipoEquipamento.Name = "MnuCadTipoEquipamento";
           this.MnuCadTipoEquipamento.Size = new System.Drawing.Size(289, 22);
           this.MnuCadTipoEquipamento.Text = "&Tipo de Equipamento EPP_S";
           this.MnuCadTipoEquipamento.Click += new System.EventHandler(this.MnuCadTipoEquipamento_Click);
           // 
           // MnuCadPonto
           // 
           this.MnuCadPonto.Name = "MnuCadPonto";
           this.MnuCadPonto.Size = new System.Drawing.Size(289, 22);
           this.MnuCadPonto.Text = "&Ponto de Controle  PCAP_S";
           this.MnuCadPonto.Click += new System.EventHandler(this.MnuCadPonto_Click);
           // 
           // MnuEqObrigatorioPC
           // 
           this.MnuEqObrigatorioPC.Name = "MnuEqObrigatorioPC";
           this.MnuEqObrigatorioPC.Size = new System.Drawing.Size(289, 22);
           this.MnuEqObrigatorioPC.Text = "Inspecionar Equipamentos EPP_S no PCAP_S";
           this.MnuEqObrigatorioPC.Click += new System.EventHandler(this.MnuEqObrigatorioPC_Click);
           // 
           // toolStripSeparator1
           // 
           this.toolStripSeparator1.Name = "toolStripSeparator1";
           this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
           // 
           // MnuParametro
           // 
           this.MnuParametro.Name = "MnuParametro";
           this.MnuParametro.Size = new System.Drawing.Size(289, 22);
           this.MnuParametro.Text = "&Parâmetros";
           this.MnuParametro.Click += new System.EventHandler(this.MnuParametro_Click);
           // 
           // toolStripSeparator2
           // 
           this.toolStripSeparator2.Name = "toolStripSeparator2";
           this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
           // 
           // MnuSair
           // 
           this.MnuSair.Name = "MnuSair";
           this.MnuSair.Size = new System.Drawing.Size(289, 22);
           this.MnuSair.Text = "Sai&r";
           this.MnuSair.Click += new System.EventHandler(this.MnuSair_Click);
           // 
           // controleToolStripMenuItem
           // 
           this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
           this.controleToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
           this.controleToolStripMenuItem.Text = "&Usuários USR";
           this.controleToolStripMenuItem.Click += new System.EventHandler(this.controleToolStripMenuItem_Click);
           // 
           // consultasToolStripMenuItem
           // 
           this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartãoToolStripMenuItem,
            this.equipamentoToolStripMenuItem,
            this.fabricanteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.rotasToolStripMenuItem,
            this.tipoDeEquipamentoToolStripMenuItem,
            this.pontoDeControleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.usuáriosToolStripMenuItem});
           this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
           this.consultasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
           this.consultasToolStripMenuItem.Text = "&Consultas";
           this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
           // 
           // cartãoToolStripMenuItem
           // 
           this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
           this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.cartãoToolStripMenuItem.Text = "&Cartão CId_S";
           // 
           // equipamentoToolStripMenuItem
           // 
           this.equipamentoToolStripMenuItem.Name = "equipamentoToolStripMenuItem";
           this.equipamentoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.equipamentoToolStripMenuItem.Text = "&Equipamento EPP_S";
           // 
           // fabricanteToolStripMenuItem
           // 
           this.fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
           this.fabricanteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.fabricanteToolStripMenuItem.Text = "&Fabricante";
           this.fabricanteToolStripMenuItem.Visible = false;
           // 
           // fornecedorToolStripMenuItem
           // 
           this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
           this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.fornecedorToolStripMenuItem.Text = "F&ornecedor";
           this.fornecedorToolStripMenuItem.Visible = false;
           // 
           // rotasToolStripMenuItem
           // 
           this.rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
           this.rotasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.rotasToolStripMenuItem.Text = "R&otas R_USR";
           // 
           // tipoDeEquipamentoToolStripMenuItem
           // 
           this.tipoDeEquipamentoToolStripMenuItem.Name = "tipoDeEquipamentoToolStripMenuItem";
           this.tipoDeEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.tipoDeEquipamentoToolStripMenuItem.Text = "&Tipo de Equipamento EPP_S";
           // 
           // pontoDeControleToolStripMenuItem
           // 
           this.pontoDeControleToolStripMenuItem.Name = "pontoDeControleToolStripMenuItem";
           this.pontoDeControleToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.pontoDeControleToolStripMenuItem.Text = "&Ponto de Controle PCAP_S";
           // 
           // toolStripMenuItem2
           // 
           this.toolStripMenuItem2.Name = "toolStripMenuItem2";
           this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
           // 
           // usuáriosToolStripMenuItem
           // 
           this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
           this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
           this.usuáriosToolStripMenuItem.Text = "&Usuários";
           // 
           // FrmPrincipal
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(729, 292);
           this.Controls.Add(this.menuStrip1);
           this.IsMdiContainer = true;
           this.MainMenuStrip = this.menuStrip1;
           this.Name = "FrmPrincipal";
           this.Text = "Sistema de Controle Físico de Acessos de Pessoas - SiCAP";
           this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           this.menuStrip1.ResumeLayout(false);
           this.menuStrip1.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem MnuCadTipoEquipamento;
        public System.Windows.Forms.ToolStripMenuItem MnuCadFabricante;
        public System.Windows.Forms.ToolStripMenuItem MnuCadFornecedor;
        public System.Windows.Forms.ToolStripMenuItem MnuParametro;
        public System.Windows.Forms.ToolStripMenuItem MnuCadEquipamento;
        public System.Windows.Forms.ToolStripMenuItem MnuCadCartao;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuCadPonto;
        private System.Windows.Forms.ToolStripMenuItem cartãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontoDeControleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuCadRotas;
        public System.Windows.Forms.ToolStripMenuItem MnuEqObrigatorioPC;
        public System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
    }
}

