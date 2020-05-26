using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACESSO.AUDITORIA.CConsulta;

namespace ACESSO.AUDITORIA
{
    public partial class FrmConsulta : Form
    {
        vw_Acesso[] oLista;

        public FrmConsulta(vw_Acesso[] pLista, string TextoFiltro   )
        {
            InitializeComponent();
            oLista = pLista;
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = oLista;
            LblTextofiltro.Text = TextoFiltro;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdItens_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < GrdItens.Rows.Count; i++)
            {
                vw_Acesso oAcesso = (vw_Acesso)GrdItens.Rows[i].DataBoundItem;
                string Nome, Matricula;
                switch(oAcesso.USTIPO.ToString().ToUpper())
                {
                    case "E":
                        {
                            //Empregado
                            Matricula = int.Parse(oAcesso.USMATFUNC.ToString()).ToString("0000");
                            Nome = oAcesso.FUNOMFUNC;
                            break;
                        }
                    case "T":
                        {
                            //Terceiro
                            Matricula = oAcesso.USCODIGOTERCEIRO.ToString();
                            Nome = oAcesso.TeNome;
                            break;
                        }
                    case "S":
                        {
                            //Estagiário
                            Matricula = int.Parse(oAcesso.USCODIGOESTAGIARIO.ToString()).ToString("0000");
                            Nome = oAcesso.ESNome;
                            break;
                        }
                    case "V":
                        {
                            //Visitante
                            Matricula = oAcesso.USCODIGOVISITANTE.ToString();
                            Nome = oAcesso.ViNome;
                            break;
                        }
                    default:
                        {
                            Matricula = "";
                            Nome = "";
                            break;                        
                        }
                }
                GrdItens.Rows[i].Cells[5].Value = Matricula;
                GrdItens.Rows[i].Cells[6].Value = Nome;
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 10)
            {
                //Botão de Detalhes
                vw_Acesso oAcesso = (vw_Acesso)GrdItens.Rows[e.RowIndex].DataBoundItem;
                FrmDetalheAcesso oFrm = new FrmDetalheAcesso(oAcesso.APCodigo);
                oFrm.ShowDialog();
            }
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
