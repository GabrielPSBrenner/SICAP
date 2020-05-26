using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACESSO.AUDITORIA.CDetalheAcesso;

namespace ACESSO.AUDITORIA
{
    public partial class FrmDetalheAcesso : Form
    {
        private int Codigo;

        public FrmDetalheAcesso(int pCodigo)
        {
            InitializeComponent();
            Codigo = pCodigo;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalheAcesso_Load(object sender, EventArgs e)
        {
            CDetalheAcessoClient oProxy = new CDetalheAcessoClient();
            vw_Acesso oAcesso = oProxy.oAcesso(Codigo);
            LblAPCodigo.Text = oAcesso.APCodigo.ToString();
            LblAPDataAcesso.Text = oAcesso.APDataAcesso.ToString("dd/MM/yyyy - hh:mm:ss");
            LblAPCodigoPontoControle.Text = oAcesso.APCodigoPontoControle.ToString();
            LblPoNome.Text = oAcesso.PoNome;
            if (oAcesso.USCODIGOESTAGIARIO != null)
            {
                //Estagiário
                LblTipoUsuario.Text = "Estagiário";
                
                LblCodigoUsuario.Text = ((int)oAcesso.USCODIGOESTAGIARIO).ToString("0000");
                LblNomeUsuario.Text = oAcesso.ESNome;
            }
            else if (oAcesso.USCODIGOTERCEIRO!=null)
            {
                //Terceiro
                LblTipoUsuario.Text = "Terceirizado";
                LblCodigoUsuario.Text = oAcesso.USCODIGOTERCEIRO.ToString();
                LblNomeUsuario.Text = oAcesso.TeNome;
            }
            else if(oAcesso.USCODIGOVISITANTE != null)
            {
                //Visitante
                LblTipoUsuario.Text = "Visitante";
                LblCodigoUsuario.Text = oAcesso.USCODIGOVISITANTE.ToString();
                LblNomeUsuario.Text = oAcesso.ViNome;
            }
            else if(oAcesso.USMATFUNC !=null)
            {
                //Empregado
                LblTipoUsuario.Text = "Empregado";
                LblCodigoUsuario.Text = ((int)oAcesso.USMATFUNC).ToString("0000");
                LblNomeUsuario.Text = oAcesso.FUNOMFUNC;
            }           
            
            ChkAPAcessoForcado.Checked = (bool)oAcesso.APAcessoForcado;
            LblAPCodigoUsuarioLiberaForcado.Text = oAcesso.APCodigoUsuarioLiberaForcado.ToString();
            ChkAPNegado.Checked = (bool)oAcesso.APNegado;
            LblAPCodigoUsuarioInterrompeAlarme.Text  = oAcesso.APCodigoUsuarioInterrompeAlarme.ToString();

            if (oAcesso.APCodigoUsuarioLiberaForcado != null)
            {
                var oUser = oProxy.oUsuario((int)oAcesso.APCodigoUsuarioLiberaForcado);
                if (oUser.USMATFUNC != null)
                {
                    LblNomeUsuarioLiberaForcado.Text = oUser.FUNOMFUNC;
                }
                else if (oUser.USCODIGOESTAGIARIO != null)
                {
                    LblNomeUsuarioLiberaForcado.Text = oUser.ESNome;
                }
                else if (oUser.USCODIGOTERCEIRO != null)
                {
                    LblNomeUsuarioLiberaForcado.Text = oUser.TeNome;
                }
                else if (oUser.USCODIGOVISITANTE != null)
                {
                    LblNomeUsuarioLiberaForcado.Text = oUser.ViNome;
                }
            }
            else
            {
                LblNomeUsuarioLiberaForcado.Text = "";
            }

            if (oAcesso.APCodigoUsuarioInterrompeAlarme != null)
            {
                var oUser = oProxy.oUsuario((int)oAcesso.APCodigoUsuarioInterrompeAlarme);
                if (oUser.USMATFUNC != null)
                {
                    LblNomeUsuarioInterrompeAlarme.Text = oUser.FUNOMFUNC;
                }
                else if (oUser.USCODIGOESTAGIARIO != null)
                {
                    LblNomeUsuarioInterrompeAlarme.Text = oUser.ESNome;
                }
                else if (oUser.USCODIGOTERCEIRO != null)
                {
                    LblNomeUsuarioInterrompeAlarme.Text = oUser.TeNome;
                }
                else if (oUser.USCODIGOVISITANTE != null)
                {
                    LblNomeUsuarioInterrompeAlarme.Text = oUser.ViNome;
                }
            }
            else
            {
                LblNomeUsuarioInterrompeAlarme.Text = "";
            }
            LblApMotivoAcessoForcado.Text = oAcesso.APMotivoAcessoForcado;
            oProxy.Close();
        }
    }
}
