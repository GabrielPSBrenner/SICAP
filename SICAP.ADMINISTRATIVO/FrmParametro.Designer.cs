namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmParametro
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
            ValidadorWindows.MyControl myControl10 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl11 = new ValidadorWindows.MyControl();
            ValidadorWindows.MyControl myControl12 = new ValidadorWindows.MyControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPATempoExpiraSaida = new System.Windows.Forms.TextBox();
            this.TxtPAServidorDominio = new System.Windows.Forms.TextBox();
            this.TxtPAServidorCorreio = new System.Windows.Forms.TextBox();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.validador1 = new ValidadorWindows.Validador(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de expiração automática de saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Servidor de Domínio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Servidor de Correio";
            // 
            // TxtPATempoExpiraSaida
            // 
            this.TxtPATempoExpiraSaida.Location = new System.Drawing.Point(222, 16);
            this.TxtPATempoExpiraSaida.MaxLength = 15;
            this.TxtPATempoExpiraSaida.Name = "TxtPATempoExpiraSaida";
            this.TxtPATempoExpiraSaida.Size = new System.Drawing.Size(108, 20);
            this.TxtPATempoExpiraSaida.TabIndex = 1;
            // 
            // TxtPAServidorDominio
            // 
            this.TxtPAServidorDominio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPAServidorDominio.Location = new System.Drawing.Point(222, 42);
            this.TxtPAServidorDominio.MaxLength = 100;
            this.TxtPAServidorDominio.Name = "TxtPAServidorDominio";
            this.TxtPAServidorDominio.Size = new System.Drawing.Size(641, 20);
            this.TxtPAServidorDominio.TabIndex = 3;
            // 
            // TxtPAServidorCorreio
            // 
            this.TxtPAServidorCorreio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPAServidorCorreio.Location = new System.Drawing.Point(222, 67);
            this.TxtPAServidorCorreio.MaxLength = 100;
            this.TxtPAServidorCorreio.Name = "TxtPAServidorCorreio";
            this.TxtPAServidorCorreio.Size = new System.Drawing.Size(641, 20);
            this.TxtPAServidorCorreio.TabIndex = 5;
            // 
            // BtnCancela
            // 
            this.BtnCancela.Location = new System.Drawing.Point(772, 93);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(90, 30);
            this.BtnCancela.TabIndex = 7;
            this.BtnCancela.Text = "Cancelar";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(676, 93);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // validador1
            // 
            myControl10.CasasDecimais = ((byte)(0));
            myControl10.Controle = this.TxtPATempoExpiraSaida;
            myControl10.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl10.MarcaConteudo = true;
            myControl10.NomeCampo = "Tempo de Expiração da Saída";
            myControl10.Requerido = true;
            myControl10.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
            myControl11.CasasDecimais = ((byte)(0));
            myControl11.Controle = this.TxtPAServidorDominio;
            myControl11.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl11.MarcaConteudo = false;
            myControl11.NomeCampo = "Servidor de Domínio";
            myControl11.Requerido = true;
            myControl11.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl12.CasasDecimais = ((byte)(0));
            myControl12.Controle = this.TxtPAServidorCorreio;
            myControl12.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl12.MarcaConteudo = true;
            myControl12.NomeCampo = "Servidor de Correio";
            myControl12.Requerido = true;
            myControl12.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            this.validador1.Controles.Add(myControl10);
            this.validador1.Controles.Add(myControl11);
            this.validador1.Controles.Add(myControl12);
            // 
            // FrmParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 130);
            this.Controls.Add(this.BtnCancela);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtPAServidorCorreio);
            this.Controls.Add(this.TxtPAServidorDominio);
            this.Controls.Add(this.TxtPATempoExpiraSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmParametro";
            this.Text = "Parâmetros do Sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmParametro_FormClosed);
            this.Load += new System.EventHandler(this.FrmParametro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPATempoExpiraSaida;
        private System.Windows.Forms.TextBox TxtPAServidorDominio;
        private System.Windows.Forms.TextBox TxtPAServidorCorreio;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private ValidadorWindows.Validador validador1;
    }
}