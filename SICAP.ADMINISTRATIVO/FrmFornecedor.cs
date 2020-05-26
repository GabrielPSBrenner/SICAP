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
    public partial class FrmFornecedor : Form
    {
        private bool Novo = true;
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            TxtFOCNPJ.Enabled = true;
            Novo = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CFORNECEDOR.FORNECEDOR oFORNECEDOR = new CFORNECEDOR.FORNECEDOR();
                CFORNECEDOR.CFORNECEDORClient oProxy = new CFORNECEDOR.CFORNECEDORClient();
                oFORNECEDOR.FOCNPJ = TxtFOCNPJ.Text;
                oFORNECEDOR.FONomeFantasia = TxtFONomeFantasia.Text;
                oFORNECEDOR.FORazaoSocial = TxtFoRazaoSocial.Text;
                if (Novo == true)
                {                    
                    oProxy.Incluir(oFORNECEDOR);
                }
                else
                {
                    oProxy.Alterar(oFORNECEDOR);
                }
                Novo = true;
                TxtFOCNPJ.Enabled = true;
                validador1.LimpaControles();
                var retorno = oProxy.ListarTodosFornecedores();
                GrdItens.DataSource = retorno;
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {

                    CFORNECEDOR.CFORNECEDORClient oProxy = new CFORNECEDOR.CFORNECEDORClient();
                    var oFORNECEDOR = oProxy.SelecionaPKFornecedor(GrdItens.Rows[e.RowIndex].Cells[0].Value.ToString()) ;
                    if (oFORNECEDOR != null)
                    {
                        TxtFOCNPJ.Text = oFORNECEDOR.FOCNPJ;
                        TxtFONomeFantasia.Text = oFORNECEDOR.FONomeFantasia;
                        TxtFoRazaoSocial.Text = oFORNECEDOR.FORazaoSocial;
                        TxtFOCNPJ.Enabled = false;
                        Novo = false;
                    }
                    else
                    {
                        Novo = true;
                        TxtFOCNPJ.Enabled = true;
                        validador1.LimpaControles();
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CFORNECEDOR.CFORNECEDORClient oProxy = new CFORNECEDOR.CFORNECEDORClient();
                        CFORNECEDOR.FORNECEDOR oFORNECEDOR = new CFORNECEDOR.FORNECEDOR();
                        oFORNECEDOR.FOCNPJ = GrdItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                        oProxy.Excluir(oFORNECEDOR);
                        var retorno = oProxy.ListarTodosFornecedores();
                        GrdItens.DataSource = retorno;
                    }
                }
            }
        }

        private void FrmFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuCadFornecedor.Enabled = true;
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            GrdItens.AutoGenerateColumns = false;
            CFORNECEDOR.CFORNECEDORClient oProxy = new CFORNECEDOR.CFORNECEDORClient();
            var retorno = oProxy.ListarTodosFornecedores();
            GrdItens.DataSource = retorno;       
        }
    }
}
