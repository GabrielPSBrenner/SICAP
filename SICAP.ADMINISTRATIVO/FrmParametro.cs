using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACESSO.ADMINISTRATIVO
{
    public partial class FrmParametro : Form
    {
        public FrmParametro()
        {
            InitializeComponent();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmParametro_Load(object sender, EventArgs e)
        {
            CParametro.CParametroClient oProxy = new CParametro.CParametroClient();
            var oPar = oProxy.SelecionarParametro();
            TxtPATempoExpiraSaida.Text = oPar.PATempoExpiraSaida.ToString();
            TxtPAServidorCorreio.Text = oPar.PAServidorCorreio;
            TxtPAServidorDominio.Text = oPar.PAServidorDominio;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CParametro.CParametroClient oProxy = new CParametro.CParametroClient();
            CParametro.PARAMETRO oPar = new CParametro.PARAMETRO();
            oPar.PACodigo = 1;
            oPar.PATempoExpiraSaida = double.Parse(TxtPATempoExpiraSaida.Text);
            oPar.PAServidorCorreio = TxtPAServidorCorreio.Text;
            oPar.PAServidorDominio = TxtPAServidorDominio.Text;
            oProxy.Alterar(oPar);
            MessageBox.Show("Parametros do Sistema gravados com sucesso.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmParametro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuParametro.Enabled = true;
        }
    }
}
