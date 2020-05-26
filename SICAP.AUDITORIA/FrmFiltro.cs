using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACESSO.AUDITORIA.CFiltro;
using ACESSO.AUDITORIA.CConsulta;

namespace ACESSO.AUDITORIA
{
    public partial class FrmFiltro : Form
    {
        public FrmFiltro()
        {
            InitializeComponent();
        }

        private void CboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipoUsuario.SelectedIndex > 0)
            {
                TxtCodigoUsuario.Enabled = true;
            }
            else
            {
                TxtCodigoUsuario.Text = "";
                LblUsuario.Text = "";
                TxtCodigoUsuario.Enabled = false;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboTipoPonto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CFiltroClient oProxy = new CFiltroClient();
            PONTOCONTROLE[] oListaPonto;
            if (CboTipoPonto.SelectedIndex > 0)
            {
                char Tipo;
                if (CboTipoPonto.SelectedIndex == 1)
                    Tipo = char.Parse("E");
                else
                    Tipo = char.Parse("S");
                oListaPonto = oProxy.ListarPontosControle(Tipo);
            }
            else
            {
                oListaPonto = oProxy.ListarTodosPontosControle();
            }
            PONTOCONTROLE oPonto = new PONTOCONTROLE();
            oPonto.PoNome = "TODOS OS PONTOS";

            List<PONTOCONTROLE> oLista = new List<PONTOCONTROLE>();
            oLista.Add(oPonto);

            for (int i = 0; i < oListaPonto.Length; i++)
            {
                oLista.Add(oListaPonto[i]);
            }
            CboPonto.DataSource = oLista;
            CboPonto.DisplayMember = "PoNome";
            CboPonto.ValueMember = "PoCodigo";
            oProxy.Close();

        }

        private void TxtCodigoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigoUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoUsuario.Text.Trim() != "")
            {
                CFiltroClient oProxy = new CFiltroClient();
                try
                {
                    if (CboTipoUsuario.SelectedIndex == 1)
                    {
                        var Usuario = oProxy.SelecionaTerceiro(int.Parse(TxtCodigoUsuario.Text));
                        LblUsuario.Text = Usuario.TeNome;

                    }
                    else if (CboTipoUsuario.SelectedIndex == 2)
                    {
                        var Usuario = oProxy.SelecionaFuncionario(int.Parse(TxtCodigoUsuario.Text));
                        LblUsuario.Text = Usuario.FUNOMFUNC;
                    }
                    else if (CboTipoUsuario.SelectedIndex == 3)
                    {
                        var Usuario = oProxy.SelecionaEstagiario(int.Parse(TxtCodigoUsuario.Text));
                        LblUsuario.Text = Usuario.ESNome;
                    }
                    else
                    {
                        var Usuario = oProxy.SelecionaVisitante(int.Parse(TxtCodigoUsuario.Text));
                        LblUsuario.Text = Usuario.ViNome;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O código informada não corresponde de um " + CboTipoUsuario.Text + " válido. Confira a digitação!");
                    TxtCodigoUsuario.Focus();
                }
                oProxy.Close();
            }
            else
            {
                LblUsuario.Text = "";
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            CConsultaAcessoClient oProxy = new CConsultaAcessoClient();
            DateTime DataInicio, DataFim ;
            string TextoConsulta="";
            string TipoAcesso, TipoPonto;
            int PontoControle, TipoUsuario, CodigoUsuario;

            if (DateTime.TryParse(MskDataInicio.Text,out DataInicio)==false)
            {
                DataInicio = DateTime.Parse("01/01/2000");
            }
            else
            {
                TextoConsulta+="Início do período de seleção >=" + DataInicio.ToString("dd/MM/yyyy");
            }
            
            if (DateTime.TryParse(MskDataFim.Text,out DataFim)==false)
            {
                DataFim = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")).AddDays(1);
            }
            else
            {
                if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                TextoConsulta+="Final do período de seleção <=" + DataInicio.ToString("dd/MM/yyyy");
                DataFim = DataFim.AddDays(1);
            }

            if (CboTipoPonto.SelectedIndex < 1)
            {
                TipoPonto = "";
            }
            else if (CboTipoPonto.SelectedIndex == 1)
            {
                TipoPonto = "E";
                 if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                 TextoConsulta += " Tipo Ponto de Controle PCAP_S=Entrada";
            }
            else
            {
                TipoPonto = "S";
                 if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                 TextoConsulta += "Tipo Ponto de Controle PCAP_S=Saída";
            }
            
            if (CboPonto.SelectedIndex > -1)
            {
                PontoControle = (int)CboPonto.SelectedValue;
                 if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                 TextoConsulta += "Ponto de Controle PCAP_S= " + ((PONTOCONTROLE)CboPonto.SelectedItem).PoNome;
            }
            else
            {
                PontoControle = 0;
            }
            
            
            TipoAcesso = CboTipoAcesso.Text;
            
            if (CboTipoUsuario.SelectedIndex > 0)
            {
                TipoUsuario = CboTipoUsuario.SelectedIndex;
                 if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                 TextoConsulta += "Tipo de Usuário USR= " + CboTipoUsuario.Text;
            }
            else
            {
                TipoUsuario = 0;
            }
            
            if (TxtCodigoUsuario.Text.Trim() != "")
            {
                CodigoUsuario = int.Parse(TxtCodigoUsuario.Text);
                if (TextoConsulta.Trim()!="") TextoConsulta+=" e ";
                TextoConsulta += "Usuário=" + LblUsuario.Text;
            }
            else
            {
                CodigoUsuario = 0;
            }
            var Retorno = oProxy.SelecionaAcessos(DataInicio, DataFim, TipoPonto, PontoControle, TipoAcesso, TipoUsuario,  CodigoUsuario);
            oProxy.Close();

            FrmConsulta oFrm = new FrmConsulta(Retorno,TextoConsulta);
            oFrm.Show();
            this.Close();
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            CboTipoPonto.SelectedIndex = 0;
            CboTipoAcesso.SelectedIndex = 0;
            CboTipoUsuario.SelectedIndex = 0;
        }

        private void FrmFiltro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuAcessos.Enabled = true;
        }
    }
}
