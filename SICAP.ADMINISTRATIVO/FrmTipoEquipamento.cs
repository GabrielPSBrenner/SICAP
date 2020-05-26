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
    public partial class FrmTipoEquipamento : Form
    {
        private bool Novo = true;

        public FrmTipoEquipamento()
        {
            InitializeComponent();
        }


        private void FrmEquipamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuCadTipoEquipamento.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CTipoEquipamento.TIPOEQUIPAMENTO oTipo = new CTipoEquipamento.TIPOEQUIPAMENTO();
                CTipoEquipamento.CTipoEquipamentoClient oProxy = new CTipoEquipamento.CTipoEquipamentoClient();

                oTipo.TEDescricao = TxtTEDescricao.Text;
                oTipo.TEEPI = ChkTEEPI.Checked;
                if (Novo == true)
                {                    
                    oProxy.Incluir(oTipo);
                }
                else
                {
                    oTipo.TECodigo = int.Parse(TxtTECodigo.Text);
                    oProxy.Alterar(oTipo);
                }
                Novo = true;
                TxtTECodigo.Enabled = true;
                validador1.LimpaControles();
                ChkTEEPI.Checked = false;
                var retorno = oProxy.ListarTodosTiposEquipamento();
                GrdItens.DataSource = retorno;
            }
        }

        private void FrmEquipamento_Load(object sender, EventArgs e)
        {
            GrdItens.AutoGenerateColumns = false;
            CTipoEquipamento.CTipoEquipamentoClient oProxy = new CTipoEquipamento.CTipoEquipamentoClient();           
            var retorno = oProxy.ListarTodosTiposEquipamento();
            GrdItens.DataSource = retorno;            
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    
                    CTipoEquipamento.CTipoEquipamentoClient oProxy = new CTipoEquipamento.CTipoEquipamentoClient();
                    var oTipo = oProxy.SelecionaPKTipoEquipamento((int)GrdItens.Rows[e.RowIndex].Cells[0].Value);
                    if (oTipo != null)
                    {
                        TxtTECodigo.Text = oTipo.TECodigo.ToString();
                        TxtTEDescricao.Text = oTipo.TEDescricao;
                        ChkTEEPI.Checked = (bool)oTipo.TEEPI;
                        TxtTECodigo.Enabled = false;
                        Novo = false;
                    }
                    else
                    {
                        Novo = true;
                        TxtTECodigo.Enabled = true;
                        validador1.LimpaControles();
                        ChkTEEPI.Checked = false;
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CTipoEquipamento.CTipoEquipamentoClient oProxy = new CTipoEquipamento.CTipoEquipamentoClient();
                        CTipoEquipamento.TIPOEQUIPAMENTO oTipo = new CTipoEquipamento.TIPOEQUIPAMENTO();
                        oTipo.TECodigo = (int)GrdItens.Rows[e.RowIndex].Cells[0].Value;
                        oProxy.Excluir(oTipo);
                        var retorno = oProxy.ListarTodosTiposEquipamento();
                        GrdItens.DataSource = retorno;
                    }
                }
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            TxtTECodigo.Enabled = true;
            ChkTEEPI.Checked = false;
            Novo = true;
        }     
    }
}
