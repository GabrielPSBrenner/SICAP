namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmTipoEquipamento
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
           this.TxtTECodigo = new System.Windows.Forms.TextBox();
           this.TxtTEDescricao = new System.Windows.Forms.TextBox();
           this.GrdItens = new System.Windows.Forms.DataGridView();
           this.label1 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.btnSalvar = new System.Windows.Forms.Button();
           this.validador1 = new ValidadorWindows.Validador(this.components);
           this.BtnCancela = new System.Windows.Forms.Button();
           this.ChkTEEPI = new System.Windows.Forms.CheckBox();
           this.EqCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.EqDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
           this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
           this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
           this.SuspendLayout();
           // 
           // TxtTECodigo
           // 
           this.TxtTECodigo.Location = new System.Drawing.Point(75, 10);
           this.TxtTECodigo.MaxLength = 3;
           this.TxtTECodigo.Name = "TxtTECodigo";
           this.TxtTECodigo.Size = new System.Drawing.Size(48, 20);
           this.TxtTECodigo.TabIndex = 1;
           // 
           // TxtTEDescricao
           // 
           this.TxtTEDescricao.Location = new System.Drawing.Point(75, 36);
           this.TxtTEDescricao.MaxLength = 50;
           this.TxtTEDescricao.Name = "TxtTEDescricao";
           this.TxtTEDescricao.Size = new System.Drawing.Size(486, 20);
           this.TxtTEDescricao.TabIndex = 3;
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
            this.EqDescricao,
            this.BtnAlterar,
            this.BtnExcluir});
           this.GrdItens.Location = new System.Drawing.Point(1, 108);
           this.GrdItens.Name = "GrdItens";
           this.GrdItens.RowHeadersWidth = 4;
           this.GrdItens.Size = new System.Drawing.Size(622, 193);
           this.GrdItens.TabIndex = 7;
           this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(31, 13);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(40, 13);
           this.label1.TabIndex = 0;
           this.label1.Text = "Código";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(36, 43);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(35, 13);
           this.label2.TabIndex = 2;
           this.label2.Text = "Nome";
           // 
           // btnSalvar
           // 
           this.btnSalvar.Location = new System.Drawing.Point(75, 62);
           this.btnSalvar.Name = "btnSalvar";
           this.btnSalvar.Size = new System.Drawing.Size(90, 40);
           this.btnSalvar.TabIndex = 5;
           this.btnSalvar.Text = "Salvar";
           this.btnSalvar.UseVisualStyleBackColor = true;
           this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
           // 
           // validador1
           // 
           myControl1.CasasDecimais = ((byte)(0));
           myControl1.Controle = this.TxtTECodigo;
           myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl1.MarcaConteudo = true;
           myControl1.NomeCampo = "Código";
           myControl1.Requerido = false;
           myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
           myControl2.CasasDecimais = ((byte)(0));
           myControl2.Controle = this.TxtTEDescricao;
           myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
           myControl2.MarcaConteudo = false;
           myControl2.NomeCampo = "Descrição";
           myControl2.Requerido = true;
           myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
           this.validador1.Controles.Add(myControl1);
           this.validador1.Controles.Add(myControl2);
           // 
           // BtnCancela
           // 
           this.BtnCancela.Location = new System.Drawing.Point(165, 62);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(90, 40);
           this.BtnCancela.TabIndex = 6;
           this.BtnCancela.Text = "Cancelar";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // ChkTEEPI
           // 
           this.ChkTEEPI.AutoSize = true;
           this.ChkTEEPI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
           this.ChkTEEPI.Location = new System.Drawing.Point(327, 75);
           this.ChkTEEPI.Name = "ChkTEEPI";
           this.ChkTEEPI.Size = new System.Drawing.Size(43, 17);
           this.ChkTEEPI.TabIndex = 4;
           this.ChkTEEPI.Text = "EPI";
           this.ChkTEEPI.UseVisualStyleBackColor = true;
           this.ChkTEEPI.Visible = false;
           // 
           // EqCodigo
           // 
           this.EqCodigo.DataPropertyName = "TECodigo";
           this.EqCodigo.HeaderText = "Código";
           this.EqCodigo.Name = "EqCodigo";
           this.EqCodigo.ReadOnly = true;
           this.EqCodigo.Width = 60;
           // 
           // EqDescricao
           // 
           this.EqDescricao.DataPropertyName = "TEDescricao";
           this.EqDescricao.HeaderText = "Nome";
           this.EqDescricao.Name = "EqDescricao";
           this.EqDescricao.ReadOnly = true;
           this.EqDescricao.Width = 350;
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
           // FrmTipoEquipamento
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(623, 301);
           this.Controls.Add(this.ChkTEEPI);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.btnSalvar);
           this.Controls.Add(this.TxtTEDescricao);
           this.Controls.Add(this.TxtTECodigo);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.GrdItens);
           this.Name = "FrmTipoEquipamento";
           this.Text = "Cadastro de Tipo de Equipamento";
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEquipamento_FormClosed);
           this.Load += new System.EventHandler(this.FrmEquipamento_Load);
           ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTECodigo;
        private System.Windows.Forms.TextBox TxtTEDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.CheckBox ChkTEEPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EqDescricao;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;

    }
}