﻿namespace ACESSO.ADMINISTRATIVO
{
    partial class FrmFornecedor
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
            this.TxtFOCNPJ = new System.Windows.Forms.TextBox();
            this.TxtFoRazaoSocial = new System.Windows.Forms.TextBox();
            this.TxtFONomeFantasia = new System.Windows.Forms.TextBox();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.FOCNPJCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FONomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.validador1 = new ValidadorWindows.Validador(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFOCNPJ
            // 
            this.TxtFOCNPJ.Location = new System.Drawing.Point(93, 3);
            this.TxtFOCNPJ.MaxLength = 14;
            this.TxtFOCNPJ.Name = "TxtFOCNPJ";
            this.TxtFOCNPJ.Size = new System.Drawing.Size(126, 20);
            this.TxtFOCNPJ.TabIndex = 14;
            // 
            // TxtFoRazaoSocial
            // 
            this.TxtFoRazaoSocial.Location = new System.Drawing.Point(93, 29);
            this.TxtFoRazaoSocial.MaxLength = 50;
            this.TxtFoRazaoSocial.Name = "TxtFoRazaoSocial";
            this.TxtFoRazaoSocial.Size = new System.Drawing.Size(486, 20);
            this.TxtFoRazaoSocial.TabIndex = 15;
            // 
            // TxtFONomeFantasia
            // 
            this.TxtFONomeFantasia.Location = new System.Drawing.Point(93, 55);
            this.TxtFONomeFantasia.MaxLength = 50;
            this.TxtFONomeFantasia.Name = "TxtFONomeFantasia";
            this.TxtFONomeFantasia.Size = new System.Drawing.Size(486, 20);
            this.TxtFONomeFantasia.TabIndex = 19;
            // 
            // BtnCancela
            // 
            this.BtnCancela.Location = new System.Drawing.Point(188, 79);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(90, 30);
            this.BtnCancela.TabIndex = 16;
            this.BtnCancela.Text = "Cancelar";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(93, 79);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Razão Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPF/CNPJ";
            // 
            // GrdItens
            // 
            this.GrdItens.AllowUserToAddRows = false;
            this.GrdItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FOCNPJCodigo,
            this.FORazaoSocial,
            this.FONomeFantasia,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdItens.Location = new System.Drawing.Point(2, 115);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.RowHeadersWidth = 4;
            this.GrdItens.Size = new System.Drawing.Size(927, 246);
            this.GrdItens.TabIndex = 11;
            this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
            // 
            // FOCNPJCodigo
            // 
            this.FOCNPJCodigo.DataPropertyName = "FOCNPJ";
            this.FOCNPJCodigo.HeaderText = "CPF/CNPJ";
            this.FOCNPJCodigo.Name = "FOCNPJCodigo";
            this.FOCNPJCodigo.ReadOnly = true;
            this.FOCNPJCodigo.Width = 150;
            // 
            // FORazaoSocial
            // 
            this.FORazaoSocial.DataPropertyName = "FORazaoSocial";
            this.FORazaoSocial.HeaderText = "Razão Social";
            this.FORazaoSocial.Name = "FORazaoSocial";
            this.FORazaoSocial.ReadOnly = true;
            this.FORazaoSocial.Width = 350;
            // 
            // FONomeFantasia
            // 
            this.FONomeFantasia.DataPropertyName = "FONomeFantasia";
            this.FONomeFantasia.HeaderText = "FONomeFantasia";
            this.FONomeFantasia.Name = "FONomeFantasia";
            this.FONomeFantasia.ReadOnly = true;
            this.FONomeFantasia.Width = 250;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome Fantasia";
            // 
            // validador1
            // 
            myControl1.CasasDecimais = ((byte)(0));
            myControl1.Controle = this.TxtFOCNPJ;
            myControl1.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.Ambos;
            myControl1.MarcaConteudo = true;
            myControl1.NomeCampo = "CPF/CNPJ";
            myControl1.Requerido = true;
            myControl1.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.Numerico;
            myControl2.CasasDecimais = ((byte)(0));
            myControl2.Controle = this.TxtFoRazaoSocial;
            myControl2.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl2.MarcaConteudo = false;
            myControl2.NomeCampo = "Razão Social";
            myControl2.Requerido = true;
            myControl2.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            myControl3.CasasDecimais = ((byte)(0));
            myControl3.Controle = this.TxtFONomeFantasia;
            myControl3.CPFCNPJ = ValidadorWindows.MyControl.enumCPFCNPJ.NaoValida;
            myControl3.MarcaConteudo = false;
            myControl3.NomeCampo = "Nome Fantasia";
            myControl3.Requerido = true;
            myControl3.TipoCampo = ValidadorWindows.MyControl.enumTipoCampo.SemTipo;
            this.validador1.Controles.Add(myControl1);
            this.validador1.Controles.Add(myControl2);
            this.validador1.Controles.Add(myControl3);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 361);
            this.Controls.Add(this.TxtFONomeFantasia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancela);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtFoRazaoSocial);
            this.Controls.Add(this.TxtFOCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdItens);
            this.Name = "FrmFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox TxtFoRazaoSocial;
        private System.Windows.Forms.TextBox TxtFOCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.TextBox TxtFONomeFantasia;
        private System.Windows.Forms.Label label3;
        private ValidadorWindows.Validador validador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOCNPJCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FONomeFantasia;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}