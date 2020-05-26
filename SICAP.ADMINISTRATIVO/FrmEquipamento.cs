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
    public partial class FrmEquipamento : Form
    {
        private bool Novo = true;

        public FrmEquipamento()
        {
            InitializeComponent();
        }

        private void FrmEquipamento_Load(object sender, EventArgs e)
        {
            GrdItens.AutoGenerateColumns = false;
            CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
            CboEqTipoEquipamento.DisplayMember = "TEDescricao";
            CboEqTipoEquipamento.ValueMember = "TECodigo";
            CboEqTipoEquipamento.DataSource = oProxy.ListarTiposEquipamentos();
            CboEqTipoEquipamento.SelectedIndex = -1;

            CboFaCodigoFabricante.DisplayMember = "FaNome";
            CboFaCodigoFabricante.ValueMember = "FaCodigo";
            CboFaCodigoFabricante.DataSource = oProxy.ListarFabricantes();
        }

        private void CboEqTipoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEqTipoEquipamento.SelectedIndex > -1)
            {
                CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
                var Lista = oProxy.ListarEquipamentosTipo((int)CboEqTipoEquipamento.SelectedValue);
                GrdItens.DataSource = Lista;
            }
            else
            {
                GrdItens.DataSource = null;
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            TxtEqCodigo.Enabled = true;
            Novo = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CEquipamento.EQUIPAMENTO oEquipamento = new CEquipamento.EQUIPAMENTO();
                CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
                oEquipamento.EqNome = TxtEqNome.Text;

               // oEquipamento.EqTempoSinal = int.Parse(TxtEqTempoSinal.Text);
                oEquipamento.EqTipoEquipamento = (int)CboEqTipoEquipamento.SelectedValue;
                //oEquipamento.EqTipoLibera = char.Parse(CboEqTipoLibera.Text);
                //oEquipamento.FaCodigoFabricante = (int)CboFaCodigoFabricante.SelectedValue;                
                oEquipamento.EqTAGRFID = TxtEqTAGRFID.Text;
                oEquipamento.EqBloqueado = (bool)ChkEqBloqueado.Checked;
                try
                {
                    if (Novo == true)
                    {
                        oProxy.Incluir(oEquipamento);
                       MessageBox.Show("Equipamento EPP_S incluído com sucesso.",ProductName);
                    }
                    else
                    {
                        oEquipamento.EqCodigo = int.Parse(TxtEqCodigo.Text);
                        oProxy.Alterar(oEquipamento);
                        MessageBox.Show("Equipamento EPP_S alterado com sucesso.", ProductName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu ao salvar o registro: " + ex.Message + ".", ProductName);
                    return;
                }
                Novo = true;
                TxtEqCodigo.Enabled = true;
                validador1.LimpaControles();
                var retorno = oProxy.ListarEquipamentosTipo((int)CboEqTipoEquipamento.SelectedValue);
                GrdItens.DataSource = retorno;
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {

                    CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
                    var oEquipamento = oProxy.SelecionaEquipamento((int)GrdItens.Rows[e.RowIndex].Cells[0].Value);
                    if (oEquipamento != null)
                    {
                        TxtEqCodigo.Text = oEquipamento.EqCodigo.ToString();
                        TxtEqNome.Text = oEquipamento.EqNome;
                        CboEqTipoLibera.SelectedText = oEquipamento.EqTipoLibera.ToString();
                        CboFaCodigoFabricante.SelectedValue = oEquipamento.FaCodigoFabricante;
                        TxtEqTempoSinal.Text = oEquipamento.EqTempoSinal.ToString();
                        CboEqTipoLibera.Text = oEquipamento.EqTipoLibera.ToString();
                        TxtEqTAGRFID.Text = oEquipamento.EqTAGRFID;
                        if (oEquipamento.EqBloqueado != null)
                        {
                            ChkEqBloqueado.Checked = (bool)oEquipamento.EqBloqueado;
                        }
                        else
                        {
                            ChkEqBloqueado.Checked = false;
                        }
                        TxtEqCodigo.Enabled = false;
                        Novo = false;
                    }
                    else
                    {
                        Novo = true;
                        TxtEqCodigo.Enabled = true;
                        validador1.LimpaControles();
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
                        CEquipamento.EQUIPAMENTO oEquipamento = new CEquipamento.EQUIPAMENTO();
                        oEquipamento.EqCodigo = (int)GrdItens.Rows[e.RowIndex].Cells[0].Value;
                        oProxy.Excluir(oEquipamento);
                        var retorno = oProxy.ListarEquipamentosTipo((int)CboEqTipoEquipamento.SelectedValue);
                        GrdItens.DataSource = retorno;
                    }
                }
            }
        }

        private void FrmEquipamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuCadEquipamento.Enabled = true;
        }

        private void GrdItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrdItens_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            CEquipamento.CEquipamentoClient oProxy = new CEquipamento.CEquipamentoClient();
            for (int i = 0; i < GrdItens.Rows.Count; i++)
            {                
                var objEquipamento = (CEquipamento.EQUIPAMENTO)GrdItens.Rows[i].DataBoundItem;
                //var objFabricante = oProxy.SelecionaFabricante(objEquipamento.FaCodigoFabricante);
                //GrdItens.Rows[i].Cells[6].Value = objFabricante.FaNome;
            }
        }
    }
}
