namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmPontoControle
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
           ValidadorWindows.MyControl myControl9 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl10 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl11 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl12 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl13 = new ValidadorWindows.MyControl();
           ValidadorWindows.MyControl myControl14 = new ValidadorWindows.MyControl();
           this.TxtPoCodigo = new System.Windows.Forms.TextBox();
           this.CboPoTipo = new System.Windows.Forms.ComboBox();
           this.TxtPoNome = new System.Windows.Forms.TextBox();
           this.TxtPoDescricao = new System.Windows.Forms.TextBox();
           this.ChkPoBiometria = new System.Windows.Forms.CheckBox();
           this.ChkPoCartaoRFID = new System.Windows.Forms.CheckBox();
           this.ChkPoSenha = new System.Windows.Forms.CheckBox();
           this.TxtPoObservacao = new System.Windows.Forms.TextBox();
           this.ChkPoControlaSaida = new System.Windows.Forms.CheckBox();
           this.ChkPoDisparaAlarme = new System.Windows.Forms.CheckBox();
           this.TxtPoTentativasIndevidaDisparaAlarme = new System.Windows.Forms.TextBox();
           this.ChkPoPermiteLiberacaoForcada = new System.Windows.Forms.CheckBox();
           this.TxtPoQtdMediaPessoas = new System.Windows.Forms.TextBox();
           this.TxtQtdVerificaEquip = new System.Windows.Forms.TextBox();
           this.label7 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.label6 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.label5 = new System.Windows.Forms.Label();
           this.BtnCancela = new System.Windows.Forms.Button();
           this.btnSalvar = new System.Windows.Forms.Button();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
           this.PONome = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.CrTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.EqCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.label8 = new System.Windows.Forms.Label();
           this.label9 = new System.Windows.Forms.Label();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // TxtPoCodigo
           // 
           this.TxtPoCodigo.Location = new System.Drawing.Point(144, 6);
           this.TxtPoCodigo.MaxLength = 8;
           this.TxtPoCodigo.Name = "TxtPoCodigo";
           this.TxtPoCodigo.Size = new System.Drawing.Size(80, 20);
           this.TxtPoCodigo.TabIndex = 2;
           // 
           // CboPoTipo
           // 
           this.CboPoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.CboPoTipo.FormattingEnabled = true;
           this.CboPoTipo.Items.AddRange(new object[] {
            "E",
            "S",
            "A"});
           this.CboPoTipo.Location = new System.Drawing.Point(144, 32);
           this.CboPoTipo.Name = "CboPoTipo";
           this.CboPoTipo.Size = new System.Drawing.Size(47, 21);
           this.CboPoTipo.TabIndex = 4;
           // 
           // TxtPoNome
           // 
           this.TxtPoNome.Location = new System.Drawing.Point(144, 59);
           this.TxtPoNome.MaxLength = 50;
           this.TxtPoNome.Name = "TxtPoNome";
           this.TxtPoNome.Size = new System.Drawing.Size(486, 20);
           this.TxtPoNome.TabIndex = 7;
           // 
           // TxtPoDescricao
           // 
           this.TxtPoDescricao.Location = new System.Drawing.Point(144, 85);
           this.TxtPoDescricao.MaxLength = 255;
           this.TxtPoDescricao.Multiline = true;
           this.TxtPoDescricao.Name = "TxtPoDescricao";
           this.TxtPoDescricao.Size = new System.Drawing.Size(486, 53);
           this.TxtPoDescricao.TabIndex = 9;
           // 
           // ChkPoBiometria
           // 
           this.ChkPoBiometria.AutoSize = true;
           this.ChkPoBiometria.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoBiometria.Location = new System.Drawing.Point(163, 144);
           this.ChkPoBiometria.Name = "ChkPoBiometria";
           this.ChkPoBiometria.Size = new System.Drawing.Size(287, 17);
           this.ChkPoBiometria.TabIndex = 10;
           this.ChkPoBiometria.Text = "Identificar/Autenticar por Biometria da Impressão Digital";
           this.ChkPoBiometria.UseVisualStyleBackColor = true;
           // 
           // ChkPoCartaoRFID
           // 
           this.ChkPoCartaoRFID.AutoSize = true;
           this.ChkPoCartaoRFID.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoCartaoRFID.Location = new System.Drawing.Point(5, 144);
           this.ChkPoCartaoRFID.Name = "ChkPoCartaoRFID";
           this.ChkPoCartaoRFID.Size = new System.Drawing.Size(152, 17);
           this.ChkPoCartaoRFID.TabIndex = 11;
           this.ChkPoCartaoRFID.Text = "Identificar por Cartão RFID";
           this.ChkPoCartaoRFID.UseVisualStyleBackColor = true;
           // 
           // ChkPoSenha
           // 
           this.ChkPoSenha.AutoSize = true;
           this.ChkPoSenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoSenha.Location = new System.Drawing.Point(462, 144);
           this.ChkPoSenha.Name = "ChkPoSenha";
           this.ChkPoSenha.Size = new System.Drawing.Size(170, 17);
           this.ChkPoSenha.TabIndex = 12;
           this.ChkPoSenha.Text = "Autenticar por Senha de Rede";
           this.ChkPoSenha.UseVisualStyleBackColor = true;
           // 
           // TxtPoObservacao
           // 
           this.TxtPoObservacao.Location = new System.Drawing.Point(144, 167);
           this.TxtPoObservacao.MaxLength = 0;
           this.TxtPoObservacao.Multiline = true;
           this.TxtPoObservacao.Name = "TxtPoObservacao";
           this.TxtPoObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
           this.TxtPoObservacao.Size = new System.Drawing.Size(486, 51);
           this.TxtPoObservacao.TabIndex = 14;
           // 
           // ChkPoControlaSaida
           // 
           this.ChkPoControlaSaida.AutoSize = true;
           this.ChkPoControlaSaida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoControlaSaida.Location = new System.Drawing.Point(524, 288);
           this.ChkPoControlaSaida.Name = "ChkPoControlaSaida";
           this.ChkPoControlaSaida.Size = new System.Drawing.Size(95, 17);
           this.ChkPoControlaSaida.TabIndex = 15;
           this.ChkPoControlaSaida.Text = "Controla Saida";
           this.ChkPoControlaSaida.UseVisualStyleBackColor = true;
           this.ChkPoControlaSaida.Visible = false;
           // 
           // ChkPoDisparaAlarme
           // 
           this.ChkPoDisparaAlarme.AutoSize = true;
           this.ChkPoDisparaAlarme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoDisparaAlarme.Location = new System.Drawing.Point(49, 224);
           this.ChkPoDisparaAlarme.Name = "ChkPoDisparaAlarme";
           this.ChkPoDisparaAlarme.Size = new System.Drawing.Size(108, 17);
           this.ChkPoDisparaAlarme.TabIndex = 16;
           this.ChkPoDisparaAlarme.Text = "Alarme Habilitado";
           this.ChkPoDisparaAlarme.UseVisualStyleBackColor = true;
           // 
           // TxtPoTentativasIndevidaDisparaAlarme
           // 
           this.TxtPoTentativasIndevidaDisparaAlarme.Location = new System.Drawing.Point(388, 221);
           this.TxtPoTentativasIndevidaDisparaAlarme.MaxLength = 2;
           this.TxtPoTentativasIndevidaDisparaAlarme.Name = "TxtPoTentativasIndevidaDisparaAlarme";
           this.TxtPoTentativasIndevidaDisparaAlarme.Size = new System.Drawing.Size(26, 20);
           this.TxtPoTentativasIndevidaDisparaAlarme.TabIndex = 18;
           // 
           // ChkPoPermiteLiberacaoForcada
           // 
           this.ChkPoPermiteLiberacaoForcada.AutoSize = true;
           this.ChkPoPermiteLiberacaoForcada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkPoPermiteLiberacaoForcada.Location = new System.Drawing.Point(4, 252);
           this.ChkPoPermiteLiberacaoForcada.Name = "ChkPoPermiteLiberacaoForcada";
           this.ChkPoPermiteLiberacaoForcada.Size = new System.Drawing.Size(153, 17);
           this.ChkPoPermiteLiberacaoForcada.TabIndex = 19;
           this.ChkPoPermiteLiberacaoForcada.Text = "Permite Liberação Forçada";
           this.ChkPoPermiteLiberacaoForcada.UseVisualStyleBackColor = true;
           // 
           // TxtPoQtdMediaPessoas
           // 
           this.TxtPoQtdMediaPessoas.Location = new System.Drawing.Point(331, 251);
           this.TxtPoQtdMediaPessoas.MaxLength = 8;
           this.TxtPoQtdMediaPessoas.Name = "TxtPoQtdMediaPessoas";
           this.TxtPoQtdMediaPessoas.Size = new System.Drawing.Size(64, 20);
           this.TxtPoQtdMediaPessoas.TabIndex = 21;
           // 
           // TxtQtdVerificaEquip
           // 
           this.TxtQtdVerificaEquip.Location = new System.Drawing.Point(534, 252);
           this.TxtQtdVerificaEquip.MaxLength = 8;
           this.TxtQtdVerificaEquip.Name = "TxtQtdVerificaEquip";
           this.TxtQtdVerificaEquip.Size = new System.Drawing.Size(64, 20);
           this.TxtQtdVerificaEquip.TabIndex = 23;
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(103, 9);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(40, 13);
           this.label7.TabIndex = 1;
           this.label7.Text = "Código";
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(64, 35);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(74, 13);
           this.label4.TabIndex = 3;
           this.label4.Text = "Tipo de Ponto";
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Location = new System.Drawing.Point(197, 35);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(221, 13);
           this.label6.TabIndex = 5;
           this.label6.Text = "E = Entrada; S = Saida; A = Entrada e Saída;";
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(103, 62);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(35, 13);
           this.label3.TabIndex = 6;
           this.label3.Text = "Nome";
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(83, 88);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(55, 13);
           this.label1.TabIndex = 8;
           this.label1.Text = "Descrição";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(68, 186);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(70, 13);
           this.label2.TabIndex = 13;
           this.label2.Text = "Observações";
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(178, 225);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(206, 13);
           this.label5.TabIndex = 17;
           this.label5.Text = "Tentativas Indevidas p/ Disparar o Alarme";
           // 
           // BtnCancela
           // 
           this.BtnCancela.Location = new System.Drawing.Point(240, 275);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(90, 30);
           this.BtnCancela.TabIndex = 25;
           this.BtnCancela.Text = "Cancelar";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // btnSalvar
           // 
           this.btnSalvar.Location = new System.Drawing.Point(144, 275);
           this.btnSalvar.Name = "btnSalvar";
           this.btnSalvar.Size = new System.Drawing.Size(90, 30);
           this.btnSalvar.TabIndex = 24;
           this.btnSalvar.Text = "Salvar";
           this.btnSalvar.UseVisualStyleBackColor = true;
           this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
           // 
           // validador1
           // 
           myControl1.CasasDecimais = ((byte)(0));
           myControl1.Controle = this.TxtPoCodigo;
           myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl1.MarcaConteudo = true;
           myControl1.NomeCampo = "Código";
           myControl1.Requerido = true;
           myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl2.CasasDecimais = ((byte)(0));
           myControl2.Controle = this.CboPoTipo;
           myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl2.MarcaConteudo = false;
           myControl2.NomeCampo = "Tipo de Ponto";
           myControl2.Requerido = true;
           myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl3.CasasDecimais = ((byte)(0));
           myControl3.Controle = this.TxtPoNome;
           myControl3.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl3.MarcaConteudo = false;
           myControl3.NomeCampo = "Nome";
           myControl3.Requerido = true;
           myControl3.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl4.CasasDecimais = ((byte)(0));
           myControl4.Controle = this.TxtPoDescricao;
           myControl4.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl4.MarcaConteudo = false;
           myControl4.NomeCampo = "TxtPoDescricao";
           myControl4.Requerido = false;
           myControl4.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl5.CasasDecimais = ((byte)(0));
           myControl5.Controle = this.ChkPoBiometria;
           myControl5.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl5.MarcaConteudo = false;
           myControl5.NomeCampo = "ChkPoBiometria";
           myControl5.Requerido = false;
           myControl5.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl6.CasasDecimais = ((byte)(0));
           myControl6.Controle = this.ChkPoCartaoRFID;
           myControl6.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl6.MarcaConteudo = false;
           myControl6.NomeCampo = "ChkRFID";
           myControl6.Requerido = false;
           myControl6.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl7.CasasDecimais = ((byte)(0));
           myControl7.Controle = this.ChkPoSenha;
           myControl7.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl7.MarcaConteudo = false;
           myControl7.NomeCampo = "ChkSenha";
           myControl7.Requerido = false;
           myControl7.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl8.CasasDecimais = ((byte)(0));
           myControl8.Controle = this.TxtPoObservacao;
           myControl8.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl8.MarcaConteudo = false;
           myControl8.NomeCampo = "TxtPoObservacao";
           myControl8.Requerido = false;
           myControl8.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl9.CasasDecimais = ((byte)(0));
           myControl9.Controle = this.ChkPoControlaSaida;
           myControl9.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl9.MarcaConteudo = false;
           myControl9.NomeCampo = "ChkPoControleSaida";
           myControl9.Requerido = false;
           myControl9.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl10.CasasDecimais = ((byte)(0));
           myControl10.Controle = this.ChkPoDisparaAlarme;
           myControl10.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl10.MarcaConteudo = false;
           myControl10.NomeCampo = "ChkPoDisparaAlarme";
           myControl10.Requerido = false;
           myControl10.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl11.CasasDecimais = ((byte)(0));
           myControl11.Controle = this.TxtPoTentativasIndevidaDisparaAlarme;
           myControl11.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl11.MarcaConteudo = true;
           myControl11.NomeCampo = "Tentativas indevidas";
           myControl11.Requerido = false;
           myControl11.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl12.CasasDecimais = ((byte)(0));
           myControl12.Controle = this.ChkPoPermiteLiberacaoForcada;
           myControl12.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl12.MarcaConteudo = false;
           myControl12.NomeCampo = "ChkPoPermiteLiberacaoForcada";
           myControl12.Requerido = false;
           myControl12.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           myControl13.CasasDecimais = ((byte)(0));
           myControl13.Controle = this.TxtPoQtdMediaPessoas;
           myControl13.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl13.MarcaConteudo = false;
           myControl13.NomeCampo = "Qtd média de pessoas";
           myControl13.Requerido = false;
           myControl13.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl14.CasasDecimais = ((byte)(0));
           myControl14.Controle = this.TxtQtdVerificaEquip;
           myControl14.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl14.MarcaConteudo = false;
           myControl14.NomeCampo = "Qtd de Pessoas que verifica o equipamento";
           myControl14.Requerido = false;
           myControl14.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           this.validador1.Controles.Add(myControl1);
           this.validador1.Controles.Add(myControl2);
           this.validador1.Controles.Add(myControl3);
           this.validador1.Controles.Add(myControl4);
           this.validador1.Controles.Add(myControl5);
           this.validador1.Controles.Add(myControl6);
           this.validador1.Controles.Add(myControl7);
           this.validador1.Controles.Add(myControl8);
           this.validador1.Controles.Add(myControl9);
           this.validador1.Controles.Add(myControl10);
           this.validador1.Controles.Add(myControl11);
           this.validador1.Controles.Add(myControl12);
           this.validador1.Controles.Add(myControl13);
           this.validador1.Controles.Add(myControl14);
           // 
           // BtnExcluir
           // 
           this.BtnExcluir.HeaderText = "Excluir";
           this.BtnExcluir.Name = "BtnExcluir";
           this.BtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
           this.BtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
           this.BtnExcluir.Width = 50;
           // 
           // BtnAlterar
           // 
           this.BtnAlterar.HeaderText = "Alterar";
           this.BtnAlterar.Name = "BtnAlterar";
           this.BtnAlterar.Width = 50;
           // 
           // PONome
           // 
           this.PONome.DataPropertyName = "PONome";
           this.PONome.HeaderText = "Nome";
           this.PONome.Name = "PONome";
           this.PONome.ReadOnly = true;
           this.PONome.Width = 330;
           // 
           // CrTipo
           // 
           this.CrTipo.DataPropertyName = "POTipo";
           this.CrTipo.HeaderText = "Tipo";
           this.CrTipo.Name = "CrTipo";
           this.CrTipo.ReadOnly = true;
           this.CrTipo.Width = 80;
           // 
           // EqCodigo
           // 
           this.EqCodigo.DataPropertyName = "POCodigo";
           this.EqCodigo.HeaderText = "Código";
           this.EqCodigo.Name = "EqCodigo";
           this.EqCodigo.ReadOnly = true;
           this.EqCodigo.Width = 75;
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
            this.CrTipo,
            this.PONome,
            this.BtnAlterar,
            this.BtnExcluir});
           this.GrdItens.Location = new System.Drawing.Point(0, 312);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(644, 150);
           this.GrdItens.TabIndex = 25;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Location = new System.Drawing.Point(174, 254);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(158, 13);
           this.label8.TabIndex = 20;
           this.label8.Text = "Qtd Máxima de Pessoas por Dia";
           // 
           // label9
           // 
           this.label9.AutoSize = true;
           this.label9.Location = new System.Drawing.Point(401, 256);
           this.label9.Name = "label9";
           this.label9.Size = new System.Drawing.Size(127, 13);
           this.label9.TabIndex = 22;
           this.label9.Text = "Qtd Verifica Equipamento";
           // 
           // FrmPontoControle
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(644, 463);
           this.Controls.Add(this.TxtQtdVerificaEquip);
           this.Controls.Add(this.TxtPoQtdMediaPessoas);
           this.Controls.Add(this.label9);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.GrdItens);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.btnSalvar);
           this.Controls.Add(this.ChkPoPermiteLiberacaoForcada);
           this.Controls.Add(this.TxtPoTentativasIndevidaDisparaAlarme);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.ChkPoDisparaAlarme);
           this.Controls.Add(this.ChkPoControlaSaida);
           this.Controls.Add(this.TxtPoObservacao);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.ChkPoSenha);
           this.Controls.Add(this.ChkPoCartaoRFID);
           this.Controls.Add(this.ChkPoBiometria);
           this.Controls.Add(this.TxtPoDescricao);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.TxtPoNome);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label6);
           this.Controls.Add(this.TxtPoCodigo);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.CboPoTipo);
           this.Name = "FrmPontoControle";
           this.Text = "Cadastro de Ponto de Controle - PCAP_S";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPontoControle_FormClosed);
           this.Load += new System.EventHandler(this.FrmPontoControle_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPoCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboPoTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPoDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkPoBiometria;
        private System.Windows.Forms.CheckBox ChkPoCartaoRFID;
        private System.Windows.Forms.CheckBox ChkPoSenha;
        private System.Windows.Forms.TextBox TxtPoObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkPoControlaSaida;
        private System.Windows.Forms.CheckBox ChkPoDisparaAlarme;
        private System.Windows.Forms.TextBox TxtPoTentativasIndevidaDisparaAlarme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkPoPermiteLiberacaoForcada;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqCodigo;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPoQtdMediaPessoas;
        private System.Windows.Forms.TextBox TxtQtdVerificaEquip;
    }
}