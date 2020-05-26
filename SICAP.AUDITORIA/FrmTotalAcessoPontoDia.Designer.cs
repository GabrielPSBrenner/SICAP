namespace ACESSO.AUDITORIA
{
    partial class FrmTotalAcessoPontoDia
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
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.PoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APCodigoPontoControle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MÊS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APNegado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.MskDataFim = new System.Windows.Forms.MaskedTextBox();
            this.MskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCarregarDados = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdItens
            // 
            this.GrdItens.AllowUserToAddRows = false;
            this.GrdItens.AllowUserToDeleteRows = false;
            this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoTipo,
            this.APCodigoPontoControle,
            this.PoNome,
            this.DIA,
            this.MÊS,
            this.ANO,
            this.TotalAcesso,
            this.APNegado});
            this.GrdItens.Location = new System.Drawing.Point(1, 63);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.Size = new System.Drawing.Size(719, 348);
            this.GrdItens.TabIndex = 6;
            // 
            // PoTipo
            // 
            this.PoTipo.DataPropertyName = "PoTipo";
            this.PoTipo.HeaderText = "T-Ponto";
            this.PoTipo.Name = "PoTipo";
            this.PoTipo.ReadOnly = true;
            this.PoTipo.Width = 75;
            // 
            // APCodigoPontoControle
            // 
            this.APCodigoPontoControle.DataPropertyName = "APCodigoPontoControle";
            this.APCodigoPontoControle.HeaderText = "C-Ponto";
            this.APCodigoPontoControle.Name = "APCodigoPontoControle";
            this.APCodigoPontoControle.ReadOnly = true;
            this.APCodigoPontoControle.Width = 75;
            // 
            // PoNome
            // 
            this.PoNome.DataPropertyName = "PoNome";
            this.PoNome.HeaderText = "Nome do Ponto";
            this.PoNome.Name = "PoNome";
            this.PoNome.ReadOnly = true;
            this.PoNome.Width = 250;
            // 
            // DIA
            // 
            this.DIA.DataPropertyName = "DIA";
            this.DIA.HeaderText = "DIA";
            this.DIA.Name = "DIA";
            this.DIA.ReadOnly = true;
            this.DIA.Width = 40;
            // 
            // MÊS
            // 
            this.MÊS.DataPropertyName = "MÊS";
            this.MÊS.HeaderText = "MÊS";
            this.MÊS.Name = "MÊS";
            this.MÊS.ReadOnly = true;
            this.MÊS.Width = 40;
            // 
            // ANO
            // 
            this.ANO.DataPropertyName = "ANO";
            this.ANO.HeaderText = "ANO";
            this.ANO.Name = "ANO";
            this.ANO.ReadOnly = true;
            this.ANO.Width = 40;
            // 
            // TotalAcesso
            // 
            this.TotalAcesso.DataPropertyName = "TotalAcesso";
            this.TotalAcesso.HeaderText = "T-Acessos";
            this.TotalAcesso.Name = "TotalAcesso";
            this.TotalAcesso.ReadOnly = true;
            this.TotalAcesso.Width = 60;
            // 
            // APNegado
            // 
            this.APNegado.DataPropertyName = "APNegado";
            this.APNegado.HeaderText = "Negado";
            this.APNegado.Name = "APNegado";
            this.APNegado.ReadOnly = true;
            this.APNegado.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "e";
            // 
            // MskDataFim
            // 
            this.MskDataFim.Location = new System.Drawing.Point(198, 26);
            this.MskDataFim.Mask = "##/##/####";
            this.MskDataFim.Name = "MskDataFim";
            this.MskDataFim.PromptChar = ' ';
            this.MskDataFim.Size = new System.Drawing.Size(73, 20);
            this.MskDataFim.TabIndex = 3;
            // 
            // MskDataInicio
            // 
            this.MskDataInicio.Location = new System.Drawing.Point(103, 26);
            this.MskDataInicio.Mask = "##/##/####";
            this.MskDataInicio.Name = "MskDataInicio";
            this.MskDataInicio.PromptChar = ' ';
            this.MskDataInicio.Size = new System.Drawing.Size(70, 20);
            this.MskDataInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Período -> Entre";
            // 
            // BtnCarregarDados
            // 
            this.BtnCarregarDados.Location = new System.Drawing.Point(275, 12);
            this.BtnCarregarDados.Name = "BtnCarregarDados";
            this.BtnCarregarDados.Size = new System.Drawing.Size(222, 42);
            this.BtnCarregarDados.TabIndex = 4;
            this.BtnCarregarDados.Text = "&Carregar Dados";
            this.BtnCarregarDados.UseVisualStyleBackColor = true;
            this.BtnCarregarDados.Click += new System.EventHandler(this.BtnCarregarDados_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFechar.Location = new System.Drawing.Point(498, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(222, 42);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmTotalAcessoPontoDia
            // 
            this.AcceptButton = this.BtnCarregarDados;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnFechar;
            this.ClientSize = new System.Drawing.Size(722, 415);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCarregarDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskDataFim);
            this.Controls.Add(this.MskDataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTotalAcessoPontoDia";
            this.Text = "Lista o Total de Acessos por Ponto de Controle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTotalAcessoPontoDia_FormClosed);
            this.Load += new System.EventHandler(this.FrmTotalAcessoPontoDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn APCodigoPontoControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MÊS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAcesso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn APNegado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskDataFim;
        private System.Windows.Forms.MaskedTextBox MskDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCarregarDados;
        private System.Windows.Forms.Button BtnFechar;
    }
}