namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmEqPontoControle
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
           ValidadorWindows.MyControl myControl21 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl22 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl23 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl24 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl25 = new ValidadorWindows.MyControl();
           this.TxtEPCodigoPontoControle = new System.Windows.Forms.TextBox();
           this.CboPontoControle = new System.Windows.Forms.ComboBox();
           this.TxtEPCodigoTipoEquipamento = new System.Windows.Forms.TextBox();
           this.CboTipoEquipamento = new System.Windows.Forms.ComboBox();
           this.label7 = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.BtnCancela = new System.Windows.Forms.Button();
           this.btnSalvar = new System.Windows.Forms.Button();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.ChkEPObrigatorio = new System.Windows.Forms.CheckBox();
           this.FaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.EQObrigatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
           this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // TxtEPCodigoPontoControle
           // 
           this.TxtEPCodigoPontoControle.Location = new System.Drawing.Point(119, 10);
           this.TxtEPCodigoPontoControle.MaxLength = 8;
           this.TxtEPCodigoPontoControle.Name = "TxtEPCodigoPontoControle";
           this.TxtEPCodigoPontoControle.Size = new System.Drawing.Size(54, 20);
           this.TxtEPCodigoPontoControle.TabIndex = 3;
           this.TxtEPCodigoPontoControle.TextChanged += new System.EventHandler(this.TxtEPCodigoPontoControle_TextChanged);
           // 
           // CboPontoControle
           // 
           this.CboPontoControle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboPontoControle.FormattingEnabled = true;
           this.CboPontoControle.Location = new System.Drawing.Point(175, 9);
           this.CboPontoControle.Name = "CboPontoControle";
           this.CboPontoControle.Size = new System.Drawing.Size(440, 21);
           this.CboPontoControle.TabIndex = 4;
           this.CboPontoControle.SelectedIndexChanged += new System.EventHandler(this.CboPontoControle_SelectedIndexChanged);
           // 
           // TxtEPCodigoTipoEquipamento
           // 
           this.TxtEPCodigoTipoEquipamento.Location = new System.Drawing.Point(119, 37);
           this.TxtEPCodigoTipoEquipamento.MaxLength = 8;
           this.TxtEPCodigoTipoEquipamento.Name = "TxtEPCodigoTipoEquipamento";
           this.TxtEPCodigoTipoEquipamento.Size = new System.Drawing.Size(54, 20);
           this.TxtEPCodigoTipoEquipamento.TabIndex = 6;
           this.TxtEPCodigoTipoEquipamento.TextChanged += new System.EventHandler(this.TxtEPCodigoTipoEquipamento_TextChanged);
           // 
           // CboTipoEquipamento
           // 
           this.CboTipoEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboTipoEquipamento.FormattingEnabled = true;
           this.CboTipoEquipamento.Location = new System.Drawing.Point(175, 36);
           this.CboTipoEquipamento.Name = "CboTipoEquipamento";
           this.CboTipoEquipamento.Size = new System.Drawing.Size(440, 21);
           this.CboTipoEquipamento.TabIndex = 7;
           this.CboTipoEquipamento.SelectedIndexChanged += new System.EventHandler(this.CboTipoEquipamento_SelectedIndexChanged);
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(21, 13);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(92, 13);
           this.label7.TabIndex = 2;
           this.label7.Text = "Ponto de Controle";
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(5, 39);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(108, 13);
           this.label1.TabIndex = 5;
           this.label1.Text = "Tipo de Equipamento";
           // 
           // BtnCancela
           // 
           this.BtnCancela.Location = new System.Drawing.Point(214, 105);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(90, 30);
           this.BtnCancela.TabIndex = 18;
           this.BtnCancela.Text = "Cancelar";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // btnSalvar
           // 
           this.btnSalvar.Location = new System.Drawing.Point(119, 105);
           this.btnSalvar.Name = "btnSalvar";
           this.btnSalvar.Size = new System.Drawing.Size(90, 30);
           this.btnSalvar.TabIndex = 19;
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
            this.FaNome,
            this.EQObrigatorio,
            this.BtnExcluir});
           this.GrdItens.Location = new System.Drawing.Point(1, 141);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(628, 194);
           this.GrdItens.TabIndex = 20;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           // 
           // validador1
           // 
           myControl21.CasasDecimais = ((byte)(0));
           myControl21.Controle = this.TxtEPCodigoPontoControle;
           myControl21.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl21.MarcaConteudo = true;
           myControl21.NomeCampo = "Ponto de Controle";
           myControl21.Requerido = true;
           myControl21.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl22.CasasDecimais = ((byte)(0));
           myControl22.Controle = this.CboPontoControle;
           myControl22.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl22.MarcaConteudo = false;
           myControl22.NomeCampo = "Ponto de Controle";
           myControl22.Requerido = true;
           myControl22.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl23.CasasDecimais = ((byte)(0));
           myControl23.Controle = this.TxtEPCodigoTipoEquipamento;
           myControl23.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl23.MarcaConteudo = true;
           myControl23.NomeCampo = "Tio do Equipamento";
           myControl23.Requerido = true;
           myControl23.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl24.CasasDecimais = ((byte)(0));
           myControl24.Controle = this.CboTipoEquipamento;
           myControl24.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl24.MarcaConteudo = false;
           myControl24.NomeCampo = "Tipo do Equipamento";
           myControl24.Requerido = true;
           myControl24.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl25.CasasDecimais = ((byte)(0));
           myControl25.Controle = this.ChkEPObrigatorio;
           myControl25.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl25.MarcaConteudo = false;
           myControl25.NomeCampo = "ChkEPObrigatorio";
           myControl25.Requerido = false;
           myControl25.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           this.validador1.Controles.Add(myControl21);
           this.validador1.Controles.Add(myControl22);
           this.validador1.Controles.Add(myControl23);
           this.validador1.Controles.Add(myControl24);
           this.validador1.Controles.Add(myControl25);
           // 
           // ChkEPObrigatorio
           // 
           this.ChkEPObrigatorio.AutoSize = true;
           this.ChkEPObrigatorio.Location = new System.Drawing.Point(119, 71);
           this.ChkEPObrigatorio.Name = "ChkEPObrigatorio";
           this.ChkEPObrigatorio.Size = new System.Drawing.Size(142, 17);
           this.ChkEPObrigatorio.TabIndex = 21;
           this.ChkEPObrigatorio.Text = "Equipamento Obrigatório";
           this.ChkEPObrigatorio.UseVisualStyleBackColor = true;
           // 
           // FaNome
           // 
           this.FaNome.DataPropertyName = "TeDescricao";
           this.FaNome.HeaderText = "Descrição";
           this.FaNome.Name = "FaNome";
           this.FaNome.ReadOnly = true;
           this.FaNome.Width = 450;
           // 
           // EQObrigatorio
           // 
           this.EQObrigatorio.DataPropertyName = "EPObrigatorio";
           this.EQObrigatorio.HeaderText = "Obrigatório";
           this.EQObrigatorio.Name = "EQObrigatorio";
           this.EQObrigatorio.ReadOnly = true;
           // 
           // BtnExcluir
           // 
           this.BtnExcluir.HeaderText = "Excluir";
           this.BtnExcluir.Name = "BtnExcluir";
           this.BtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
           this.BtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
           this.BtnExcluir.Width = 50;
           // 
           // FrmEqPontoControle
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(630, 337);
           this.Controls.Add(this.ChkEPObrigatorio);
           this.Controls.Add(this.GrdItens);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.btnSalvar);
           this.Controls.Add(this.CboTipoEquipamento);
           this.Controls.Add(this.TxtEPCodigoTipoEquipamento);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.CboPontoControle);
           this.Controls.Add(this.TxtEPCodigoPontoControle);
           this.Controls.Add(this.label7);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           this.MaximizeBox = false;
           this.Name = "FrmEqPontoControle";
           this.Text = "Equipamentos do Ponto de Controle";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEqPontoControle_FormClosed);
           this.Load += new System.EventHandler(this.FrmEqPontoControle_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEPCodigoPontoControle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboPontoControle;
        private System.Windows.Forms.ComboBox CboTipoEquipamento;
        private System.Windows.Forms.TextBox TxtEPCodigoTipoEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView GrdItens;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.CheckBox ChkEPObrigatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaNome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EQObrigatorio;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}