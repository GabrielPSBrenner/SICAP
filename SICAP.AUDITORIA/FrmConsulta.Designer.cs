namespace ACESSO.AUDITORIA
{
    partial class FrmConsulta
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
           this.LblTextofiltro = new System.Windows.Forms.Label();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.APDataAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.APCodigoTipoPontoControle = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.APCodigoPontoControle = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.PoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.USTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.APCodigoCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.APNegado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
           this.APAcessoForcado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
           this.BtnDetalhes = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnFechar = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.label1.Location = new System.Drawing.Point(12, 9);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(893, 23);
           this.label1.TabIndex = 0;
           this.label1.Text = "Filtro Selecionado";
           this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
           // LblTextofiltro
           // 
           this.LblTextofiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.LblTextofiltro.BackColor = System.Drawing.Color.White;
           this.LblTextofiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           this.LblTextofiltro.Location = new System.Drawing.Point(12, 31);
           this.LblTextofiltro.Name = "LblTextofiltro";
           this.LblTextofiltro.Size = new System.Drawing.Size(893, 48);
           this.LblTextofiltro.TabIndex = 1;
           this.LblTextofiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
           // GrdItens
           // 
           this.GrdItens.AllowUserToAddRows = false;
           this.GrdItens.AllowUserToDeleteRows = false;
           this.GrdItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APDataAcesso,
            this.APCodigoTipoPontoControle,
            this.APCodigoPontoControle,
            this.PoNome,
            this.USTIPO,
            this.Matricula,
            this.NomeUsuario,
            this.APCodigoCartao,
            this.APNegado,
            this.APAcessoForcado,
            this.BtnDetalhes});
           this.GrdItens.Location = new System.Drawing.Point(12, 120);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(893, 315);
           this.GrdItens.TabIndex = 2;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           this.GrdItens.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdItens_DataBindingComplete);
           // 
           // APDataAcesso
           // 
           this.APDataAcesso.DataPropertyName = "APDataAcesso";
           this.APDataAcesso.HeaderText = "Data/Hora de Acesso";
           this.APDataAcesso.Name = "APDataAcesso";
           this.APDataAcesso.ReadOnly = true;
           this.APDataAcesso.Width = 140;
           // 
           // APCodigoTipoPontoControle
           // 
           this.APCodigoTipoPontoControle.DataPropertyName = "APTipoPontoControle";
           this.APCodigoTipoPontoControle.HeaderText = "T-Ponto";
           this.APCodigoTipoPontoControle.Name = "APCodigoTipoPontoControle";
           this.APCodigoTipoPontoControle.ReadOnly = true;
           this.APCodigoTipoPontoControle.Width = 50;
           // 
           // APCodigoPontoControle
           // 
           this.APCodigoPontoControle.DataPropertyName = "APCodigoPontoControle";
           this.APCodigoPontoControle.HeaderText = "C-Ponto";
           this.APCodigoPontoControle.Name = "APCodigoPontoControle";
           this.APCodigoPontoControle.ReadOnly = true;
           this.APCodigoPontoControle.Width = 50;
           // 
           // PoNome
           // 
           this.PoNome.DataPropertyName = "PoNome";
           this.PoNome.HeaderText = "Ponto";
           this.PoNome.Name = "PoNome";
           this.PoNome.ReadOnly = true;
           this.PoNome.Width = 150;
           // 
           // USTIPO
           // 
           this.USTIPO.DataPropertyName = "USTIPO";
           this.USTIPO.HeaderText = "T-Usuário";
           this.USTIPO.Name = "USTIPO";
           this.USTIPO.ReadOnly = true;
           this.USTIPO.Width = 60;
           // 
           // Matricula
           // 
           this.Matricula.HeaderText = "C-Usuário";
           this.Matricula.Name = "Matricula";
           this.Matricula.ReadOnly = true;
           this.Matricula.Width = 60;
           // 
           // NomeUsuario
           // 
           this.NomeUsuario.HeaderText = "Nome";
           this.NomeUsuario.Name = "NomeUsuario";
           this.NomeUsuario.ReadOnly = true;
           this.NomeUsuario.Width = 150;
           // 
           // APCodigoCartao
           // 
           this.APCodigoCartao.DataPropertyName = "APCodigoCartao";
           this.APCodigoCartao.HeaderText = "C-Cartão";
           this.APCodigoCartao.Name = "APCodigoCartao";
           this.APCodigoCartao.ReadOnly = true;
           this.APCodigoCartao.Width = 50;
           // 
           // APNegado
           // 
           this.APNegado.DataPropertyName = "APNegado";
           this.APNegado.HeaderText = "Negado";
           this.APNegado.Name = "APNegado";
           this.APNegado.ReadOnly = true;
           this.APNegado.Width = 50;
           // 
           // APAcessoForcado
           // 
           this.APAcessoForcado.DataPropertyName = "APAcessoForcado";
           this.APAcessoForcado.HeaderText = "Forçado";
           this.APAcessoForcado.Name = "APAcessoForcado";
           this.APAcessoForcado.ReadOnly = true;
           this.APAcessoForcado.Width = 50;
           // 
           // BtnDetalhes
           // 
           this.BtnDetalhes.HeaderText = "Detalhes";
           this.BtnDetalhes.Name = "BtnDetalhes";
           this.BtnDetalhes.ReadOnly = true;
           this.BtnDetalhes.Width = 50;
           // 
           // BtnFechar
           // 
           this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           this.BtnFechar.Location = new System.Drawing.Point(793, 83);
           this.BtnFechar.Name = "BtnFechar";
           this.BtnFechar.Size = new System.Drawing.Size(112, 33);
           this.BtnFechar.TabIndex = 3;
           this.BtnFechar.Text = "&Fechar";
           this.BtnFechar.UseVisualStyleBackColor = true;
           this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
           // 
           // FrmConsulta
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.CancelButton = this.BtnFechar;
           this.ClientSize = new System.Drawing.Size(917, 441);
           this.Controls.Add(this.BtnFechar);
           this.Controls.Add(this.GrdItens);
           this.Controls.Add(this.LblTextofiltro);
           this.Controls.Add(this.label1);
           this.Name = "FrmConsulta";
           this.Text = "Consulta aos Registros de Tentativas de Acessos RTA_USR";
           this.Load += new System.EventHandler(this.FrmConsulta_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTextofiltro;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn APDataAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn APCodigoTipoPontoControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn APCodigoPontoControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn USTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn APCodigoCartao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn APNegado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn APAcessoForcado;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDetalhes;
    }
}