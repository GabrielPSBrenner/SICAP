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
    public partial class FrmConfigura : Form
    {
        public FrmConfigura()
        {
            InitializeComponent();
        }

        private void FrmConfigura_Load(object sender, EventArgs e)
        {
            CConfigura.CConfiguraClient oProxy = new CConfigura.CConfiguraClient();
            CConfigura.PONTOCONTROLE[] oLista = oProxy.ListarTodosPontosControle();
            CboPontoControle.ValueMember = "PoCodigo";
            CboPontoControle.DisplayMember = "PoNome";
            CboPontoControle.DataSource = oLista;

            int CodigoPonto = ACESSO.PONTOCONTROLE.Classes.Registro.CodigoPonto();
            if (CodigoPonto > 0)
            {
                CboPontoControle.SelectedValue = CodigoPonto;
            }
            else
            {
                CboPontoControle.SelectedIndex = -1;
            }
            try
            {
                int Sirene = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSirene();
                CboSirene.SelectedIndex = Sirene - 1;
                int Tranca = ACESSO.PONTOCONTROLE.Classes.Registro.PortaTranca();
                CboTranca.SelectedIndex = Tranca - 1;
            }
            catch (Exception ex) { }
        }

        private void CboPontoControle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPontoControle.SelectedIndex > -1)
            {
                Object obj = CboPontoControle.SelectedItem;
                INB.CARREGACLASSE.ClsCarrega.CarregaForm(this, ref obj, 3);
            }
            else
            {
                LblPoDescricao.Text = "";
                LblPoObservacao.Text = "";
                ChkPoBiometria.Checked = false;
                ChkPoCartaoRFID.Checked = false;
                ChkPoSenha.Checked = false;
                ChkPoControlaSaida.Checked = false;
                ChkPoDisparaAlarme.Checked = false;
                ChkPoPermiteLiberacaoForcada.Checked = false;
                LblPoTentativaIndevidaDisparaAlarme.Text = "";
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CboPontoControle.SelectedIndex == -1)
            {
                MessageBox.Show("É necessário escolher um ponto de controle antes de confirmar.", ProductName);
                CboPontoControle.Focus();
            }
            else if (CboSirene.SelectedIndex == CboTranca.SelectedIndex)
            {
                MessageBox.Show("Não é permitido tanto a tranca, quanto a sirene no mesmo índice.");
                CboSirene.Focus();
            }
            else
            {
                CConfigura.PONTOCONTROLE oPonto = (CConfigura.PONTOCONTROLE)CboPontoControle.SelectedItem;
                ACESSO.PONTOCONTROLE.Classes.Registro.GravaChavePonto(oPonto.PoCodigo, oPonto.PoTipo.ToString(), CboTranca.SelectedIndex + 1, CboSirene.SelectedIndex + 1, TxtPortaSerial.Text);
                this.Close();
            }
        }
    }
}
