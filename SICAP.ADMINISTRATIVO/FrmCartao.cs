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
    public partial class FrmCartao : Form
    {
        bool Novo = true;

        public FrmCartao()
        {
            InitializeComponent();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            TxtCrCodigo.Enabled = true;
            Novo = true;
        }

        private void FrmCartao_Load(object sender, EventArgs e)
        {
            GrdItens.AutoGenerateColumns = false;
            CCartao.CCartaoClient oProxy = new CCartao.CCartaoClient();
            CboCrCodigoFabricante.DisplayMember = "FaNome";
            CboCrCodigoFabricante.ValueMember = "FaCodigo";
            CboCrCodigoFabricante.DataSource = oProxy.ListarFabricantes();
            GrdItens.DataSource = oProxy.ListarCARTAOs();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           CboCrTipo.SelectedIndex = 0; 
           if (validador1.isValid())
            {
                CCartao.CARTAO oCARTAO = new CCartao.CARTAO();
                CCartao.CCartaoClient oProxy = new CCartao.CCartaoClient();
                oCARTAO.CrNumeroCartao = TxtCrNumeroCartao.Text;
                oCARTAO.CrBloqueado = ChkCrBloqueado.Checked;
                if (ChkCrBloqueado.Checked == true)
                {
                    oCARTAO.CrDataBloqueio = DateTime.Now;
                    oCARTAO.CrMotivoBloqueio = TxtCrMotivoBloqueio.Text;
                }
                else
                {
                    oCARTAO.CrDataBloqueio = null;
                    oCARTAO.CrMotivoBloqueio = null;
                }
                oCARTAO.CrCodigoFabricante = (int)CboCrCodigoFabricante.SelectedValue;                
                oCARTAO.CrTipo = char.Parse(CboCrTipo.Text);
                
                
                
                try
                {
                    if (Novo == true)
                    {                        
                        oProxy.Incluir(oCARTAO);
                       MessageBox.Show("O cartão CId_S foi incluído com sucesso.",ProductName);
                    }
                    else
                    {
                        oCARTAO.CrCodigo = int.Parse(TxtCrCodigo.Text);
                        oProxy.Alterar(oCARTAO);
                        MessageBox.Show("O cartão CId_S foi alterado com sucesso.", ProductName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu ao salvar o registro: " + ex.Message + ".", ProductName);
                    return;
                }
                Novo = true;
                TxtCrCodigo.Enabled = true;
                validador1.LimpaControles();
                var retorno = oProxy.ListarCARTAOs();
                GrdItens.DataSource = retorno;
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {

                    CCartao.CCartaoClient oProxy = new CCartao.CCartaoClient();
                    var oCARTAO = oProxy.SelecionaCARTAO((int)GrdItens.Rows[e.RowIndex].Cells[0].Value);
                    if (oCARTAO != null)
                    {
                        TxtCrCodigo.Text = oCARTAO.CrCodigo.ToString();
                        TxtCrNumeroCartao.Text = oCARTAO.CrNumeroCartao;
                        CboCrTipo.SelectedText = oCARTAO.CrTipo.ToString();
                        CboCrCodigoFabricante.SelectedValue = oCARTAO.CrCodigoFabricante;
                        ChkCrBloqueado.Checked = (bool)oCARTAO.CrBloqueado;
                        TxtCrCodigo.Enabled = false;
                        Novo = false;
                    }
                    else
                    {
                        Novo = true;
                        TxtCrCodigo.Enabled = true;
                        validador1.LimpaControles();
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CCartao.CCartaoClient oProxy = new CCartao.CCartaoClient();
                        CCartao.CARTAO oCARTAO = new CCartao.CARTAO();
                        oCARTAO.CrCodigo = (int)GrdItens.Rows[e.RowIndex].Cells[0].Value;
                        oProxy.Excluir(oCARTAO);
                        var retorno = oProxy.ListarCARTAOs();
                        GrdItens.DataSource = retorno;
                    }
                }
            }
        }

        private void FrmCartao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuCadCartao.Enabled = true;
        }
    }
}
