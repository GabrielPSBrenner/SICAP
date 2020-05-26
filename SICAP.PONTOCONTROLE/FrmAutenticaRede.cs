using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACESSO.PONTOCONTROLE
{
    public partial class FrmAutenticaRede : Form
    {
        bool bAutenticado=false;
        string sUsuario = "";        
       
        public bool Autenticado
        {
            get { return bAutenticado; }
        }
        public CPonto.USUARIO Usuario
        {
            get 
            {
                CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
                var obj = oProxy.SelecionaUsuarioRede(sUsuario);
                oProxy.Close();
                return obj;           
            }
        }

        public FrmAutenticaRede(string Usuario)
        {
            InitializeComponent();
            
            CAutentica.CAutenticaClient oProxy = new CAutentica.CAutenticaClient();
            CPonto.CPontoClient oCPonto = new CPonto.CPontoClient();
            CPonto.USUARIO oUsuario = oCPonto.SelecionaUsuarioRede(Usuario);
            string UsuarioRede = oUsuario.USUSUARIOREDE;
            sUsuario = UsuarioRede;
            TxtUsuario.Text = UsuarioRede;
            oProxy.Close();
        }

        public FrmAutenticaRede()
        {
            InitializeComponent();
            TxtUsuario.ReadOnly = false;
            TxtUsuario.Enabled = true;
        }      

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Informe o usuário antes de validá-lo.");
                TxtUsuario.Focus();
            }
            else if (TxtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Informe o usuário antes de validá-la.");
                TxtSenha.Focus();
            }
            else
            {
                CAutentica.CAutenticaClient oProxy = new CAutentica.CAutenticaClient();
                bool Valida = oProxy.IsAuthenticated("INB", TxtUsuario.Text, TxtSenha.Text);
                oProxy.Close();
                if (!Valida)
                {
                    MessageBox.Show("Usuário ou senha inválidos.", ProductName);
                    TxtSenha.Focus();
                }
                else
                {
                    sUsuario = TxtUsuario.Text;                    
                    bAutenticado = true;
                    this.Close();
                }
            }
        }

        private void FrmAutenticaRede_Load(object sender, EventArgs e)
        {

        }

        private void KeyBoard_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
        {
            TxtSenha.Focus();
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnOk_Click(sender, e);
            }
        }

        private void KeyBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
