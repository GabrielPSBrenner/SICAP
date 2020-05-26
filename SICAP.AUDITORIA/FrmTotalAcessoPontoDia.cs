using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACESSO.AUDITORIA
{
    public partial class FrmTotalAcessoPontoDia : Form
    {
        public FrmTotalAcessoPontoDia()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCarregarDados_Click(object sender, EventArgs e)
        {
            CTotalAcessoPontoDia.CTotalAcessoPontoDiaClient oProxy = new CTotalAcessoPontoDia.CTotalAcessoPontoDiaClient();            
            if (MskDataInicio.Text.Trim() != "/  /" || MskDataFim.Text.Trim() != "/  /")
            {
                DateTime DataInicio, DataFim;
                if (DateTime.TryParse(MskDataInicio.Text,out DataInicio) == false)
                {
                    DataInicio = DateTime.Parse("01/01/2000");
                }
                if (DateTime.TryParse(MskDataFim.Text, out DataFim) == false)
                {
                    DataFim = DateTime.Parse("31/12/2100");
                }
                GrdItens.DataSource = oProxy.TotalAcessoPontoDiaPeriodo(DataInicio, DataFim);
            }
            else
            {
                GrdItens.DataSource = oProxy.TotalAcessoPontoDia();
            }
            oProxy.Close();
        }

        private void FrmTotalAcessoPontoDia_Load(object sender, EventArgs e)
        {

        }

        private void FrmTotalAcessoPontoDia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuTotalAcessosDia.Enabled = true;
        }
    }
}
