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
   public partial class FrmPontoControle : Form
   {
      private bool Novo = true;

      public FrmPontoControle()
      {
         InitializeComponent();
      }

      private void BtnCancela_Click(object sender, EventArgs e)
      {
         validador1.LimpaControles();
         TxtPoCodigo.Enabled = true;
         CboPoTipo.Enabled = true;
         Novo = true;
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (validador1.isValid())
         {
            CPontoControle.PONTOCONTROLE oPONTOCONTROLE = new CPontoControle.PONTOCONTROLE();
            CPontoControle.CPontoControleClient oProxy = new CPontoControle.CPontoControleClient();
            oPONTOCONTROLE.PoCodigo = int.Parse(TxtPoCodigo.Text);
            oPONTOCONTROLE.PoTipo = char.Parse(CboPoTipo.Text);
            oPONTOCONTROLE.PoNome = TxtPoNome.Text;
            oPONTOCONTROLE.PoDescricao = TxtPoDescricao.Text;
            oPONTOCONTROLE.PoBiometria = ChkPoBiometria.Checked;
            oPONTOCONTROLE.PoCartaoRFID = ChkPoCartaoRFID.Checked;
            oPONTOCONTROLE.PoSenha = ChkPoSenha.Checked;
            oPONTOCONTROLE.PoObservacao = TxtPoObservacao.Text;
            oPONTOCONTROLE.PoControlaSaida = ChkPoControlaSaida.Checked;
            oPONTOCONTROLE.PoDisparaAlarme = ChkPoDisparaAlarme.Checked;

            if (TxtPoQtdMediaPessoas.Text.Trim() != "")
            {
               oPONTOCONTROLE.PoQtdMediaPessoas = int.Parse(TxtPoQtdMediaPessoas.Text);
            }
            else
            {
               oPONTOCONTROLE.PoQtdMediaPessoas = null;
            }


            if (TxtQtdVerificaEquip.Text.Trim() != "")
            {
               oPONTOCONTROLE.PoQtdVerificaEquip = int.Parse(TxtQtdVerificaEquip.Text);
            }
            else
            {
               oPONTOCONTROLE.PoQtdVerificaEquip = null;
            }

            if (TxtPoTentativasIndevidaDisparaAlarme.Text.Trim() != "")
            {
               oPONTOCONTROLE.PoTentativaIndevidaDisparaAlarme = byte.Parse(TxtPoTentativasIndevidaDisparaAlarme.Text);
            }
            else
            {
               oPONTOCONTROLE.PoTentativaIndevidaDisparaAlarme = null;
            }
            oPONTOCONTROLE.PoPermiteLiberacaoForcada = ChkPoPermiteLiberacaoForcada.Checked;
            try
            {
               if (Novo == true)
               {
                  oProxy.Incluir(oPONTOCONTROLE);
               }
               else
               {
                  oProxy.Alterar(oPONTOCONTROLE);
               }
               Novo = true;
               TxtPoCodigo.Enabled = true;
               CboPoTipo.Enabled = true;
               validador1.LimpaControles();
               var retorno = oProxy.ListarTodosPontosControle();
               GrdItens.DataSource = retorno;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Um erro aconteceu ao executar a operação: " + ex.Message + ".", ProductName);
            }
         }
      }

      private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex > -1 && e.ColumnIndex > -1)
         {
            if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
            {

               CPontoControle.CPontoControleClient oProxy = new CPontoControle.CPontoControleClient();
               var oPontoControle = oProxy.SelecionaPKPontoControle((int)GrdItens.Rows[e.RowIndex].Cells[0].Value, GrdItens.Rows[e.RowIndex].Cells[1].Value.ToString());
               if (oPontoControle != null)
               {
                  TxtPoCodigo.Text = oPontoControle.PoCodigo.ToString();
                  CboPoTipo.Text = oPontoControle.PoTipo.ToString();
                  TxtPoNome.Text = oPontoControle.PoNome;
                  TxtPoDescricao.Text = oPontoControle.PoDescricao;
                  ChkPoBiometria.Checked = oPontoControle.PoBiometria;
                  ChkPoCartaoRFID.Checked = oPontoControle.PoCartaoRFID;
                  ChkPoSenha.Checked = oPontoControle.PoSenha;
                  TxtPoObservacao.Text = oPontoControle.PoObservacao;
                  ChkPoControlaSaida.Checked = oPontoControle.PoControlaSaida;
                  ChkPoDisparaAlarme.Checked = oPontoControle.PoDisparaAlarme;
                  TxtPoTentativasIndevidaDisparaAlarme.Text = oPontoControle.PoTentativaIndevidaDisparaAlarme.ToString();
                  TxtPoQtdMediaPessoas.Text = oPontoControle.PoQtdMediaPessoas.ToString();
                  TxtQtdVerificaEquip.Text = oPontoControle.PoQtdVerificaEquip.ToString();
                  TxtPoCodigo.Enabled = false;
                  CboPoTipo.Enabled = false;
                  Novo = false;
               }
               else
               {
                  Novo = true;
                  TxtPoCodigo.Enabled = true;
                  CboPoTipo.Enabled = true;
                  validador1.LimpaControles();
               }
            }
            else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
            {
               if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
               {
                  CPontoControle.CPontoControleClient oProxy = new CPontoControle.CPontoControleClient();
                  CPontoControle.PONTOCONTROLE oPontoControle = new CPontoControle.PONTOCONTROLE();
                  oPontoControle.PoCodigo = (int)GrdItens.Rows[e.RowIndex].Cells[0].Value;
                  oPontoControle.PoTipo = (char)GrdItens.Rows[e.RowIndex].Cells[1].Value;
                  oProxy.Excluir(oPontoControle);
                  var retorno = oProxy.ListarTodosPontosControle();
                  GrdItens.DataSource = retorno;
               }
            }
         }
      }

      private void FrmPontoControle_FormClosed(object sender, FormClosedEventArgs e)
      {
         ((FrmPrincipal)this.MdiParent).MnuCadPonto.Enabled = true;
      }

      private void FrmPontoControle_Load(object sender, EventArgs e)
      {
         GrdItens.AutoGenerateColumns = false;
         CPontoControle.CPontoControleClient oProxy = new CPontoControle.CPontoControleClient();
         var retorno = oProxy.ListarTodosPontosControle();
         GrdItens.DataSource = retorno;
      }
   }
}
