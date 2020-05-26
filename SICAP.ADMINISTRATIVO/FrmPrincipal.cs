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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

         private void MnuCadTipoEquipamento_Click(object sender, EventArgs e)
        {
            MnuCadTipoEquipamento.Enabled = false;
            FrmTipoEquipamento oFrm = new FrmTipoEquipamento();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCadFabricante_Click(object sender, EventArgs e)
        {
            MnuCadFabricante.Enabled = false;
            FrmFabricante oFrm = new FrmFabricante();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCadFornecedor_Click(object sender, EventArgs e)
        {
            MnuCadFornecedor.Enabled = false;
            FrmFornecedor oFrm = new FrmFornecedor();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuParametro_Click(object sender, EventArgs e)
        {
            MnuParametro.Enabled = false;
            FrmParametro oFrm = new FrmParametro();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void MnuCadEquipamento_Click(object sender, EventArgs e)
        {
            MnuCadEquipamento.Enabled = false;
            FrmEquipamento oFrm = new FrmEquipamento();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCadCartao_Click(object sender, EventArgs e)
        {
            MnuCadCartao.Enabled = false;
            FrmCartao oFrm = new FrmCartao();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCadRotas_Click(object sender, EventArgs e)
        {
            MnuCadRotas.Enabled = false;
            FrmRota oFrm = new FrmRota();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCadPonto_Click(object sender, EventArgs e)
        {
            MnuCadPonto.Enabled = false;
            FrmPontoControle oFrm = new FrmPontoControle();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuCUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void MnuEqObrigatorioPC_Click(object sender, EventArgs e)
        {
            MnuEqObrigatorioPC.Enabled = false;
            FrmEqPontoControle oFrm = new FrmEqPontoControle();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           controleToolStripMenuItem.Enabled = false;
           FrmUsuario oFrm = new FrmUsuario();
           oFrm.MdiParent = this;
           oFrm.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
