namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmRota
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
           ValidadorWindows.MyControl myControl17 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl18 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl19 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl20 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl21 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl22 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl23 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl24 = new ValidadorWindows.MyControl();
           this.TxtROCodigo = new System.Windows.Forms.TextBox();
           this.TxtRONome = new System.Windows.Forms.TextBox();
           this.TxtRODescricao = new System.Windows.Forms.TextBox();
           this.ChkROBloqueada = new System.Windows.Forms.CheckBox();
           this.CboTipoPonto = new System.Windows.Forms.ComboBox();
           this.CboPontoControle = new System.Windows.Forms.ComboBox();
           this.TxtPRTempoMaxPerm = new System.Windows.Forms.TextBox();
           this.label7 = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.BtnCancela = new System.Windows.Forms.Button();
           this.btnSalvar = new System.Windows.Forms.Button();
           this.BtnNovo = new System.Windows.Forms.Button();
           this.BtnExcluir = new System.Windows.Forms.Button();
           this.label2 = new System.Windows.Forms.Label();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.BtnSalvarPontoRota = new System.Windows.Forms.Button();
           this.label4 = new System.Windows.Forms.Label();
           this.label5 = new System.Windows.Forms.Label();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.BtnAlterar = new System.Windows.Forms.Button();
           this.label6 = new System.Windows.Forms.Label();
           this.validador2 = new ValidadorWindows.Validador(this.components);
           this.label3 = new System.Windows.Forms.Label();
           this.label8 = new System.Windows.Forms.Label();
           this.TxtROMotivoBloqueio = new System.Windows.Forms.TextBox();
           this.PONome = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.PRTipoPontoControle = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.BtnOrdemMenos1 = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnOrdemMais1 = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnExcluirPC = new System.Windows.Forms.DataGridViewButtonColumn();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // TxtROCodigo
           // 
           this.TxtROCodigo.Location = new System.Drawing.Point(110, 9);
           this.TxtROCodigo.MaxLength = 8;
           this.TxtROCodigo.Name = "TxtROCodigo";
           this.TxtROCodigo.Size = new System.Drawing.Size(80, 20);
           this.TxtROCodigo.TabIndex = 1;
           this.TxtROCodigo.Leave += new System.EventHandler(this.TxtROCodigo_Leave);
           // 
           // TxtRONome
           // 
           this.TxtRONome.Location = new System.Drawing.Point(110, 35);
           this.TxtRONome.MaxLength = 50;
           this.TxtRONome.Name = "TxtRONome";
           this.TxtRONome.Size = new System.Drawing.Size(486, 20);
           this.TxtRONome.TabIndex = 3;
           // 
           // TxtRODescricao
           // 
           this.TxtRODescricao.Location = new System.Drawing.Point(110, 61);
           this.TxtRODescricao.MaxLength = 255;
           this.TxtRODescricao.Multiline = true;
           this.TxtRODescricao.Name = "TxtRODescricao";
           this.TxtRODescricao.Size = new System.Drawing.Size(486, 53);
           this.TxtRODescricao.TabIndex = 5;
           // 
           // ChkROBloqueada
           // 
           this.ChkROBloqueada.AutoSize = true;
           this.ChkROBloqueada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkROBloqueada.Location = new System.Drawing.Point(46, 121);
           this.ChkROBloqueada.Name = "ChkROBloqueada";
           this.ChkROBloqueada.Size = new System.Drawing.Size(77, 17);
           this.ChkROBloqueada.TabIndex = 6;
           this.ChkROBloqueada.Text = "Bloqueada";
           this.ChkROBloqueada.UseVisualStyleBackColor = true;
           // 
           // CboTipoPonto
           // 
           this.CboTipoPonto.FormattingEnabled = true;
           this.CboTipoPonto.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA"});
           this.CboTipoPonto.Location = new System.Drawing.Point(110, 223);
           this.CboTipoPonto.Name = "CboTipoPonto";
           this.CboTipoPonto.Size = new System.Drawing.Size(90, 21);
           this.CboTipoPonto.TabIndex = 13;
           this.CboTipoPonto.SelectedIndexChanged += new System.EventHandler(this.CboTipoPonto_SelectedIndexChanged);
           // 
           // CboPontoControle
           // 
           this.CboPontoControle.FormattingEnabled = true;
           this.CboPontoControle.Location = new System.Drawing.Point(110, 253);
           this.CboPontoControle.Name = "CboPontoControle";
           this.CboPontoControle.Size = new System.Drawing.Size(486, 21);
           this.CboPontoControle.TabIndex = 15;
           // 
           // TxtPRTempoMaxPerm
           // 
           this.TxtPRTempoMaxPerm.Location = new System.Drawing.Point(110, 282);
           this.TxtPRTempoMaxPerm.MaxLength = 8;
           this.TxtPRTempoMaxPerm.Name = "TxtPRTempoMaxPerm";
           this.TxtPRTempoMaxPerm.Size = new System.Drawing.Size(80, 20);
           this.TxtPRTempoMaxPerm.TabIndex = 17;
           this.TxtPRTempoMaxPerm.Visible = false;
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(69, 12);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(40, 13);
           this.label7.TabIndex = 0;
           this.label7.Text = "Código";
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(49, 82);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(55, 13);
           this.label1.TabIndex = 4;
           this.label1.Text = "Descrição";
           // 
           // BtnCancela
           // 
           this.BtnCancela.Enabled = false;
           this.BtnCancela.Location = new System.Drawing.Point(303, 176);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(90, 30);
           this.BtnCancela.TabIndex = 9;
           this.BtnCancela.Text = "Cancela&r";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // btnSalvar
           // 
           this.btnSalvar.Enabled = false;
           this.btnSalvar.Location = new System.Drawing.Point(207, 176);
           this.btnSalvar.Name = "btnSalvar";
           this.btnSalvar.Size = new System.Drawing.Size(90, 30);
           this.btnSalvar.TabIndex = 8;
           this.btnSalvar.Text = "&Salvar";
           this.btnSalvar.UseVisualStyleBackColor = true;
           this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
           // 
           // BtnNovo
           // 
           this.BtnNovo.Location = new System.Drawing.Point(110, 176);
           this.BtnNovo.Name = "BtnNovo";
           this.BtnNovo.Size = new System.Drawing.Size(90, 30);
           this.BtnNovo.TabIndex = 7;
           this.BtnNovo.Text = "&Novo";
           this.BtnNovo.UseVisualStyleBackColor = true;
           this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
           // 
           // BtnExcluir
           // 
           this.BtnExcluir.Enabled = false;
           this.BtnExcluir.Location = new System.Drawing.Point(495, 176);
           this.BtnExcluir.Name = "BtnExcluir";
           this.BtnExcluir.Size = new System.Drawing.Size(90, 30);
           this.BtnExcluir.TabIndex = 11;
           this.BtnExcluir.Text = "&Excluir";
           this.BtnExcluir.UseVisualStyleBackColor = true;
           this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(12, 256);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(92, 13);
           this.label2.TabIndex = 14;
           this.label2.Text = "Ponto de Controle";
           // 
           // GrdItens
           // 
           this.GrdItens.AllowUserToAddRows = false;
           this.GrdItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PONome,
            this.PRTipoPontoControle,
            this.BtnOrdemMenos1,
            this.BtnOrdemMais1,
            this.BtnExcluirPC});
           this.GrdItens.Location = new System.Drawing.Point(1, 308);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(611, 118);
           this.GrdItens.TabIndex = 20;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           // 
           // BtnSalvarPontoRota
           // 
           this.BtnSalvarPontoRota.Enabled = false;
           this.BtnSalvarPontoRota.Location = new System.Drawing.Point(262, 280);
           this.BtnSalvarPontoRota.Name = "BtnSalvarPontoRota";
           this.BtnSalvarPontoRota.Size = new System.Drawing.Size(334, 22);
           this.BtnSalvarPontoRota.TabIndex = 19;
           this.BtnSalvarPontoRota.Text = "Incluir";
           this.BtnSalvarPontoRota.UseVisualStyleBackColor = true;
           this.BtnSalvarPontoRota.Click += new System.EventHandler(this.BtnSalvarPontoRota_Click);
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(25, 285);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(79, 13);
           this.label4.TabIndex = 16;
           this.label4.Text = "Tempo Máximo";
           this.label4.Visible = false;
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(196, 285);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(60, 13);
           this.label5.TabIndex = 18;
           this.label5.Text = "em minutos";
           this.label5.Visible = false;
           // 
           // validador1
           // 
           myControl17.CasasDecimais = ((byte)(0));
           myControl17.Controle = this.TxtROCodigo;
           myControl17.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl17.MarcaConteudo = true;
           myControl17.NomeCampo = "Código";
           myControl17.Requerido = false;
           myControl17.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl18.CasasDecimais = ((byte)(0));
           myControl18.Controle = this.TxtRONome;
           myControl18.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl18.MarcaConteudo = true;
           myControl18.NomeCampo = "Nome";
           myControl18.Requerido = true;
           myControl18.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl19.CasasDecimais = ((byte)(0));
           myControl19.Controle = this.TxtRODescricao;
           myControl19.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl19.MarcaConteudo = true;
           myControl19.NomeCampo = "Descrição";
           myControl19.Requerido = true;
           myControl19.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl20.CasasDecimais = ((byte)(0));
           myControl20.Controle = this.ChkROBloqueada;
           myControl20.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl20.MarcaConteudo = false;
           myControl20.NomeCampo = "Rota Ativa";
           myControl20.Requerido = false;
           myControl20.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl21.CasasDecimais = ((byte)(0));
           myControl21.Controle = this.TxtROMotivoBloqueio;
           myControl21.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl21.MarcaConteudo = false;
           myControl21.NomeCampo = "Motivo do bloqueio";
           myControl21.Requerido = false;
           myControl21.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           this.validador1.Controles.Add(myControl17);
           this.validador1.Controles.Add(myControl18);
           this.validador1.Controles.Add(myControl19);
           this.validador1.Controles.Add(myControl20);
           this.validador1.Controles.Add(myControl21);
           // 
           // BtnAlterar
           // 
           this.BtnAlterar.Enabled = false;
           this.BtnAlterar.Location = new System.Drawing.Point(399, 176);
           this.BtnAlterar.Name = "BtnAlterar";
           this.BtnAlterar.Size = new System.Drawing.Size(90, 30);
           this.BtnAlterar.TabIndex = 10;
           this.BtnAlterar.Text = "&Alterar";
           this.BtnAlterar.UseVisualStyleBackColor = true;
           this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Location = new System.Drawing.Point(45, 226);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(59, 13);
           this.label6.TabIndex = 12;
           this.label6.Text = "Tipo Ponto";
           // 
           // validador2
           // 
           myControl22.CasasDecimais = ((byte)(0));
           myControl22.Controle = this.CboTipoPonto;
           myControl22.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl22.MarcaConteudo = false;
           myControl22.NomeCampo = "CboTipoPonto";
           myControl22.Requerido = true;
           myControl22.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl23.CasasDecimais = ((byte)(0));
           myControl23.Controle = this.CboPontoControle;
           myControl23.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl23.MarcaConteudo = false;
           myControl23.NomeCampo = "CboPontoControle";
           myControl23.Requerido = true;
           myControl23.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl24.CasasDecimais = ((byte)(0));
           myControl24.Controle = this.TxtPRTempoMaxPerm;
           myControl24.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl24.MarcaConteudo = true;
           myControl24.NomeCampo = "TxtPRTempoMaxPerm";
           myControl24.Requerido = true;
           myControl24.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           this.validador2.Controles.Add(myControl22);
           this.validador2.Controles.Add(myControl23);
           this.validador2.Controles.Add(myControl24);
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(69, 38);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(35, 13);
           this.label3.TabIndex = 2;
           this.label3.Text = "Nome";
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Location = new System.Drawing.Point(21, 150);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(83, 13);
           this.label8.TabIndex = 21;
           this.label8.Text = "Motivo Bloqueio";
           // 
           // TxtROMotivoBloqueio
           // 
           this.TxtROMotivoBloqueio.Location = new System.Drawing.Point(110, 144);
           this.TxtROMotivoBloqueio.MaxLength = 50;
           this.TxtROMotivoBloqueio.Name = "TxtROMotivoBloqueio";
           this.TxtROMotivoBloqueio.Size = new System.Drawing.Size(486, 20);
           this.TxtROMotivoBloqueio.TabIndex = 22;
           // 
           // PONome
           // 
           this.PONome.DataPropertyName = "PONome";
           this.PONome.HeaderText = "Ponto de Controle";
           this.PONome.Name = "PONome";
           this.PONome.ReadOnly = true;
           this.PONome.Width = 320;
           // 
           // PRTipoPontoControle
           // 
           this.PRTipoPontoControle.DataPropertyName = "PRTipoPontoControle";
           this.PRTipoPontoControle.HeaderText = "Tipo";
           this.PRTipoPontoControle.Name = "PRTipoPontoControle";
           this.PRTipoPontoControle.ReadOnly = true;
           this.PRTipoPontoControle.Width = 40;
           // 
           // BtnOrdemMenos1
           // 
           this.BtnOrdemMenos1.HeaderText = "Ordem - 1";
           this.BtnOrdemMenos1.Name = "BtnOrdemMenos1";
           this.BtnOrdemMenos1.Width = 70;
           // 
           // BtnOrdemMais1
           // 
           this.BtnOrdemMais1.HeaderText = "Ordem + 1";
           this.BtnOrdemMais1.Name = "BtnOrdemMais1";
           this.BtnOrdemMais1.Width = 70;
           // 
           // BtnExcluirPC
           // 
           this.BtnExcluirPC.HeaderText = "Excluir";
           this.BtnExcluirPC.Name = "BtnExcluirPC";
           this.BtnExcluirPC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
           this.BtnExcluirPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
           this.BtnExcluirPC.Width = 50;
           // 
           // FrmRota
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(611, 423);
           this.Controls.Add(this.TxtROMotivoBloqueio);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.CboTipoPonto);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.TxtPRTempoMaxPerm);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.BtnSalvarPontoRota);
           this.Controls.Add(this.GrdItens);
           this.Controls.Add(this.label6);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.CboPontoControle);
           this.Controls.Add(this.BtnAlterar);
           this.Controls.Add(this.BtnExcluir);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.BtnNovo);
           this.Controls.Add(this.btnSalvar);
           this.Controls.Add(this.ChkROBloqueada);
           this.Controls.Add(this.TxtRODescricao);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.TxtRONome);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.TxtROCodigo);
           this.Controls.Add(this.label7);
           this.Name = "FrmRota";
           this.Text = "Cadastro de Rotas";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRota_FormClosed);
           this.Load += new System.EventHandler(this.FrmRota_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRONome;
        private System.Windows.Forms.TextBox TxtROCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChkROBloqueada;
        private System.Windows.Forms.TextBox TxtRODescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ComboBox CboPontoControle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Button BtnSalvarPontoRota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPRTempoMaxPerm;
        private System.Windows.Forms.Label label5;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTipoPonto;
        private ValidadorWindows.Validador validador2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtROMotivoBloqueio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRTipoPontoControle;
        private System.Windows.Forms.DataGridViewButtonColumn BtnOrdemMenos1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnOrdemMais1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluirPC;
    }
}