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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuAcessos_Click(object sender, EventArgs e)
        {
            FrmFiltro oFrm = new FrmFiltro();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuAcessos.Enabled = false;
        }

        private void MnuTotalAcessosDia_Click(object sender, EventArgs e)
        {
            FrmTotalAcessoPontoDia oFrm = new FrmTotalAcessoPontoDia();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuTotalAcessosDia.Enabled = false;
        }       

    }
}
