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
    public partial class FrmFabricante : Form
    {
        private bool Novo = true;

        public FrmFabricante()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CFabricante.FABRICANTE oFabricante = new CFabricante.FABRICANTE();
                CFabricante.CFabricanteClient oProxy = new CFabricante.CFabricanteClient();

                oFabricante.FaNome = TxtFaNome.Text;
                if (Novo == true)
                {                    
                    oProxy.Incluir(oFabricante);
                }
                else
                {
                    oFabricante.FaCodigo = int.Parse(TxtFaCodigo.Text);
                    oProxy.Alterar(oFabricante);
                }
                Novo = true;
                TxtFaCodigo.Enabled = true;
                validador1.LimpaControles();
                var retorno = oProxy.ListarTodosFabricantes();
                GrdItens.DataSource = retorno;
            }
        }

        private void FrmFabricante_Load(object sender, EventArgs e)
        {
            GrdItens.AutoGenerateColumns = false;
            CFabricante.CFabricanteClient oProxy = new CFabricante.CFabricanteClient();
            var retorno = oProxy.ListarTodosFabricantes();
            GrdItens.DataSource = retorno;       
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {

                    CFabricante.CFabricanteClient oProxy = new CFabricante.CFabricanteClient();
                    var oFabricante = oProxy.SelecionaPKFabricante((int)GrdItens.Rows[e.RowIndex].Cells[0].Value);
                    if (oFabricante != null)
                    {
                        TxtFaCodigo.Text = oFabricante.FaCodigo.ToString();
                        TxtFaNome.Text = oFabricante.FaNome;
                        TxtFaCodigo.Enabled = false;
                        Novo = false;
                    }
                    else
                    {
                        Novo = true;
                        TxtFaCodigo.Enabled = true;
                        validador1.LimpaControles();
                    }
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CFabricante.CFabricanteClient oProxy = new CFabricante.CFabricanteClient();
                        CFabricante.FABRICANTE oFabricante = new CFabricante.FABRICANTE();
                        oFabricante.FaCodigo = (int)GrdItens.Rows[e.RowIndex].Cells[0].Value;
                        oProxy.Excluir(oFabricante);
                        var retorno = oProxy.ListarTodosFabricantes();
                        GrdItens.DataSource = retorno;
                    }
                }
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            TxtFaCodigo.Enabled = true;
            Novo = true;
        }

        private void FrmFabricante_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuCadFabricante.Enabled = true;
        }
    }
}
