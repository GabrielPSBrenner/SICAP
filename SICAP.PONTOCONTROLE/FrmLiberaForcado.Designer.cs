namespace ACESSO.PONTOCONTROLE
{
    partial class FrmLiberaForcado
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
            this.TxtJustificativa = new System.Windows.Forms.TextBox();
            this.KeyBoard = new KeyboardClassLibrary.Keyboardcontrol();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Justificativa da Liberação Forçada";
            // 
            // TxtJustificativa
            // 
            this.TxtJustificativa.Location = new System.Drawing.Point(3, 25);
            this.TxtJustificativa.Multiline = true;
            this.TxtJustificativa.Name = "TxtJustificativa";
            this.TxtJustificativa.Size = new System.Drawing.Size(781, 146);
            this.TxtJustificativa.TabIndex = 1;
            // 
            // KeyBoard
            // 
            this.KeyBoard.KeyboardType = KeyboardClassLibrary.BoW.Standard;
            this.KeyBoard.Location = new System.Drawing.Point(0, 173);
            this.KeyBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KeyBoard.Name = "KeyBoard";
            this.KeyBoard.Size = new System.Drawing.Size(954, 277);
            this.KeyBoard.TabIndex = 7;
            this.KeyBoard.UserKeyPressed += new KeyboardClassLibrary.KeyboardDelegate(this.KeyBoard_UserKeyPressed);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(640, 450);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(146, 53);
            this.BtnConfirmar.TabIndex = 8;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(493, 450);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(146, 53);
            this.BtnFechar.TabIndex = 8;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmLiberaForcado
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnFechar;
            this.ClientSize = new System.Drawing.Size(786, 503);
            this.ControlBox = false;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.KeyBoard);
            this.Controls.Add(this.TxtJustificativa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLiberaForcado";
            this.Text = "Liberação Forçada";
            this.Load += new System.EventHandler(this.FrmLiberaForcado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtJustificativa;
        private KeyboardClassLibrary.Keyboardcontrol KeyBoard;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnFechar;
    }
}