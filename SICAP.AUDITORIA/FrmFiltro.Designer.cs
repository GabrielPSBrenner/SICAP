namespace ACESSO.AUDITORIA
{
    partial class FrmFiltro
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
           ValidadorWindows.MyControl myControl8 = new ValidadorWindows.MyControl();
           this.MskDataInicio = new System.Windows.Forms.MaskedTextBox();
           this.MskDataFim = new System.Windows.Forms.MaskedTextBox();
           this.CboTipoPonto = new System.Windows.Forms.ComboBox();
           this.CboPonto = new System.Windows.Forms.ComboBox();
           this.CboTipoAcesso = new System.Windows.Forms.ComboBox();
           this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
           this.TxtCodigoUsuario = new System.Windows.Forms.TextBox();
           this.LblUsuario = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.label5 = new System.Windows.Forms.Label();
           this.label7 = new System.Windows.Forms.Label();
           this.label8 = new System.Windows.Forms.Label();
           this.BtnLimpar = new System.Windows.Forms.Button();
           this.BtnConsultar = new System.Windows.Forms.Button();
           this.BtnCancelar = new System.Windows.Forms.Button();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.SuspendLayout();
           // 
           // MskDataInicio
           // 
           this.MskDataInicio.Location = new System.Drawing.Point(99, 10);
           this.MskDataInicio.Mask = "##/##/####";
           this.MskDataInicio.Name = "MskDataInicio";
           this.MskDataInicio.PromptChar = ' ';
           this.MskDataInicio.Size = new System.Drawing.Size(70, 20);
           this.MskDataInicio.TabIndex = 1;
           // 
           // MskDataFim
           // 
           this.MskDataFim.Location = new System.Drawing.Point(194, 10);
           this.MskDataFim.Mask = "##/##/####";
           this.MskDataFim.Name = "MskDataFim";
           this.MskDataFim.PromptChar = ' ';
           this.MskDataFim.Size = new System.Drawing.Size(73, 20);
           this.MskDataFim.TabIndex = 3;
           // 
           // CboTipoPonto
           // 
           this.CboTipoPonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboTipoPonto.FormattingEnabled = true;
           this.CboTipoPonto.Items.AddRange(new object[] {
            "TODOS",
            "ENTRADA",
            "SAÍDA"});
           this.CboTipoPonto.Location = new System.Drawing.Point(410, 9);
           this.CboTipoPonto.Name = "CboTipoPonto";
           this.CboTipoPonto.Size = new System.Drawing.Size(193, 21);
           this.CboTipoPonto.TabIndex = 5;
           this.CboTipoPonto.SelectedIndexChanged += new System.EventHandler(this.CboTipoPonto_SelectedIndexChanged);
           // 
           // CboPonto
           // 
           this.CboPonto.FormattingEnabled = true;
           this.CboPonto.Location = new System.Drawing.Point(102, 37);
           this.CboPonto.Name = "CboPonto";
           this.CboPonto.Size = new System.Drawing.Size(506, 21);
           this.CboPonto.TabIndex = 7;
           // 
           // CboTipoAcesso
           // 
           this.CboTipoAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboTipoAcesso.FormattingEnabled = true;
           this.CboTipoAcesso.Items.AddRange(new object[] {
            "TODOS",
            "FORÇADOS",
            "PERMITIDOS",
            "NEGADOS"});
           this.CboTipoAcesso.Location = new System.Drawing.Point(102, 66);
           this.CboTipoAcesso.Name = "CboTipoAcesso";
           this.CboTipoAcesso.Size = new System.Drawing.Size(202, 21);
           this.CboTipoAcesso.TabIndex = 9;
           // 
           // CboTipoUsuario
           // 
           this.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboTipoUsuario.FormattingEnabled = true;
           this.CboTipoUsuario.Items.AddRange(new object[] {
            "TODOS",
            "CONTRATADO",
            "EMPREGADO",
            "ESTAGIÁRIO",
            "VISITANTE"});
           this.CboTipoUsuario.Location = new System.Drawing.Point(398, 66);
           this.CboTipoUsuario.Name = "CboTipoUsuario";
           this.CboTipoUsuario.Size = new System.Drawing.Size(208, 21);
           this.CboTipoUsuario.TabIndex = 11;
           this.CboTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.CboTipoUsuario_SelectedIndexChanged);
           // 
           // TxtCodigoUsuario
           // 
           this.TxtCodigoUsuario.Enabled = false;
           this.TxtCodigoUsuario.Location = new System.Drawing.Point(102, 97);
           this.TxtCodigoUsuario.Name = "TxtCodigoUsuario";
           this.TxtCodigoUsuario.Size = new System.Drawing.Size(70, 20);
           this.TxtCodigoUsuario.TabIndex = 13;
           this.TxtCodigoUsuario.TextChanged += new System.EventHandler(this.TxtCodigoUsuario_TextChanged);
           this.TxtCodigoUsuario.Leave += new System.EventHandler(this.TxtCodigoUsuario_Leave);
           // 
           // LblUsuario
           // 
           this.LblUsuario.BackColor = System.Drawing.Color.White;
           this.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblUsuario.Location = new System.Drawing.Point(173, 97);
           this.LblUsuario.Name = "LblUsuario";
           this.LblUsuario.Size = new System.Drawing.Size(433, 20);
           this.LblUsuario.TabIndex = 14;
           this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(8, 13);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(85, 13);
           this.label1.TabIndex = 0;
           this.label1.Text = "Período -> Entre";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(175, 13);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(13, 13);
           this.label2.TabIndex = 2;
           this.label2.Text = "e";
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(4, 41);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(92, 13);
           this.label3.TabIndex = 6;
           this.label3.Text = "Ponto de Controle";
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(310, 69);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(82, 13);
           this.label4.TabIndex = 10;
           this.label4.Text = "Tipo de Usuário";
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(53, 100);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(43, 13);
           this.label5.TabIndex = 12;
           this.label5.Text = "Usuário";
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(273, 13);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(131, 13);
           this.label7.TabIndex = 4;
           this.label7.Text = "Tipo de Ponto de Controle";
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Location = new System.Drawing.Point(15, 71);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(81, 13);
           this.label8.TabIndex = 8;
           this.label8.Text = "Tipo de Acesso";
           // 
           // BtnLimpar
           // 
           this.BtnLimpar.Location = new System.Drawing.Point(366, 129);
           this.BtnLimpar.Name = "BtnLimpar";
           this.BtnLimpar.Size = new System.Drawing.Size(117, 46);
           this.BtnLimpar.TabIndex = 16;
           this.BtnLimpar.Text = "&Limpar Critérios";
           this.BtnLimpar.UseVisualStyleBackColor = true;
           this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
           // 
           // BtnConsultar
           // 
           this.BtnConsultar.Location = new System.Drawing.Point(489, 129);
           this.BtnConsultar.Name = "BtnConsultar";
           this.BtnConsultar.Size = new System.Drawing.Size(117, 46);
           this.BtnConsultar.TabIndex = 17;
           this.BtnConsultar.Text = "&Consultar";
           this.BtnConsultar.UseVisualStyleBackColor = true;
           this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
           // 
           // BtnCancelar
           // 
           this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           this.BtnCancelar.Location = new System.Drawing.Point(243, 129);
           this.BtnCancelar.Name = "BtnCancelar";
           this.BtnCancelar.Size = new System.Drawing.Size(117, 46);
           this.BtnCancelar.TabIndex = 15;
           this.BtnCancelar.Text = "&Cancelar";
           this.BtnCancelar.UseVisualStyleBackColor = true;
           this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
           // 
           // validador1
           // 
           myControl1.CasasDecimais = ((byte)(0));
           myControl1.Controle = this.MskDataInicio;
           myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl1.MarcaConteudo = false;
           myControl1.NomeCampo = "Data de Início";
           myControl1.Requerido = false;
           myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl2.CasasDecimais = ((byte)(0));
           myControl2.Controle = this.MskDataFim;
           myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl2.MarcaConteudo = false;
           myControl2.NomeCampo = "Data Final";
           myControl2.Requerido = false;
           myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl3.CasasDecimais = ((byte)(0));
           myControl3.Controle = this.CboTipoPonto;
           myControl3.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl3.MarcaConteudo = false;
           myControl3.NomeCampo = "Tipo de Ponto";
           myControl3.Requerido = false;
           myControl3.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl4.CasasDecimais = ((byte)(0));
           myControl4.Controle = this.CboPonto;
           myControl4.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl4.MarcaConteudo = false;
           myControl4.NomeCampo = "Ponto de Controle";
           myControl4.Requerido = false;
           myControl4.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl5.CasasDecimais = ((byte)(0));
           myControl5.Controle = this.CboTipoAcesso;
           myControl5.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl5.MarcaConteudo = false;
           myControl5.NomeCampo = "Tipo de Acesso";
           myControl5.Requerido = false;
           myControl5.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl6.CasasDecimais = ((byte)(0));
           myControl6.Controle = this.CboTipoUsuario;
           myControl6.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl6.MarcaConteudo = false;
           myControl6.NomeCampo = "Tipo de Usuário";
           myControl6.Requerido = false;
           myControl6.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl7.CasasDecimais = ((byte)(0));
           myControl7.Controle = this.TxtCodigoUsuario;
           myControl7.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl7.MarcaConteudo = true;
           myControl7.NomeCampo = "Código do Usuário";
           myControl7.Requerido = false;
           myControl7.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl8.CasasDecimais = ((byte)(0));
           myControl8.Controle = this.LblUsuario;
           myControl8.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl8.MarcaConteudo = false;
           myControl8.NomeCampo = "Usuário";
           myControl8.Requerido = false;
           myControl8.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           this.validador1.Controles.Add(myControl1);
           this.validador1.Controles.Add(myControl2);
           this.validador1.Controles.Add(myControl3);
           this.validador1.Controles.Add(myControl4);
           this.validador1.Controles.Add(myControl5);
           this.validador1.Controles.Add(myControl6);
           this.validador1.Controles.Add(myControl7);
           this.validador1.Controles.Add(myControl8);
           // 
           // FrmFiltro
           // 
           this.AcceptButton = this.BtnConsultar;
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.CancelButton = this.BtnCancelar;
           this.ClientSize = new System.Drawing.Size(615, 183);
           this.Controls.Add(this.BtnCancelar);
           this.Controls.Add(this.BtnConsultar);
           this.Controls.Add(this.BtnLimpar);
           this.Controls.Add(this.CboTipoAcesso);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.CboTipoPonto);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.LblUsuario);
           this.Controls.Add(this.TxtCodigoUsuario);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.CboTipoUsuario);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.CboPonto);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.MskDataFim);
           this.Controls.Add(this.MskDataInicio);
           this.Controls.Add(this.label1);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           this.MaximizeBox = false;
           this.Name = "FrmFiltro";
           this.Text = "Selecionar registros de tentativas de acessos RTA_USR a partir dos filtros seleci" +
               "onados";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFiltro_FormClosed);
           this.Load += new System.EventHandler(this.FrmFiltro_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskDataInicio;
        private System.Windows.Forms.MaskedTextBox MskDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboPonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigoUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboTipoPonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboTipoAcesso;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCancelar;
        private ValidadorWindows.Validador validador1;
    }
}