namespace ACESSO.PONTOCONTROLE
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
           this.components = new System.ComponentModel.Container();
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
           this.PctVerde = new System.Windows.Forms.PictureBox();
           this.PctVermelho = new System.Windows.Forms.PictureBox();
           this.PctAmarelo = new System.Windows.Forms.PictureBox();
           this.PctSemSinal = new System.Windows.Forms.PictureBox();
           this.LblMsg = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.LblUsuario = new System.Windows.Forms.Label();
           this.PicFoto = new System.Windows.Forms.PictureBox();
           this.label4 = new System.Windows.Forms.Label();
           this.LblIdentificacao = new System.Windows.Forms.Label();
           this.BtnLiberacaoForcada = new System.Windows.Forms.Button();
           this.timer1 = new System.Windows.Forms.Timer(this.components);
           this.BtnTestaDownload = new System.Windows.Forms.Button();
           this.ChkPoSenha = new System.Windows.Forms.CheckBox();
           this.ChkPoCartaoRFID = new System.Windows.Forms.CheckBox();
           this.ChkPoBiometria = new System.Windows.Forms.CheckBox();
           this.label8 = new System.Windows.Forms.Label();
           this.LblDataHora = new System.Windows.Forms.Label();
           this.TimeSemCartao = new System.Windows.Forms.Timer(this.components);
           this.LblQualidade = new System.Windows.Forms.Label();
           this.Label5 = new System.Windows.Forms.Label();
           this.PctDigital = new System.Windows.Forms.PictureBox();
           this.label7 = new System.Windows.Forms.Label();
           this.panel1 = new System.Windows.Forms.Panel();
           this.BtnDestravarSirene = new System.Windows.Forms.Button();
           this.SerialCartao = new System.IO.Ports.SerialPort(this.components);
           this.TimeCartao = new System.Windows.Forms.Timer(this.components);
           this.ChkEquipObrigatorio = new System.Windows.Forms.CheckBox();
           this.ChkEquipRandomico = new System.Windows.Forms.CheckBox();
           this.GbxEquipamento = new System.Windows.Forms.GroupBox();
           this.groupBox1 = new System.Windows.Forms.GroupBox();
           this.BtnConfigurar = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.PctVerde)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctVermelho)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctAmarelo)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctSemSinal)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctDigital)).BeginInit();
           this.GbxEquipamento.SuspendLayout();
           this.groupBox1.SuspendLayout();
           this.SuspendLayout();
           // 
           // PctVerde
           // 
           this.PctVerde.Image = ((System.Drawing.Image)(resources.GetObject("PctVerde.Image")));
           this.PctVerde.InitialImage = ((System.Drawing.Image)(resources.GetObject("PctVerde.InitialImage")));
           this.PctVerde.Location = new System.Drawing.Point(14, 10);
           this.PctVerde.Name = "PctVerde";
           this.PctVerde.Size = new System.Drawing.Size(179, 284);
           this.PctVerde.TabIndex = 0;
           this.PctVerde.TabStop = false;
           this.PctVerde.Visible = false;
           this.PctVerde.WaitOnLoad = true;
           // 
           // PctVermelho
           // 
           this.PctVermelho.Image = ((System.Drawing.Image)(resources.GetObject("PctVermelho.Image")));
           this.PctVermelho.Location = new System.Drawing.Point(13, 10);
           this.PctVermelho.Name = "PctVermelho";
           this.PctVermelho.Size = new System.Drawing.Size(179, 284);
           this.PctVermelho.TabIndex = 1;
           this.PctVermelho.TabStop = false;
           this.PctVermelho.Visible = false;
           this.PctVermelho.WaitOnLoad = true;
           // 
           // PctAmarelo
           // 
           this.PctAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("PctAmarelo.Image")));
           this.PctAmarelo.Location = new System.Drawing.Point(13, 10);
           this.PctAmarelo.Name = "PctAmarelo";
           this.PctAmarelo.Size = new System.Drawing.Size(179, 284);
           this.PctAmarelo.TabIndex = 2;
           this.PctAmarelo.TabStop = false;
           this.PctAmarelo.Visible = false;
           this.PctAmarelo.WaitOnLoad = true;
           // 
           // PctSemSinal
           // 
           this.PctSemSinal.Image = ((System.Drawing.Image)(resources.GetObject("PctSemSinal.Image")));
           this.PctSemSinal.Location = new System.Drawing.Point(12, 11);
           this.PctSemSinal.Name = "PctSemSinal";
           this.PctSemSinal.Size = new System.Drawing.Size(177, 282);
           this.PctSemSinal.TabIndex = 3;
           this.PctSemSinal.TabStop = false;
           this.PctSemSinal.WaitOnLoad = true;
           // 
           // LblMsg
           // 
           this.LblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.LblMsg.BackColor = System.Drawing.Color.White;
           this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblMsg.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.LblMsg.Location = new System.Drawing.Point(12, 299);
           this.LblMsg.Name = "LblMsg";
           this.LblMsg.Size = new System.Drawing.Size(967, 176);
           this.LblMsg.TabIndex = 4;
           this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(209, 252);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(64, 20);
           this.label1.TabIndex = 5;
           this.label1.Text = "Usuário";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label2.Location = new System.Drawing.Point(209, 10);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(162, 20);
           this.label2.TabIndex = 5;
           this.label2.Text = "Foto do Usuário USR";
           // 
           // LblUsuario
           // 
           this.LblUsuario.BackColor = System.Drawing.Color.White;
           this.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.LblUsuario.Location = new System.Drawing.Point(209, 272);
           this.LblUsuario.Name = "LblUsuario";
           this.LblUsuario.Size = new System.Drawing.Size(597, 24);
           this.LblUsuario.TabIndex = 5;
           // 
           // PicFoto
           // 
           this.PicFoto.Location = new System.Drawing.Point(209, 33);
           this.PicFoto.Name = "PicFoto";
           this.PicFoto.Size = new System.Drawing.Size(190, 195);
           this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           this.PicFoto.TabIndex = 6;
           this.PicFoto.TabStop = false;
           this.PicFoto.Click += new System.EventHandler(this.PicFoto_Click);
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(419, 10);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(330, 20);
           this.label4.TabIndex = 7;
           this.label4.Text = "Identificação do Ponto de Controle (PCAP_S)";
           // 
           // LblIdentificacao
           // 
           this.LblIdentificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.LblIdentificacao.BackColor = System.Drawing.Color.White;
           this.LblIdentificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.LblIdentificacao.Location = new System.Drawing.Point(423, 33);
           this.LblIdentificacao.Name = "LblIdentificacao";
           this.LblIdentificacao.Size = new System.Drawing.Size(556, 24);
           this.LblIdentificacao.TabIndex = 8;
           // 
           // BtnLiberacaoForcada
           // 
           this.BtnLiberacaoForcada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.BtnLiberacaoForcada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.BtnLiberacaoForcada.Location = new System.Drawing.Point(812, 188);
           this.BtnLiberacaoForcada.Name = "BtnLiberacaoForcada";
           this.BtnLiberacaoForcada.Size = new System.Drawing.Size(167, 54);
           this.BtnLiberacaoForcada.TabIndex = 11;
           this.BtnLiberacaoForcada.Text = "Liberação Forçada";
           this.BtnLiberacaoForcada.UseVisualStyleBackColor = true;
           this.BtnLiberacaoForcada.Click += new System.EventHandler(this.BtnLiberacaoForcada_Click);
           // 
           // timer1
           // 
           this.timer1.Interval = 3000;
           this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
           // 
           // BtnTestaDownload
           // 
           this.BtnTestaDownload.Location = new System.Drawing.Point(208, 228);
           this.BtnTestaDownload.Name = "BtnTestaDownload";
           this.BtnTestaDownload.Size = new System.Drawing.Size(194, 26);
           this.BtnTestaDownload.TabIndex = 15;
           this.BtnTestaDownload.Text = "Testa Download";
           this.BtnTestaDownload.UseVisualStyleBackColor = true;
           this.BtnTestaDownload.Visible = false;
           this.BtnTestaDownload.Click += new System.EventHandler(this.BtnTestaDownload_Click);
           // 
           // ChkPoSenha
           // 
           this.ChkPoSenha.AutoSize = true;
           this.ChkPoSenha.Enabled = false;
           this.ChkPoSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.ChkPoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.ChkPoSenha.Location = new System.Drawing.Point(6, 70);
           this.ChkPoSenha.Name = "ChkPoSenha";
           this.ChkPoSenha.Size = new System.Drawing.Size(221, 24);
           this.ChkPoSenha.TabIndex = 18;
           this.ChkPoSenha.Text = "Senha de Domínio de Rede";
           this.ChkPoSenha.UseVisualStyleBackColor = true;
           // 
           // ChkPoCartaoRFID
           // 
           this.ChkPoCartaoRFID.AutoSize = true;
           this.ChkPoCartaoRFID.Enabled = false;
           this.ChkPoCartaoRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.ChkPoCartaoRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.ChkPoCartaoRFID.Location = new System.Drawing.Point(6, 44);
           this.ChkPoCartaoRFID.Name = "ChkPoCartaoRFID";
           this.ChkPoCartaoRFID.Size = new System.Drawing.Size(233, 24);
           this.ChkPoCartaoRFID.TabIndex = 17;
           this.ChkPoCartaoRFID.Text = "Cartão de Identificação RFID";
           this.ChkPoCartaoRFID.UseVisualStyleBackColor = true;
           // 
           // ChkPoBiometria
           // 
           this.ChkPoBiometria.AutoSize = true;
           this.ChkPoBiometria.Enabled = false;
           this.ChkPoBiometria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.ChkPoBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.ChkPoBiometria.Location = new System.Drawing.Point(6, 18);
           this.ChkPoBiometria.Name = "ChkPoBiometria";
           this.ChkPoBiometria.Size = new System.Drawing.Size(241, 24);
           this.ChkPoBiometria.TabIndex = 16;
           this.ChkPoBiometria.Text = "Biometria da Impressão Digital";
           this.ChkPoBiometria.UseVisualStyleBackColor = true;
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label8.Location = new System.Drawing.Point(808, 252);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(162, 20);
           this.label8.TabIndex = 13;
           this.label8.Text = "Data/Hora do Acesso";
           // 
           // LblDataHora
           // 
           this.LblDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.LblDataHora.BackColor = System.Drawing.Color.White;
           this.LblDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.LblDataHora.Location = new System.Drawing.Point(812, 272);
           this.LblDataHora.Name = "LblDataHora";
           this.LblDataHora.Size = new System.Drawing.Size(167, 24);
           this.LblDataHora.TabIndex = 14;
           // 
           // TimeSemCartao
           // 
           this.TimeSemCartao.Interval = 1000;
           this.TimeSemCartao.Tick += new System.EventHandler(this.TimeSemCartao_Tick);
           // 
           // LblQualidade
           // 
           this.LblQualidade.BackColor = System.Drawing.Color.White;
           this.LblQualidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblQualidade.Location = new System.Drawing.Point(473, 195);
           this.LblQualidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.LblQualidade.Name = "LblQualidade";
           this.LblQualidade.Size = new System.Drawing.Size(54, 21);
           this.LblQualidade.TabIndex = 43;
           this.LblQualidade.Visible = false;
           // 
           // Label5
           // 
           this.Label5.AutoSize = true;
           this.Label5.Location = new System.Drawing.Point(415, 201);
           this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.Label5.Name = "Label5";
           this.Label5.Size = new System.Drawing.Size(58, 13);
           this.Label5.TabIndex = 42;
           this.Label5.Text = "Qualidade:";
           this.Label5.Visible = false;
           // 
           // PctDigital
           // 
           this.PctDigital.BackColor = System.Drawing.SystemColors.Window;
           this.PctDigital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.PctDigital.Location = new System.Drawing.Point(423, 80);
           this.PctDigital.Name = "PctDigital";
           this.PctDigital.Size = new System.Drawing.Size(104, 109);
           this.PctDigital.TabIndex = 41;
           this.PctDigital.TabStop = false;
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Location = new System.Drawing.Point(418, 65);
           this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(87, 13);
           this.label7.TabIndex = 40;
           this.label7.Text = "Impressão Digital";
           // 
           // panel1
           // 
           this.panel1.BackColor = System.Drawing.Color.White;
           this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.panel1.Location = new System.Drawing.Point(13, 8);
           this.panel1.Name = "panel1";
           this.panel1.Size = new System.Drawing.Size(180, 286);
           this.panel1.TabIndex = 44;
           // 
           // BtnDestravarSirene
           // 
           this.BtnDestravarSirene.Enabled = false;
           this.BtnDestravarSirene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.BtnDestravarSirene.Location = new System.Drawing.Point(653, 188);
           this.BtnDestravarSirene.Name = "BtnDestravarSirene";
           this.BtnDestravarSirene.Size = new System.Drawing.Size(156, 54);
           this.BtnDestravarSirene.TabIndex = 11;
           this.BtnDestravarSirene.Text = "Rearmar Alarme";
           this.BtnDestravarSirene.UseVisualStyleBackColor = true;
           this.BtnDestravarSirene.Click += new System.EventHandler(this.BtnDestravarSirene_Click);
           // 
           // TimeCartao
           // 
           this.TimeCartao.Interval = 150;
           this.TimeCartao.Tick += new System.EventHandler(this.TimeCartao_Tick);
           // 
           // ChkEquipObrigatorio
           // 
           this.ChkEquipObrigatorio.AutoSize = true;
           this.ChkEquipObrigatorio.Enabled = false;
           this.ChkEquipObrigatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.ChkEquipObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.ChkEquipObrigatorio.Location = new System.Drawing.Point(8, 29);
           this.ChkEquipObrigatorio.Name = "ChkEquipObrigatorio";
           this.ChkEquipObrigatorio.Size = new System.Drawing.Size(158, 24);
           this.ChkEquipObrigatorio.TabIndex = 45;
           this.ChkEquipObrigatorio.Text = "Obrigatória (100%)";
           this.ChkEquipObrigatorio.UseVisualStyleBackColor = true;
           // 
           // ChkEquipRandomico
           // 
           this.ChkEquipRandomico.AutoSize = true;
           this.ChkEquipRandomico.Enabled = false;
           this.ChkEquipRandomico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           this.ChkEquipRandomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.ChkEquipRandomico.Location = new System.Drawing.Point(8, 58);
           this.ChkEquipRandomico.Name = "ChkEquipRandomico";
           this.ChkEquipRandomico.Size = new System.Drawing.Size(106, 24);
           this.ChkEquipRandomico.TabIndex = 46;
           this.ChkEquipRandomico.Text = "Randômica";
           this.ChkEquipRandomico.UseVisualStyleBackColor = true;
           // 
           // GbxEquipamento
           // 
           this.GbxEquipamento.Controls.Add(this.ChkEquipObrigatorio);
           this.GbxEquipamento.Controls.Add(this.ChkEquipRandomico);
           this.GbxEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.GbxEquipamento.Location = new System.Drawing.Point(787, 73);
           this.GbxEquipamento.Name = "GbxEquipamento";
           this.GbxEquipamento.Size = new System.Drawing.Size(193, 100);
           this.GbxEquipamento.TabIndex = 47;
           this.GbxEquipamento.TabStop = false;
           this.GbxEquipamento.Text = "Inspeção de Equipamentos";
           // 
           // groupBox1
           // 
           this.groupBox1.Controls.Add(this.ChkPoBiometria);
           this.groupBox1.Controls.Add(this.ChkPoSenha);
           this.groupBox1.Controls.Add(this.ChkPoCartaoRFID);
           this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.groupBox1.Location = new System.Drawing.Point(533, 73);
           this.groupBox1.Name = "groupBox1";
           this.groupBox1.Size = new System.Drawing.Size(252, 100);
           this.groupBox1.TabIndex = 48;
           this.groupBox1.TabStop = false;
           this.groupBox1.Text = "Identificação/Autenticação Requerida";
           // 
           // BtnConfigurar
           // 
           this.BtnConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.BtnConfigurar.Location = new System.Drawing.Point(539, 188);
           this.BtnConfigurar.Name = "BtnConfigurar";
           this.BtnConfigurar.Size = new System.Drawing.Size(112, 54);
           this.BtnConfigurar.TabIndex = 49;
           this.BtnConfigurar.Text = "Configurar PCAP_S";
           this.BtnConfigurar.UseVisualStyleBackColor = true;
           this.BtnConfigurar.Visible = false;
           this.BtnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
           // 
           // FrmPrincipal
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(982, 484);
           this.ControlBox = false;
           this.Controls.Add(this.BtnConfigurar);
           this.Controls.Add(this.groupBox1);
           this.Controls.Add(this.LblQualidade);
           this.Controls.Add(this.GbxEquipamento);
           this.Controls.Add(this.Label5);
           this.Controls.Add(this.PctDigital);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.BtnTestaDownload);
           this.Controls.Add(this.LblDataHora);
           this.Controls.Add(this.LblIdentificacao);
           this.Controls.Add(this.BtnLiberacaoForcada);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.PicFoto);
           this.Controls.Add(this.BtnDestravarSirene);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.LblUsuario);
           this.Controls.Add(this.LblMsg);
           this.Controls.Add(this.PctAmarelo);
           this.Controls.Add(this.PctSemSinal);
           this.Controls.Add(this.PctVermelho);
           this.Controls.Add(this.PctVerde);
           this.Controls.Add(this.panel1);
           this.Name = "FrmPrincipal";
           this.Text = "SiCAP - Ponto de Controle (PCAP_S)";
           this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
           this.Load += new System.EventHandler(this.FrmPrincipal_Load);
           ((System.ComponentModel.ISupportInitialize)(this.PctVerde)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctVermelho)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctAmarelo)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctSemSinal)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.PctDigital)).EndInit();
           this.GbxEquipamento.ResumeLayout(false);
           this.GbxEquipamento.PerformLayout();
           this.groupBox1.ResumeLayout(false);
           this.groupBox1.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctVerde;
        private System.Windows.Forms.PictureBox PctVermelho;
        private System.Windows.Forms.PictureBox PctAmarelo;
        private System.Windows.Forms.PictureBox PctSemSinal;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblIdentificacao;
        private System.Windows.Forms.Button BtnLiberacaoForcada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnTestaDownload;
        private System.Windows.Forms.CheckBox ChkPoSenha;
        private System.Windows.Forms.CheckBox ChkPoCartaoRFID;
        private System.Windows.Forms.CheckBox ChkPoBiometria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDataHora;
        private System.Windows.Forms.Timer TimeSemCartao;
        internal System.Windows.Forms.Label LblQualidade;
        internal System.Windows.Forms.Label Label5;
        public System.Windows.Forms.PictureBox PctDigital;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDestravarSirene;
        private System.IO.Ports.SerialPort SerialCartao;
        private System.Windows.Forms.Timer TimeCartao;
        private System.Windows.Forms.CheckBox ChkEquipObrigatorio;
        private System.Windows.Forms.CheckBox ChkEquipRandomico;
        private System.Windows.Forms.GroupBox GbxEquipamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConfigurar;
    }
}

