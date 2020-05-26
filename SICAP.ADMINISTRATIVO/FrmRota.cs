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
   public partial class FrmRota : Form
   {
      private bool Novo = false;
      public FrmRota()
      {
         InitializeComponent();
      }

      private void FrmRota_Load(object sender, EventArgs e)
      {
         CRota.CRotaClient oRota = new CRota.CRotaClient();
         GrdItens.AutoGenerateColumns = false;
      }

      private void BtnNovo_Click(object sender, EventArgs e)
      {
         validador2.LimpaControles();
         validador1.LimpaControles();
         BtnNovo.Enabled = false;
         btnSalvar.Enabled = true;
         BtnExcluir.Enabled = false;
         BtnCancela.Enabled = true;
         BtnAlterar.Enabled = false;
         BtnSalvarPontoRota.Enabled = false;
         GrdItens.DataSource = null;
         Novo = true;
         validador1.HabilitaControles(true);
         TxtROCodigo.Enabled = false;
         TxtRONome.Focus();
      }

      private void BtnCancela_Click(object sender, EventArgs e)
      {
         validador1.LimpaControles();
         validador2.LimpaControles();
         BtnNovo.Enabled = true;
         btnSalvar.Enabled = false;
         BtnExcluir.Enabled = false;
         BtnCancela.Enabled = false;
         BtnAlterar.Enabled = false;
         BtnSalvarPontoRota.Enabled = false;
         GrdItens.DataSource = null;
         Novo = true;
         if (((Control)sender).Name != "TxtROCodigo")
         {
            TxtROCodigo.Enabled = true;
            TxtROCodigo.Focus();
         }
         validador1.HabilitaControles(true);
      }

      private void BtnAlterar_Click(object sender, EventArgs e)
      {
         BtnNovo.Enabled = true;
         btnSalvar.Enabled = true;
         BtnExcluir.Enabled = false;
         BtnCancela.Enabled = true;
         BtnAlterar.Enabled = false;
         BtnSalvarPontoRota.Enabled = false;
         validador1.HabilitaControles(true);
         Novo = false;
         TxtROCodigo.Enabled = false;
         TxtRONome.Focus();
      }

      private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
               if (ChkROBloqueada.Checked)
               {
                  if (TxtROMotivoBloqueio.Text.Trim() == "")
                  {
                     MessageBox.Show("Preencha o motivo do bloqueio.", ProductName, MessageBoxButtons.OK);
                     TxtROMotivoBloqueio.Focus();
                     return;
                  }
               }
               else
               {
                  TxtROMotivoBloqueio.Text = "";
               }
                CRota.CRotaClient oProxy = new CRota.CRotaClient();
                CRota.ROTA oRota = new CRota.ROTA();
                oRota.RONome = TxtRONome.Text;
                oRota.RODescricao = TxtRODescricao.Text;
                oRota.ROBloqueada = ChkROBloqueada.Checked;
                oRota.ROMotivoBloqueio = TxtROMotivoBloqueio.Text;
               //oRota.ro
                if (Novo)
                {
                    TxtROCodigo.Text = oProxy.Incluir(oRota).ToString();
                }
                else
                {
                    oRota.ROCodigo = int.Parse(TxtROCodigo.Text);
                    oProxy.Alterar(oRota);
                }
                validador1.HabilitaControles(false);
                BtnNovo.Enabled = true;
                BtnCancela.Enabled = true;
                btnSalvar.Enabled = false;
                BtnExcluir.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnSalvarPontoRota.Enabled = true;                
                GrdItens.DataSource = oProxy.PontosRota(int.Parse(TxtROCodigo.Text));
            }
        }

      private void BtnExcluir_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Se confirmar, será impossível recuperar o registro. Deseja excluir a rota? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
         {
            CRota.CRotaClient oProxy = new CRota.CRotaClient();
            CRota.ROTA oRota = new CRota.ROTA();
            oRota.ROCodigo = int.Parse(TxtROCodigo.Text);
            oProxy.Excluir(oRota);
            BtnCancela_Click(sender, e);
         }
      }

      private void CboTipoPonto_SelectedIndexChanged(object sender, EventArgs e)
      {
         CboPontoControle.DisplayMember = "PoNome";
         CboPontoControle.ValueMember = "PoCodigo";
         CRota.CRotaClient oProxy = new CRota.CRotaClient();
         if (CboTipoPonto.SelectedIndex == 0)
         {
            CboPontoControle.DataSource = oProxy.ListarPontosControleTipo(char.Parse("E"));
         }
         else if (CboTipoPonto.SelectedIndex == 1)
         {
            CboPontoControle.DataSource = oProxy.ListarPontosControleTipo(char.Parse("S"));
         }
         else
         {
            CboPontoControle.DataSource = null;
         }
      }

      private void TxtROCodigo_Leave(object sender, EventArgs e)
      {
         if (TxtROCodigo.Text.Trim() != "")
         {
            CRota.CRotaClient oProxy = new CRota.CRotaClient();
            CRota.ROTA oRota;
            try
            {
               oRota = oProxy.SelecionaPKROTA(int.Parse(TxtROCodigo.Text));
            }
            catch
            {
               oRota = null;
            }
            if (oRota != null)
            {
               //alteração
               BtnNovo.Enabled = true;
               btnSalvar.Enabled = false;
               BtnAlterar.Enabled = true;
               BtnExcluir.Enabled = true;
               BtnCancela.Enabled = true;
               BtnSalvarPontoRota.Enabled = true;
               validador1.HabilitaControles(false);
               Novo = false;
               TxtRONome.Text = oRota.RONome;
               TxtRODescricao.Text = oRota.RODescricao;
               ChkROBloqueada.Checked = (bool)oRota.ROBloqueada;
               TxtROMotivoBloqueio.Text = oRota.ROMotivoBloqueio;
               GrdItens.DataSource = oProxy.PontosRota(int.Parse(TxtROCodigo.Text));
            }
            else
            {
               //inclusão
               MessageBox.Show("Rota não encontrada! Selecione uma rota ou clique no botão novo para incluir.", ProductName);
               Novo = true;
               validador1.HabilitaControles(true);
               GrdItens.DataSource = null;
               BtnNovo.Enabled = true;
               btnSalvar.Enabled = false;
               BtnAlterar.Enabled = false;
               BtnExcluir.Enabled = false;
               BtnCancela.Enabled = true;
               BtnSalvarPontoRota.Enabled = false;
               TxtROCodigo.Enabled = false;
               GrdItens.DataSource = null;
            }

         }
         else
         {
            BtnCancela_Click(sender, e);
         }
      }

      private void FrmRota_FormClosed(object sender, FormClosedEventArgs e)
      {
         ((FrmPrincipal)this.MdiParent).MnuCadRotas.Enabled = true;
      }

      private void BtnSalvarPontoRota_Click(object sender, EventArgs e)
      {
         if (validador2.isValid())
         {
            CRota.CRotaClient oProxy = new CRota.CRotaClient();
            CRota.PONTOROTA oPontoRota = new CRota.PONTOROTA();
            oPontoRota.PRCodigoRota = int.Parse(TxtROCodigo.Text);
            oPontoRota.PROrdem = GrdItens.Rows.Count + 1;
            oPontoRota.PRCodigoPontoControle = (int)CboPontoControle.SelectedValue;
            if (CboTipoPonto.SelectedIndex == 0)
            {
               oPontoRota.PRTipoPontoControle = char.Parse("E");
            }
            else
            {
               oPontoRota.PRTipoPontoControle = char.Parse("S");
            }
            oPontoRota.PRTempoMaxPerm = int.Parse(TxtPRTempoMaxPerm.Text);
            try
            {
               oProxy.IncluirPontoRota(oPontoRota);
               GrdItens.DataSource = oProxy.PontosRota(int.Parse(TxtROCodigo.Text));
            }
            catch (Exception ex)
            {
               MessageBox.Show("Um erro aconteceu ao efetuar a operação: " + ex.Message + ".", ProductName);
            }
            validador2.LimpaControles();
         }
      }

      private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex > -1 && e.ColumnIndex > -1)
         {
            CRota.CRotaClient oProxy = new CRota.CRotaClient();
            CRota.PONTOROTA oRota = new CRota.PONTOROTA();
            oRota.PRCodigoRota = ((CRota.vw_PontoRota)GrdItens.Rows[e.RowIndex].DataBoundItem).PRCodigoRota;
            oRota.PRTipoPontoControle = ((CRota.vw_PontoRota)GrdItens.Rows[e.RowIndex].DataBoundItem).PRTipoPontoControle;
            oRota.PRCodigoPontoControle = ((CRota.vw_PontoRota)GrdItens.Rows[e.RowIndex].DataBoundItem).PRCodigoPontoControle;
            if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluirPC")
            {
               if (MessageBox.Show("Se confirmar será impossível recuperar o registro. Deseja excluir o ponto de controle da rota?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
               {
                  oProxy.ExcluirPontoRota(oRota);
               }

            }
            else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnOrdemMenos1")
            {
               oProxy.OrdemMenosUm(oRota.PRCodigoRota, oRota.PRCodigoPontoControle, oRota.PRTipoPontoControle);
            }
            else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnOrdemMais1")
            {
               oProxy.OrdemMaisUm(oRota.PRCodigoRota, oRota.PRCodigoPontoControle, oRota.PRTipoPontoControle);
            }
            GrdItens.DataSource = oProxy.PontosRota(int.Parse(TxtROCodigo.Text));
         }
      }


   }
}
