using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ACESSO;
using ACESSO.BIOMETRIA;

namespace ACESSO.ADMINISTRATIVO
{
    public partial class FrmSeleçãoDedoCaptura : Form
    {

        private int CodigoUsuario, CodigoEquipamento;
        private Bitmap bmpScreenshot;

        public FrmSeleçãoDedoCaptura(int Usuario)
        {
            CodigoUsuario = Usuario;
            //CodigoEquipamento = Equipamento;
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private CDigital.DIGITAL MontaDigital(Biometria.TipoMao Mao, Biometria.TipoDedo Dedo, Image Imagem, int CodigoAcesso, DateTime DataVencimento, string TextoHash, int CodigoEquipamento, out CDigital.HASHDIGITAL Hash)
        {
            CDigital.DIGITAL oDig = new CDigital.DIGITAL();
            if (Mao == Biometria.TipoMao.Direita)
            {
                oDig.DiMao = char.Parse("D");
            }
            else
            {
                oDig.DiMao = char.Parse("E");
            }
            oDig.DiDataVencimento = DataVencimento;
            //P=Polegar; I=Indicador; M=Médio; A=Anelar; N=Mínimo
            switch (Dedo)
            {
                case Biometria.TipoDedo.Anelar:
                    {
                        oDig.DiDedo = char.Parse("A");
                        break;
                    }
                case Biometria.TipoDedo.Indicador:
                    {
                        oDig.DiDedo = char.Parse("I");
                        break;
                    }
                case Biometria.TipoDedo.Médio:
                    {
                        oDig.DiDedo = char.Parse("M");
                        break;
                    }
                case Biometria.TipoDedo.Mínimo:
                    {
                        oDig.DiDedo = char.Parse("N");
                        break;
                    }
                case Biometria.TipoDedo.Polegar:
                    {
                        oDig.DiDedo = char.Parse("P");
                        break;
                    }
            }
            
            

            ////DESCOMENTAR, CASO QUEIRA GRAVAR A IMAGEM EM BANCO DE DADOS
            //MemoryStream ms = new System.IO.MemoryStream();
            //Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            //byte[] img = ms.GetBuffer();
            ////DESCOMENTAR, CASO QUEIRA GRAVAR A IMAGEM EM BANCO DE DADOS

            CDigital.HASHDIGITAL oHash = new CDigital.HASHDIGITAL();
            oHash.HaCodigoEquipamento = 1;
            oHash.HaCredencialBiometricaTextual = TextoHash;
            oHash.HaCodigoUsuario = CodigoUsuario;                
            Hash = oHash;
            return oDig;         

        }

        private void InsereDados(FrmCaptura oFrm, Biometria.TipoMao Mao, Biometria.TipoDedo Dedo)
        {
            CDigital.HASHDIGITAL Hash1, Hash2, Hash3;
            var Digital1 = MontaDigital(Mao, Dedo, oFrm.PrimeiraDigital, CodigoUsuario, DtpValidade.Value, oFrm.Codigo1, CodigoEquipamento, out Hash1);
            var Digital2 = MontaDigital(Mao, Dedo, oFrm.SegundaDigital, CodigoUsuario, DtpValidade.Value, oFrm.Codigo2, CodigoEquipamento, out Hash2);
            var Digital3 = MontaDigital(Mao, Dedo, oFrm.TerceiraDigital, CodigoUsuario, DtpValidade.Value, oFrm.Codigo3, CodigoEquipamento, out Hash3);

            CDigital.CDigitalClient oProxy = new CDigital.CDigitalClient();
            oProxy.Incluir(Digital1, Hash1, Digital2, Hash2, Digital3, Hash3);

        }

        private void BtnPolegarEsquerdo_Click(object sender, EventArgs e)
        {

            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Polegar, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Polegar);
                oFrm.Dispose();
            }
        }

        private void BtnIndicadorEsquerdo_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Indicador, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Indicador);
                oFrm.Dispose();
            }
        }

        private void BtnMedioEsquerdo_Click(object sender, EventArgs e)
        {

            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Médio, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Médio);
                oFrm.Dispose();
            }
        }

        private void BtnAnelar_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Anelar, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Anelar);
                oFrm.Dispose();
            }
        }

        private void BtnMinimo_Click(object sender, EventArgs e)
        {

            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Mínimo, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Esquerda, Biometria.TipoDedo.Mínimo);
                oFrm.Dispose();
            }
        }

        private void BtnPolegarDireito_Click(object sender, EventArgs e)
        {

            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Direita, Biometria.TipoDedo.Polegar, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Direita, Biometria.TipoDedo.Polegar);
                oFrm.Dispose();
            }
        }

        private void BtnIndicadorDireito_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Direita, Biometria.TipoDedo.Indicador, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Direita, Biometria.TipoDedo.Indicador);
                oFrm.Dispose();
            }
        }

        private void BtnMedioDireito_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Direita, Biometria.TipoDedo.Médio, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Direita, Biometria.TipoDedo.Médio);
                oFrm.Dispose();
            }
        }

        private void BtnAnelarDireito_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Direita, Biometria.TipoDedo.Anelar, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Direita, Biometria.TipoDedo.Anelar);
                oFrm.Dispose();
            }
        }

        private void BtnMinimoDireito_Click(object sender, EventArgs e)
        {
            FrmCaptura oFrm = new FrmCaptura(Biometria.TipoMao.Direita, Biometria.TipoDedo.Mínimo, short.Parse(CboDispositivo.Text.Substring(0, 2)));
            oFrm.ShowDialog();
            if (oFrm.LeiturasConfirmadas)
            {
                InsereDados(oFrm, Biometria.TipoMao.Direita, Biometria.TipoDedo.Mínimo);
                oFrm.Dispose();
            }
        }

        private void FrmTestaCaptura_Load(object sender, EventArgs e)
        {
            DtpValidade.Value = DateTime.Now.AddYears(2);

            Biometria Bio = new Biometria();
            List<Biometria.DeviceName> Lista = Bio.DeviceID();
            for (int i = 0; i < Lista.Count; i++)
            {
                CboDispositivo.Items.Add(((int)Lista[i]).ToString() + " - " + Lista[i].ToString());
            }
            if (CboDispositivo.Items.Count > 0)
            {
                CboDispositivo.SelectedIndex = 0;
            }
        }
    }
}
