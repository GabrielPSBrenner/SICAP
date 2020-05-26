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
    public partial class FrmEqPontoControle : Form
    {
        public FrmEqPontoControle()
        {
            InitializeComponent();
        }

        private void TxtEPCodigoPontoControle_TextChanged(object sender, EventArgs e)
        {
            if (TxtEPCodigoPontoControle.Text.Trim() != "")
            {
                CboPontoControle.SelectedValue = int.Parse(TxtEPCodigoPontoControle.Text);
            }
            else
            {
                CboPontoControle.SelectedIndex = -1;
            }
        }

        

        private void CboPontoControle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPontoControle.SelectedIndex > -1)
            {                
                TxtEPCodigoPontoControle.Text = CboPontoControle.SelectedValue.ToString();
                btnSalvar.Enabled = true;

                int PCAP = (int)CboPontoControle.SelectedValue;
                CEquipamentoPonto.CEquipamentoPontoClient oProxy = new CEquipamentoPonto.CEquipamentoPontoClient();
                oProxy.Open();
               
                //Carrega a combobox
                var Lista = oProxy.ListaTipoEquipamento(PCAP);
                CboTipoEquipamento.ValueMember = "TECodigo";
                CboTipoEquipamento.DisplayMember = "TEDescricao";
                CboTipoEquipamento.DataSource = Lista;

                //Carrega o DataGrid com os dados da combo selecionada.
                GrdItens.AutoGenerateColumns = false;
                var ListaGrid = oProxy.ListaEquipamentoPonto(PCAP);
                GrdItens.DataSource = ListaGrid;

                oProxy.Close();
               
            }
            else
            {
                TxtEPCodigoPontoControle.Text = "";
                TxtEPCodigoTipoEquipamento.Text = "";
                CboTipoEquipamento.DataSource = null;
                btnSalvar.Enabled = false;
                GrdItens.DataSource = null;
            }

        }

        private void TxtEPCodigoTipoEquipamento_TextChanged(object sender, EventArgs e)
        {
            if (TxtEPCodigoTipoEquipamento.Text.Trim() != "")
            {
                CboTipoEquipamento.SelectedValue = int.Parse(TxtEPCodigoTipoEquipamento.Text);
            }
            else
            {
                CboTipoEquipamento.SelectedIndex = -1;
            }
        }

        private void CboTipoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipoEquipamento.SelectedIndex > -1)
            {
                TxtEPCodigoTipoEquipamento.Text = CboTipoEquipamento.SelectedValue.ToString();
            }
            else
            {
                TxtEPCodigoTipoEquipamento.Text = "";
            }
        }

        private void FrmEqPontoControle_Load(object sender, EventArgs e)
        {
            CEquipamentoPonto.CEquipamentoPontoClient oProxy = new CEquipamentoPonto.CEquipamentoPontoClient();

            oProxy.Open();
            var oLista = oProxy.ListaPontoControleEPI();
            CboPontoControle.ValueMember="PoCodigo";
            CboPontoControle.DisplayMember = "PoNome";
            CboPontoControle.DataSource = oLista;
            oProxy.Close();
            GrdItens.AutoGenerateColumns = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CEquipamentoPonto.EQUIPAMENTOPONTO oEP = new CEquipamentoPonto.EQUIPAMENTOPONTO();
                oEP.EPCodigoPontoControle = (int)CboPontoControle.SelectedValue;
                oEP.EPCodigoTipoEquipamento = (int)CboTipoEquipamento.SelectedValue;
                oEP.EPCodigoTipoPonto = char.Parse("E");
                oEP.EPNumeroPortaRele = 0;
                oEP.EPObrigatorio = true;
               
                CEquipamentoPonto.CEquipamentoPontoClient oProxy = new CEquipamentoPonto.CEquipamentoPontoClient();
                oProxy.Open();

                oProxy.Incluir(oEP);
                //Carrega o DataGrid com os dados da combo selecionada.
                var ListaGrid = oProxy.ListaEquipamentoPonto((int)CboPontoControle.SelectedValue);
                GrdItens.AutoGenerateColumns = false;
                GrdItens.DataSource = ListaGrid;
                CboPontoControle_SelectedIndexChanged(sender, e);
                oProxy.Close();
            }            
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
            {
                if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    CEquipamentoPonto.vw_EquipamentoPonto oEP = (CEquipamentoPonto.vw_EquipamentoPonto)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    CEquipamentoPonto.CEquipamentoPontoClient oProxy = new CEquipamentoPonto.CEquipamentoPontoClient();
                    oProxy.Excluir(oEP.EPCodigoPontoControle, oEP.EPCodigoTipoEquipamento, oEP.EPCodigoTipoPonto.ToString());
                    
                    //Carrega o DataGrid com os dados da combo selecionada.
                    GrdItens.AutoGenerateColumns = false;
                    var ListaGrid = oProxy.ListaEquipamentoPonto((int)CboPontoControle.SelectedValue);
                    GrdItens.DataSource = ListaGrid;

                    CboPontoControle_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void FrmEqPontoControle_FormClosed(object sender, FormClosedEventArgs e)
        {
           ((FrmPrincipal)this.MdiParent).MnuEqObrigatorioPC.Enabled = true;
        }
    }
}
