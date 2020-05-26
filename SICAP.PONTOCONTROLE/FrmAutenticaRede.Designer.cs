namespace ACESSO.PONTOCONTROLE
{
    partial class FrmAutenticaRede
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
           this.TxtUsuario = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.TxtSenha = new System.Windows.Forms.TextBox();
           this.BtnOk = new System.Windows.Forms.Button();
           this.BtnCancela = new System.Windows.Forms.Button();
           this.KeyBoard = new KeyboardClassLibrary.Keyboardcontrol();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Location = new System.Drawing.Point(20, 8);
           this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(129, 20);
           this.label1.TabIndex = 0;
           this.label1.Text = "Usuário da Rede";
           // 
           // TxtUsuario
           // 
           this.TxtUsuario.BackColor = System.Drawing.Color.White;
           this.TxtUsuario.Enabled = false;
           this.TxtUsuario.Location = new System.Drawing.Point(24, 33);
           this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.TxtUsuario.Name = "TxtUsuario";
           this.TxtUsuario.ReadOnly = true;
           this.TxtUsuario.Size = new System.Drawing.Size(148, 26);
           this.TxtUsuario.TabIndex = 1;
           this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(190, 9);
           this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(56, 20);
           this.label2.TabIndex = 2;
           this.label2.Text = "Senha";
           // 
           // TxtSenha
           // 
           this.TxtSenha.Location = new System.Drawing.Point(187, 33);
           this.TxtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.TxtSenha.Name = "TxtSenha";
           this.TxtSenha.PasswordChar = '*';
           this.TxtSenha.Size = new System.Drawing.Size(222, 26);
           this.TxtSenha.TabIndex = 3;
           this.TxtSenha.UseSystemPasswordChar = true;
           this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
           // 
           // BtnOk
           // 
           this.BtnOk.Location = new System.Drawing.Point(613, 2);
           this.BtnOk.Name = "BtnOk";
           this.BtnOk.Size = new System.Drawing.Size(191, 65);
           this.BtnOk.TabIndex = 5;
           this.BtnOk.Text = "Ok";
           this.BtnOk.UseVisualStyleBackColor = true;
           this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
           // 
           // BtnCancela
           // 
           this.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           this.BtnCancela.Location = new System.Drawing.Point(412, 2);
           this.BtnCancela.Name = "BtnCancela";
           this.BtnCancela.Size = new System.Drawing.Size(200, 65);
           this.BtnCancela.TabIndex = 4;
           this.BtnCancela.Text = "Cancelar";
           this.BtnCancela.UseVisualStyleBackColor = true;
           this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
           // 
           // KeyBoard
           // 
           this.KeyBoard.KeyboardType = KeyboardClassLibrary.BoW.Standard;
           this.KeyBoard.Location = new System.Drawing.Point(0, 69);
           this.KeyBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.KeyBoard.Name = "KeyBoard";
           this.KeyBoard.Size = new System.Drawing.Size(980, 283);
           this.KeyBoard.TabIndex = 6;
           this.KeyBoard.UserKeyPressed += new KeyboardClassLibrary.KeyboardDelegate(this.KeyBoard_UserKeyPressed);
           this.KeyBoard.Load += new System.EventHandler(this.KeyBoard_Load);
           // 
           // FrmAutenticaRede
           // 
           this.AcceptButton = this.BtnOk;
           this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.CancelButton = this.BtnCancela;
           this.ClientSize = new System.Drawing.Size(807, 353);
           this.ControlBox = false;
           this.Controls.Add(this.KeyBoard);
           this.Controls.Add(this.BtnCancela);
           this.Controls.Add(this.BtnOk);
           this.Controls.Add(this.TxtSenha);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.TxtUsuario);
           this.Controls.Add(this.label1);
           this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
           this.Name = "FrmAutenticaRede";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "Atenticação com senha no domínio de rede";
           this.Load += new System.EventHandler(this.FrmAutenticaRede_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancela;
        private KeyboardClassLibrary.Keyboardcontrol KeyBoard;
    }
}