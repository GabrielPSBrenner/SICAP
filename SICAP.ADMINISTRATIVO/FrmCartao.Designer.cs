namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmCartao
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
           ValidadorWindows.MyControl myControl7 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl8 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl9 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl10 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl11 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl12 = new ValidadorWindows.MyControl();
           this.TxtCrCodigo = new System.Windows.Forms.TextBox();
           this.CboCrCodigoFabricante = new System.Windows.Forms.ComboBox();
           this.TxtCrNumeroCartao = new System.Windows.Forms.TextBox();
           this.CboCrTipo = new System.Windows.Forms.ComboBox();
           this.TxtCrMotivoBloqueio = new System.Windows.Forms.TextBox();
           this.ChkCrBloqueado = new System.Windows.Forms.CheckBox();
           this.label7 = new System.Windows.Forms.Label();
           this.BtnCancela = new System.Windows.Forms.Button();
           this.btnSalvar = new System.Windows.Forms.Button();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.label5 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.label6 = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.EqCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.CrNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.CrBloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
           this.CrMotivoBloqueio = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // TxtCrCodigo
           // 
           this.TxtCrCodigo.Location = new System.Drawing.Point(144, 3);
           this.TxtCrCodigo.MaxLength = 8;
           this.TxtCrCodigo.Name = "TxtCrCodigo";
           this.TxtCrCodigo.Size = new System.Drawing.Size(80, 20);
           this.TxtCrCodigo.TabIndex = 17;
           // 
           // CboCrCodigoFabricante
           // 
           this.CboCrCodigoFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboCrCodigoFabricante.FormattingEnabled = true;
           this.CboCrCodigoFabricante.Location = new System.Drawing.Point(308, 6);
           this.CboCrCodigoFabricante.Name = "CboCrCodigoFabricante";
           this.CboCrCodigoFabricante.Size = new System.Drawing.Size(325, 21);
           this.CboCrCodigoFabricante.TabIndex = 19;
           this.CboCrCodigoFabricante.Visible = false;
           // 
           // TxtCrNumeroCartao
           // 
           this.TxtCrNumeroCartao.Location = new System.Drawing.Point(144, 33);
           this.TxtCrNumeroCartao.MaxLength = 50;
           this.TxtCrNumeroCartao.Name = "TxtCrNumeroCartao";
           this.TxtCrNumeroCartao.Size = new System.Drawing.Size(486, 20);
           this.TxtCrNumeroCartao.TabIndex = 21;
           // 
           // CboCrTipo
           // 
           this.CboCrTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboCrTipo.FormattingEnabled = true;
           this.CboCrTipo.Items.AddRange(new object[] {
            "R"});
           this.CboCrTipo.Location = new System.Drawing.Point(320, 60);
           this.CboCrTipo.Name = "CboCrTipo";
           this.CboCrTipo.Size = new System.Drawing.Size(80, 21);
           this.CboCrTipo.TabIndex = 23;
           this.CboCrTipo.Visible = false;
           // 
           // TxtCrMotivoBloqueio
           // 
           this.TxtCrMotivoBloqueio.Location = new System.Drawing.Point(147, 85);
           this.TxtCrMotivoBloqueio.MaxLength = 50;
           this.TxtCrMotivoBloqueio.Name = "TxtCrMotivoBloqueio";
           this.TxtCrMotivoBloqueio.Size = new System.Drawing.Size(486, 20);
           this.TxtCrMotivoBloqueio.TabIndex = 31;
           // 
           // ChkCrBloqueado
           // 
           this.ChkCrBloqueado.AutoSize = true;
           this.ChkCrBloqueado.Location = new System.Drawing.Point(147, 62);
           this.ChkCrBloqueado.Name = "ChkCrBloqueado";
           this.ChkCrBloqueado.Size = new System.Drawing.Size(15, 14);
           this.ChkCrBloqueado.TabIndex = 30;
           this.ChkCrBloqueado.UseVisualStyleBackColor = true;
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(98, 6);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(40, 13);
           this.label7.TabIndex = 16;
           this.label7.Text = "Código";
           // 
           // BtnCancela
           // 
           this.BtnCancela.Location = new System.Drawing.Point(244, 114);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(90, 30);
           this.BtnCancela.TabIndex = 28;
           this.BtnCancela.Text = "Cancelar";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // btnSalvar
           // 
           this.btnSalvar.Location = new System.Drawing.Point(148, 114);
           this.btnSalvar.Name = "btnSalvar";
           this.btnSalvar.Size = new System.Drawing.Size(90, 30);
           this.btnSalvar.TabIndex = 27;
           this.btnSalvar.Text = "Salvar";
           this.btnSalvar.UseVisualStyleBackColor = true;
           this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
           // 
           // GrdItens
           // 
           this.GrdItens.AllowUserToAddRows = false;
           this.GrdItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EqCodigo,
            this.CrNumero,
            this.CrBloqueado,
            this.CrMotivoBloqueio,
            this.BtnAlterar,
            this.BtnExcluir});
           this.GrdItens.Location = new System.Drawing.Point(3, 150);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(663, 269);
           this.GrdItens.TabIndex = 29;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(83, 63);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(58, 13);
           this.label5.TabIndex = 25;
           this.label5.Text = "Bloqueado";
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(233, 64);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(77, 13);
           this.label4.TabIndex = 22;
           this.label4.Text = "Tipo de Cartão";
           this.label4.Visible = false;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(45, 33);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(93, 13);
           this.label3.TabIndex = 20;
           this.label3.Text = "Número do Cartão";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(245, 9);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(57, 13);
           this.label2.TabIndex = 18;
           this.label2.Text = "Fabricante";
           this.label2.Visible = false;
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Location = new System.Drawing.Point(430, 60);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(181, 13);
           this.label6.TabIndex = 24;
           this.label6.Text = "R = RFID; S = Smart Card; E = ECPF";
           this.label6.Visible = false;
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(54, 88);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(83, 13);
           this.label1.TabIndex = 32;
           this.label1.Text = "Motivo Bloqueio";
           // 
           // validador1
           // 
           myControl7.CasasDecimais = ((byte)(0));
           myControl7.Controle = this.TxtCrCodigo;
           myControl7.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl7.MarcaConteudo = true;
           myControl7.NomeCampo = "Código";
           myControl7.Requerido = false;
           myControl7.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl8.CasasDecimais = ((byte)(0));
           myControl8.Controle = this.CboCrCodigoFabricante;
           myControl8.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl8.MarcaConteudo = false;
           myControl8.NomeCampo = "Fabricante";
           myControl8.Requerido = true;
           myControl8.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl9.CasasDecimais = ((byte)(0));
           myControl9.Controle = this.TxtCrNumeroCartao;
           myControl9.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl9.MarcaConteudo = true;
           myControl9.NomeCampo = "Número do Cartão";
           myControl9.Requerido = true;
           myControl9.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl10.CasasDecimais = ((byte)(0));
           myControl10.Controle = this.CboCrTipo;
           myControl10.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl10.MarcaConteudo = false;
           myControl10.NomeCampo = "Tipo do Cartão";
           myControl10.Requerido = true;
           myControl10.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl11.CasasDecimais = ((byte)(0));
           myControl11.Controle = this.TxtCrMotivoBloqueio;
           myControl11.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl11.MarcaConteudo = false;
           myControl11.NomeCampo = "Motivo do Bloqueio";
           myControl11.Requerido = false;
           myControl11.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl12.CasasDecimais = ((byte)(0));
           myControl12.Controle = this.ChkCrBloqueado;
           myControl12.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl12.MarcaConteudo = false;
           myControl12.NomeCampo = "ChkCrBloqueado";
           myControl12.Requerido = false;
           myControl12.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           this.validador1.Controles.Add(myControl7);
           this.validador1.Controles.Add(myControl8);
           this.validador1.Controles.Add(myControl9);
           this.validador1.Controles.Add(myControl10);
           this.validador1.Controles.Add(myControl11);
           this.validador1.Controles.Add(myControl12);
           // 
           // EqCodigo
           // 
           this.EqCodigo.DataPropertyName = "CrCodigo";
           this.EqCodigo.HeaderText = "Código";
           this.EqCodigo.Name = "EqCodigo";
           this.EqCodigo.ReadOnly = true;
           this.EqCodigo.Width = 50;
           // 
           // CrNumero
           // 
           this.CrNumero.DataPropertyName = "CrNumeroCartao";
           this.CrNumero.HeaderText = "Número";
           this.CrNumero.Name = "CrNumero";
           this.CrNumero.ReadOnly = true;
           this.CrNumero.Width = 150;
           // 
           // CrBloqueado
           // 
           this.CrBloqueado.HeaderText = "Bloqueado";
           this.CrBloqueado.Name = "CrBloqueado";
           this.CrBloqueado.ReadOnly = true;
           // 
           // CrMotivoBloqueio
           // 
           this.CrMotivoBloqueio.DataPropertyName = "CrMotivoBloqueio";
           this.CrMotivoBloqueio.HeaderText = "Motivo Bloqueio";
           this.CrMotivoBloqueio.Name = "CrMotivoBloqueio";
           this.CrMotivoBloqueio.ReadOnly = true;
           this.CrMotivoBloqueio.Width = 230;
           // 
           // BtnAlterar
           // 
           this.BtnAlterar.HeaderText = "Alterar";
           this.BtnAlterar.Name = "BtnAlterar";
           this.BtnAlterar.Width = 50;
           // 
           // BtnExcluir
           // 
           this.BtnExcluir.HeaderText = "Excluir";
           this.BtnExcluir.Name = "BtnExcluir";
           this.BtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
           this.BtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
           this.BtnExcluir.Width = 50;
           // 
           // FrmCartao
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(666, 421);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.TxtCrMotivoBloqueio);
           this.Controls.Add(this.ChkCrBloqueado);
           this.Controls.Add(this.TxtCrCodigo);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.btnSalvar);
           this.Controls.Add(this.label6);
           this.Controls.Add(this.GrdItens);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.CboCrTipo);
           this.Controls.Add(this.TxtCrNumeroCartao);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.CboCrCodigoFabricante);
           this.Controls.Add(this.label2);
           this.Name = "FrmCartao";
           this.Text = "Cadastro de Cartões CId_S";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCartao_FormClosed);
           this.Load += new System.EventHandler(this.FrmCartao_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCrCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboCrTipo;
        private System.Windows.Forms.TextBox TxtCrNumeroCartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCrCodigoFabricante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkCrBloqueado;
        private System.Windows.Forms.TextBox TxtCrMotivoBloqueio;
        private System.Windows.Forms.Label label1;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNumero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CrBloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrMotivoBloqueio;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}