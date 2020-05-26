namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmFabricante
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
            this.TxtFaCodigo = new System.Windows.Forms.TextBox();
            this.TxtFaNome = new System.Windows.Forms.TextBox();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.validador1 = new ValidadorWindows.Validador(this.components);
            this.FaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFaCodigo
            // 
            this.TxtFaCodigo.Location = new System.Drawing.Point(77, 6);
            this.TxtFaCodigo.MaxLength = 3;
            this.TxtFaCodigo.Name = "TxtFaCodigo";
            this.TxtFaCodigo.Size = new System.Drawing.Size(48, 20);
            this.TxtFaCodigo.TabIndex = 7;
            // 
            // TxtFaNome
            // 
            this.TxtFaNome.Location = new System.Drawing.Point(77, 32);
            this.TxtFaNome.MaxLength = 50;
            this.TxtFaNome.Name = "TxtFaNome";
            this.TxtFaNome.Size = new System.Drawing.Size(486, 20);
            this.TxtFaNome.TabIndex = 8;
            // 
            // BtnCancela
            // 
            this.BtnCancela.Location = new System.Drawing.Point(173, 58);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(90, 30);
            this.BtnCancela.TabIndex = 9;
            this.BtnCancela.Text = "Cancelar";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(77, 58);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // GrdItens
            // 
            this.GrdItens.AllowUserToAddRows = false;
            this.GrdItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaCodigo,
            this.FaNome,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdItens.Location = new System.Drawing.Point(3, 91);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.RowHeadersWidth = 4;
            this.GrdItens.Size = new System.Drawing.Size(586, 171);
            this.GrdItens.TabIndex = 4;
            this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
            // 
            // validador1
            // 
            myControl1.CasasDecimais = ((byte)(0));
            myControl1.Controle = this.TxtFaCodigo;
            myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl1.MarcaConteudo = false;
            myControl1.NomeCampo = "Código";
            myControl1.Requerido = true;
            myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
            myControl2.CasasDecimais = ((byte)(0));
            myControl2.Controle = this.TxtFaNome;
            myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl2.MarcaConteudo = false;
            myControl2.NomeCampo = "Descrição";
            myControl2.Requerido = true;
            myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            this.validador1.Controles.Add(myControl1);
            this.validador1.Controles.Add(myControl2);
            // 
            // FaCodigo
            // 
            this.FaCodigo.DataPropertyName = "FaCodigo";
            this.FaCodigo.HeaderText = "Código";
            this.FaCodigo.Name = "FaCodigo";
            this.FaCodigo.ReadOnly = true;
            // 
            // FaNome
            // 
            this.FaNome.DataPropertyName = "FaNome";
            this.FaNome.HeaderText = "Descrição";
            this.FaNome.Name = "FaNome";
            this.FaNome.ReadOnly = true;
            this.FaNome.Width = 350;
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
            // FrmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 262);
            this.Controls.Add(this.BtnCancela);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtFaNome);
            this.Controls.Add(this.TxtFaCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdItens);
            this.Name = "FrmFabricante";
            this.Text = "Cadastro de Fabricantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFabricante_FormClosed);
            this.Load += new System.EventHandler(this.FrmFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox TxtFaNome;
        private System.Windows.Forms.TextBox TxtFaCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdItens;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaNome;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}