namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmEquipamento
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
            ValidadorWindows.MyControl myControl1 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl2 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl3 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl4 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl5 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl6 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl7 = new ValidadorWindows.MyControl();
            this.TxtEqCodigo = new System.Windows.Forms.TextBox();
            this.CboFaCodigoFabricante = new System.Windows.Forms.ComboBox();
            this.TxtEqNome = new System.Windows.Forms.TextBox();
            this.CboEqTipoLibera = new System.Windows.Forms.ComboBox();
            this.TxtEqTempoSinal = new System.Windows.Forms.TextBox();
            this.ChkEqBloqueado = new System.Windows.Forms.CheckBox();
            this.TxtEqTAGRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEqTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.EqCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.validador1 = new ValidadorWindows.Validador(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEqCodigo
            // 
            this.TxtEqCodigo.Location = new System.Drawing.Point(141, 51);
            this.TxtEqCodigo.MaxLength = 8;
            this.TxtEqCodigo.Name = "TxtEqCodigo";
            this.TxtEqCodigo.Size = new System.Drawing.Size(80, 20);
            this.TxtEqCodigo.TabIndex = 3;
            // 
            // CboFaCodigoFabricante
            // 
            this.CboFaCodigoFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFaCodigoFabricante.FormattingEnabled = true;
            this.CboFaCodigoFabricante.Location = new System.Drawing.Point(319, 76);
            this.CboFaCodigoFabricante.Name = "CboFaCodigoFabricante";
            this.CboFaCodigoFabricante.Size = new System.Drawing.Size(486, 21);
            this.CboFaCodigoFabricante.TabIndex = 5;
            // 
            // TxtEqNome
            // 
            this.TxtEqNome.Location = new System.Drawing.Point(431, 130);
            this.TxtEqNome.MaxLength = 50;
            this.TxtEqNome.Name = "TxtEqNome";
            this.TxtEqNome.Size = new System.Drawing.Size(486, 20);
            this.TxtEqNome.TabIndex = 7;
            this.TxtEqNome.Visible = false;
            // 
            // CboEqTipoLibera
            // 
            this.CboEqTipoLibera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEqTipoLibera.FormattingEnabled = true;
            this.CboEqTipoLibera.Items.AddRange(new object[] {
            "N",
            "L",
            "T"});
            this.CboEqTipoLibera.Location = new System.Drawing.Point(511, 51);
            this.CboEqTipoLibera.Name = "CboEqTipoLibera";
            this.CboEqTipoLibera.Size = new System.Drawing.Size(80, 21);
            this.CboEqTipoLibera.TabIndex = 9;
            // 
            // TxtEqTempoSinal
            // 
            this.TxtEqTempoSinal.Location = new System.Drawing.Point(319, 51);
            this.TxtEqTempoSinal.MaxLength = 8;
            this.TxtEqTempoSinal.Name = "TxtEqTempoSinal";
            this.TxtEqTempoSinal.Size = new System.Drawing.Size(80, 20);
            this.TxtEqTempoSinal.TabIndex = 12;
            // 
            // ChkEqBloqueado
            // 
            this.ChkEqBloqueado.AutoSize = true;
            this.ChkEqBloqueado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEqBloqueado.Location = new System.Drawing.Point(80, 78);
            this.ChkEqBloqueado.Name = "ChkEqBloqueado";
            this.ChkEqBloqueado.Size = new System.Drawing.Size(77, 17);
            this.ChkEqBloqueado.TabIndex = 13;
            this.ChkEqBloqueado.Text = "Bloqueado";
            this.ChkEqBloqueado.UseVisualStyleBackColor = true;
            // 
            // TxtEqTAGRFID
            // 
            this.TxtEqTAGRFID.Location = new System.Drawing.Point(144, 102);
            this.TxtEqTAGRFID.MaxLength = 50;
            this.TxtEqTAGRFID.Name = "TxtEqTAGRFID";
            this.TxtEqTAGRFID.Size = new System.Drawing.Size(486, 20);
            this.TxtEqTAGRFID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Equipamento";
            // 
            // CboEqTipoEquipamento
            // 
            this.CboEqTipoEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEqTipoEquipamento.FormattingEnabled = true;
            this.CboEqTipoEquipamento.Location = new System.Drawing.Point(141, 9);
            this.CboEqTipoEquipamento.Name = "CboEqTipoEquipamento";
            this.CboEqTipoEquipamento.Size = new System.Drawing.Size(486, 21);
            this.CboEqTipoEquipamento.TabIndex = 1;
            this.CboEqTipoEquipamento.SelectedIndexChanged += new System.EventHandler(this.CboEqTipoEquipamento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Liberação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tempo do Sinal";
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
            this.Nome,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdItens.Location = new System.Drawing.Point(1, 160);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.RowHeadersWidth = 4;
            this.GrdItens.Size = new System.Drawing.Size(934, 355);
            this.GrdItens.TabIndex = 18;
            this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
            this.GrdItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellContentClick);
            this.GrdItens.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdItens_DataBindingComplete);
            // 
            // EqCodigo
            // 
            this.EqCodigo.DataPropertyName = "EqCodigo";
            this.EqCodigo.HeaderText = "Código";
            this.EqCodigo.Name = "EqCodigo";
            this.EqCodigo.ReadOnly = true;
            this.EqCodigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "EqTAGRFID";
            this.Nome.HeaderText = "TAG RFID";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "N = Não se aplica; L = Liga Libera; T = Liga Trava";
            this.label6.Visible = false;
            // 
            // BtnCancela
            // 
            this.BtnCancela.Location = new System.Drawing.Point(239, 127);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(90, 30);
            this.BtnCancela.TabIndex = 17;
            this.BtnCancela.Text = "Cancelar";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(143, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // validador1
            // 
            myControl1.CasasDecimais = ((byte)(0));
            myControl1.Controle = this.TxtEqCodigo;
            myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl1.MarcaConteudo = false;
            myControl1.NomeCampo = "Código";
            myControl1.Requerido = false;
            myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
            myControl2.CasasDecimais = ((byte)(0));
            myControl2.Controle = this.CboFaCodigoFabricante;
            myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl2.MarcaConteudo = false;
            myControl2.NomeCampo = "Fabricante";
            myControl2.Requerido = true;
            myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl3.CasasDecimais = ((byte)(0));
            myControl3.Controle = this.TxtEqNome;
            myControl3.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl3.MarcaConteudo = false;
            myControl3.NomeCampo = "Nome";
            myControl3.Requerido = false;
            myControl3.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl4.CasasDecimais = ((byte)(0));
            myControl4.Controle = this.CboEqTipoLibera;
            myControl4.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl4.MarcaConteudo = false;
            myControl4.NomeCampo = "Tipo de Liberação";
            myControl4.Requerido = false;
            myControl4.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl5.CasasDecimais = ((byte)(0));
            myControl5.Controle = this.TxtEqTempoSinal;
            myControl5.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl5.MarcaConteudo = false;
            myControl5.NomeCampo = "Tempo do Sinal";
            myControl5.Requerido = false;
            myControl5.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
            myControl6.CasasDecimais = ((byte)(0));
            myControl6.Controle = this.ChkEqBloqueado;
            myControl6.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl6.MarcaConteudo = false;
            myControl6.NomeCampo = "ChkEqBloqueado";
            myControl6.Requerido = false;
            myControl6.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl7.CasasDecimais = ((byte)(0));
            myControl7.Controle = this.TxtEqTAGRFID;
            myControl7.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl7.MarcaConteudo = false;
            myControl7.NomeCampo = "TxtEqTAGRFID";
            myControl7.Requerido = true;
            myControl7.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            this.validador1.Controles.Add(myControl1);
            this.validador1.Controles.Add(myControl2);
            this.validador1.Controles.Add(myControl3);
            this.validador1.Controles.Add(myControl4);
            this.validador1.Controles.Add(myControl5);
            this.validador1.Controles.Add(myControl6);
            this.validador1.Controles.Add(myControl7);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TAG RFID";
            // 
            // FrmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 513);
            this.Controls.Add(this.TxtEqTAGRFID);
            this.Controls.Add(this.ChkEqBloqueado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtEqCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancela);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GrdItens);
            this.Controls.Add(this.TxtEqTempoSinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboEqTipoLibera);
            this.Controls.Add(this.TxtEqNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboFaCodigoFabricante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboEqTipoEquipamento);
            this.Controls.Add(this.label1);
            this.Name = "FrmEquipamento";
            this.Text = "Cadastro de Equipamentos EPP_S";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEquipamento_FormClosed);
            this.Load += new System.EventHandler(this.FrmEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEqTipoEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboFaCodigoFabricante;
        private System.Windows.Forms.TextBox TxtEqNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboEqTipoLibera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEqTempoSinal;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEqCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChkEqBloqueado;
        private System.Windows.Forms.TextBox TxtEqTAGRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}