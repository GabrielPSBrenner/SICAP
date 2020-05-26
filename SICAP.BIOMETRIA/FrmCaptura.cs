using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;
using System.Drawing.Imaging;

namespace ACESSO.BIOMETRIA
{
    public partial class FrmCaptura : Form
    {
        #region "Variáveis internas"
        NBioAPI m_NBioAPI;
        private short IDDispositivo;
        private System.Drawing.Image Imagem1, Imagem2, Imagem3;
        private string SecurityCode1, SecurityCode2, SecurityCode3;
        private Biometria.TipoMao Mao;
        private Biometria.TipoDedo Dedo;
        private Boolean Leitura = false;

        #endregion

        #region "Variáveis expostas"

        public System.Drawing.Image PrimeiraDigital
        {
            get
            {
                return Imagem1;
            }
        }

        public System.Drawing.Image SegundaDigital
        {
            get
            {
                return Imagem2;
            }
        }

        public System.Drawing.Image TerceiraDigital
        {
            get
            {
                return Imagem3;
            }


        }

        public string Codigo1
        {
            get
            {
                return SecurityCode1;
            }
        }


        public string Codigo2
        {
            get
            {
                return SecurityCode2;
            }
        }

        public string Codigo3
        {
            get
            {
                return SecurityCode3;
            }
        }

        public bool LeiturasConfirmadas
        {
            get
            {
                return Leitura;
            }

        }

        #endregion

        public FrmCaptura(Biometria.TipoMao pMao, Biometria.TipoDedo pDedo, short Dispositivo)
        {
            Mao = pMao;
            Dedo = pDedo;
            IDDispositivo = Dispositivo;
            InitializeComponent();
        }



        private void FrmCaptura_Load(object sender, EventArgs e)
        {
            LblDescMao.Text = Mao.ToString();
            LblDescDedo.Text = Dedo.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Leitura = false;
            this.Close();
        }

        private void PctDigital1_Click(object sender, EventArgs e)
        {
            Biometria bio = new Biometria();
            NBioAPI.Type.FIR myFIR;
            NBioAPI.Type.FIR_TEXTENCODE myFirText;
            bio.Capture(IDDispositivo, PctDigital1, LblQualidade1, LblFinaliza1, Dedo, Mao, out myFIR, out myFirText,false);
            SecurityCode1 = myFirText.TextFIR;
            Bitmap bmpScreenshot = new Bitmap(PctDigital1.Width, PctDigital1.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Left + PctDigital1.Left+4, this.Top + PctDigital1.Top + 26, 0 , 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            PctDigital1.Image = bmpScreenshot;
            Imagem1 = bmpScreenshot;
        }

        private void PctDigital2_Click(object sender, EventArgs e)
        {
            Biometria bio = new Biometria();
            NBioAPI.Type.FIR myFIR;
            NBioAPI.Type.FIR_TEXTENCODE myFirText;
            bio.Capture(IDDispositivo, PctDigital2, LblQualidade2, LblFinaliza2, Dedo, Mao, out myFIR, out myFirText, false);
            SecurityCode2 = myFirText.TextFIR;

            Bitmap bmpScreenshot = new Bitmap(PctDigital2.Width, PctDigital2.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Left + PctDigital2.Left + 4, this.Top + PctDigital2.Top + 26, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            PctDigital2.Image = bmpScreenshot;
            Imagem2 = bmpScreenshot;
        }

        private void PctDigital3_Click(object sender, EventArgs e)
        {
            Biometria bio = new Biometria();
            NBioAPI.Type.FIR myFIR;
            NBioAPI.Type.FIR_TEXTENCODE myFirText;
            bio.Capture(IDDispositivo, PctDigital3, LblQualidade3, LblFinaliza3, Dedo, Mao, out myFIR, out myFirText, false);
            SecurityCode3 = myFirText.TextFIR;

            Bitmap bmpScreenshot = new Bitmap(PctDigital3.Width, PctDigital3.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Left + PctDigital3.Left + 4, this.Top + PctDigital3.Top + 26, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            PctDigital3.Image = bmpScreenshot;
            Imagem3 = bmpScreenshot;

        }

        private void BtnComparaFIR_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (LblQualidade1.Text.Trim() == "")
            {
                MessageBox.Show("É necessário adquirir as 3 cópias das digitais do dedo selecionado antes de confirmar.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (LblQualidade2.Text.Trim() == "")
            {
                MessageBox.Show("É necessário adquirir as 3 cópias das digitais do dedo selecionado antes de confirmar.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (LblQualidade3.Text.Trim() == "")
            {
                MessageBox.Show("É necessário adquirir as 3 cópias das digitais do dedo selecionado antes de confirmar.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(LblQualidade1.Text) < 100)
            {
                MessageBox.Show("Todas as cópias das digitais tem que estar com a qualidade 100%.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(LblQualidade2.Text) < 100)
            {
                MessageBox.Show("Todas as cópias das digitais tem que estar com a qualidade 100%.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(LblQualidade3.Text) < 100)
            {
                MessageBox.Show("Todas as cópias das digitais tem que estar com a qualidade 100%.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Leitura = true;
                this.Hide();
            }
        }

 

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
