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
    public partial class FrmLiberaForcado : Form
    {
        private int CodigoUsuario, PontoControle;
        private char TipoPontoControle;
        private bool bolLibera = false;

        public bool Libera
        {
            get { return bolLibera; }
        }


        public FrmLiberaForcado(int pCodigoUsuario, int pCodigoPonto, char pTipoPontoControle)
        {
            InitializeComponent();
            CodigoUsuario = pCodigoUsuario;
            PontoControle = pCodigoPonto;
            TipoPontoControle = pTipoPontoControle;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLiberaForcado_Load(object sender, EventArgs e)
        {

        }

        private void KeyBoard_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
        {
            TxtJustificativa.Focus();
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtJustificativa.Text.Length < 10)
            {
                MessageBox.Show("Preencha a justificativa com no mínimo dez (10) caracteres.");
                TxtJustificativa.Focus();
            }
            else
            {                
                CPonto.ACESSOPONTOCONTROLE oAcesso = new CPonto.ACESSOPONTOCONTROLE();
                oAcesso.APAcessoForcado = true;
                oAcesso.APCodigoPontoControle = PontoControle;
                oAcesso.APCodigoUsuarioLiberaForcado = CodigoUsuario;
                oAcesso.APDataAcesso = DateTime.Now;
                oAcesso.APMotivoAcessoForcado = TxtJustificativa.Text;
                oAcesso.APTipoPontoControle = TipoPontoControle;
                CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
                oProxy.IncluirAcesso(oAcesso);
                oProxy.Close();
                bolLibera = true;
                this.Close();
            }
        }
    }
}
