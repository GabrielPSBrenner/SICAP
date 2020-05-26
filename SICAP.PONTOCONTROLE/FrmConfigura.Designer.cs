namespace ACESSO.PONTOCONTROLE
{
    partial class FrmConfigura
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboPontoControle = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkPoBiometria = new System.Windows.Forms.CheckBox();
            this.ChkPoCartaoRFID = new System.Windows.Forms.CheckBox();
            this.ChkPoSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkPoControlaSaida = new System.Windows.Forms.CheckBox();
            this.ChkPoDisparaAlarme = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkPoPermiteLiberacaoForcada = new System.Windows.Forms.CheckBox();
            this.LblPoDescricao = new System.Windows.Forms.Label();
            this.LblPoObservacao = new System.Windows.Forms.Label();
            this.LblPoTentativaIndevidaDisparaAlarme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboTranca = new System.Windows.Forms.ComboBox();
            this.LblSirene = new System.Windows.Forms.Label();
            this.CboSirene = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPortaSerial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ponto de Controle";
            // 
            // CboPontoControle
            // 
            this.CboPontoControle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPontoControle.FormattingEnabled = true;
            this.CboPontoControle.Location = new System.Drawing.Point(7, 28);
            this.CboPontoControle.Name = "CboPontoControle";
            this.CboPontoControle.Size = new System.Drawing.Size(599, 21);
            this.CboPontoControle.TabIndex = 1;
            this.CboPontoControle.SelectedIndexChanged += new System.EventHandler(this.CboPontoControle_SelectedIndexChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(510, 327);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(96, 42);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "&Confirma";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // ChkPoBiometria
            // 
            this.ChkPoBiometria.AutoSize = true;
            this.ChkPoBiometria.Enabled = false;
            this.ChkPoBiometria.Location = new System.Drawing.Point(9, 263);
            this.ChkPoBiometria.Name = "ChkPoBiometria";
            this.ChkPoBiometria.Size = new System.Drawing.Size(69, 17);
            this.ChkPoBiometria.TabIndex = 4;
            this.ChkPoBiometria.Text = "Biometria";
            this.ChkPoBiometria.UseVisualStyleBackColor = true;
            // 
            // ChkPoCartaoRFID
            // 
            this.ChkPoCartaoRFID.AutoSize = true;
            this.ChkPoCartaoRFID.Enabled = false;
            this.ChkPoCartaoRFID.Location = new System.Drawing.Point(84, 263);
            this.ChkPoCartaoRFID.Name = "ChkPoCartaoRFID";
            this.ChkPoCartaoRFID.Size = new System.Drawing.Size(85, 17);
            this.ChkPoCartaoRFID.TabIndex = 4;
            this.ChkPoCartaoRFID.Text = "Cartão RFID";
            this.ChkPoCartaoRFID.UseVisualStyleBackColor = true;
            // 
            // ChkPoSenha
            // 
            this.ChkPoSenha.AutoSize = true;
            this.ChkPoSenha.Enabled = false;
            this.ChkPoSenha.Location = new System.Drawing.Point(175, 263);
            this.ChkPoSenha.Name = "ChkPoSenha";
            this.ChkPoSenha.Size = new System.Drawing.Size(57, 17);
            this.ChkPoSenha.TabIndex = 4;
            this.ChkPoSenha.Text = "Senha";
            this.ChkPoSenha.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Observação";
            // 
            // ChkPoControlaSaida
            // 
            this.ChkPoControlaSaida.AutoSize = true;
            this.ChkPoControlaSaida.Enabled = false;
            this.ChkPoControlaSaida.Location = new System.Drawing.Point(238, 263);
            this.ChkPoControlaSaida.Name = "ChkPoControlaSaida";
            this.ChkPoControlaSaida.Size = new System.Drawing.Size(106, 17);
            this.ChkPoControlaSaida.TabIndex = 6;
            this.ChkPoControlaSaida.Text = "Controla a Saída";
            this.ChkPoControlaSaida.UseVisualStyleBackColor = true;
            // 
            // ChkPoDisparaAlarme
            // 
            this.ChkPoDisparaAlarme.AutoSize = true;
            this.ChkPoDisparaAlarme.Enabled = false;
            this.ChkPoDisparaAlarme.Location = new System.Drawing.Point(350, 263);
            this.ChkPoDisparaAlarme.Name = "ChkPoDisparaAlarme";
            this.ChkPoDisparaAlarme.Size = new System.Drawing.Size(97, 17);
            this.ChkPoDisparaAlarme.TabIndex = 6;
            this.ChkPoDisparaAlarme.Text = "Dispara Alarme";
            this.ChkPoDisparaAlarme.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd Tentativas Dispara Alarme";
            // 
            // ChkPoPermiteLiberacaoForcada
            // 
            this.ChkPoPermiteLiberacaoForcada.AutoSize = true;
            this.ChkPoPermiteLiberacaoForcada.Enabled = false;
            this.ChkPoPermiteLiberacaoForcada.Location = new System.Drawing.Point(453, 263);
            this.ChkPoPermiteLiberacaoForcada.Name = "ChkPoPermiteLiberacaoForcada";
            this.ChkPoPermiteLiberacaoForcada.Size = new System.Drawing.Size(153, 17);
            this.ChkPoPermiteLiberacaoForcada.TabIndex = 8;
            this.ChkPoPermiteLiberacaoForcada.Text = "Permite Liberação Forçada";
            this.ChkPoPermiteLiberacaoForcada.UseVisualStyleBackColor = true;
            // 
            // LblPoDescricao
            // 
            this.LblPoDescricao.BackColor = System.Drawing.Color.White;
            this.LblPoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPoDescricao.Location = new System.Drawing.Point(4, 126);
            this.LblPoDescricao.Name = "LblPoDescricao";
            this.LblPoDescricao.Size = new System.Drawing.Size(603, 56);
            this.LblPoDescricao.TabIndex = 9;
            // 
            // LblPoObservacao
            // 
            this.LblPoObservacao.BackColor = System.Drawing.Color.White;
            this.LblPoObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPoObservacao.Location = new System.Drawing.Point(4, 198);
            this.LblPoObservacao.Name = "LblPoObservacao";
            this.LblPoObservacao.Size = new System.Drawing.Size(603, 56);
            this.LblPoObservacao.TabIndex = 10;
            // 
            // LblPoTentativaIndevidaDisparaAlarme
            // 
            this.LblPoTentativaIndevidaDisparaAlarme.BackColor = System.Drawing.Color.White;
            this.LblPoTentativaIndevidaDisparaAlarme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPoTentativaIndevidaDisparaAlarme.Location = new System.Drawing.Point(3, 309);
            this.LblPoTentativaIndevidaDisparaAlarme.Name = "LblPoTentativaIndevidaDisparaAlarme";
            this.LblPoTentativaIndevidaDisparaAlarme.Size = new System.Drawing.Size(63, 22);
            this.LblPoTentativaIndevidaDisparaAlarme.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porta do Rele que Aciona a Tranca";
            // 
            // CboTranca
            // 
            this.CboTranca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTranca.FormattingEnabled = true;
            this.CboTranca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CboTranca.Location = new System.Drawing.Point(6, 77);
            this.CboTranca.Name = "CboTranca";
            this.CboTranca.Size = new System.Drawing.Size(171, 21);
            this.CboTranca.TabIndex = 13;
            // 
            // LblSirene
            // 
            this.LblSirene.AutoSize = true;
            this.LblSirene.Location = new System.Drawing.Point(183, 61);
            this.LblSirene.Name = "LblSirene";
            this.LblSirene.Size = new System.Drawing.Size(171, 13);
            this.LblSirene.TabIndex = 14;
            this.LblSirene.Text = "Porta do Rele que Aciona a Sirene";
            // 
            // CboSirene
            // 
            this.CboSirene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSirene.FormattingEnabled = true;
            this.CboSirene.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CboSirene.Location = new System.Drawing.Point(183, 77);
            this.CboSirene.Name = "CboSirene";
            this.CboSirene.Size = new System.Drawing.Size(171, 21);
            this.CboSirene.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Porta Serial do Leitor de Cartão";
            // 
            // TxtPortaSerial
            // 
            this.TxtPortaSerial.Location = new System.Drawing.Point(363, 77);
            this.TxtPortaSerial.MaxLength = 10;
            this.TxtPortaSerial.Name = "TxtPortaSerial";
            this.TxtPortaSerial.Size = new System.Drawing.Size(151, 20);
            this.TxtPortaSerial.TabIndex = 17;
            this.TxtPortaSerial.Text = "COM1";
            // 
            // FrmConfigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPortaSerial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboSirene);
            this.Controls.Add(this.LblSirene);
            this.Controls.Add(this.CboTranca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPoTentativaIndevidaDisparaAlarme);
            this.Controls.Add(this.LblPoObservacao);
            this.Controls.Add(this.LblPoDescricao);
            this.Controls.Add(this.ChkPoPermiteLiberacaoForcada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkPoDisparaAlarme);
            this.Controls.Add(this.ChkPoControlaSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChkPoSenha);
            this.Controls.Add(this.ChkPoCartaoRFID);
            this.Controls.Add(this.ChkPoBiometria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CboPontoControle);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmConfigura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração da Estação";
            this.Load += new System.EventHandler(this.FrmConfigura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPontoControle;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkPoBiometria;
        private System.Windows.Forms.CheckBox ChkPoCartaoRFID;
        private System.Windows.Forms.CheckBox ChkPoSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkPoControlaSaida;
        private System.Windows.Forms.CheckBox ChkPoDisparaAlarme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkPoPermiteLiberacaoForcada;
        private System.Windows.Forms.Label LblPoDescricao;
        private System.Windows.Forms.Label LblPoObservacao;
        private System.Windows.Forms.Label LblPoTentativaIndevidaDisparaAlarme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboTranca;
        private System.Windows.Forms.Label LblSirene;
        private System.Windows.Forms.ComboBox CboSirene;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPortaSerial;
    }
}