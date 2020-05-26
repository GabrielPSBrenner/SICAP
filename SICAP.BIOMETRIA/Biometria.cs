using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NITGEN.SDK.NBioBSP;
using System.Windows.Forms;

namespace ACESSO.BIOMETRIA
{
    public class Biometria
    {
        #region "Enumeradores"
        public enum DeviceName
        {
            FDP02 = 1,
            FDU01 = 2,
            OSU02 = 3,
            FDU11 = 4,
            FSC01 = 5,
            FDU03 = 6,
            FDU05 = 7
        }

        public enum TipoMao
        {
            Esquerda = 0,
            Direita = 1
        }

        public enum TipoDedo
        {
            Polegar = 0,
            Indicador = 1,
            Médio = 2,
            Anelar = 3,
            Mínimo = 4
        }


        #endregion


        #region "Variáveis Internas"
        private Label LabelQualidadeSelecionado;
        private Label LabelFinalizacaoSelecionado;
        private NBioAPI m_NBioAPI;
        NBioAPI.Type.WINDOW_OPTION m_WinOption;
        #endregion

        public Biometria()
        {
            m_NBioAPI = new NBioAPI();
            m_WinOption = new NBioAPI.Type.WINDOW_OPTION();
            m_WinOption.Option2 = new NBioAPI.Type.WINDOW_OPTION_2();
        }

        public List<DeviceName> DeviceID()
        {
            int i;
            System.UInt32 nNumDevice;
            short[] nDeviceID;
            System.UInt32 ret = m_NBioAPI.EnumerateDevice(out nNumDevice, out nDeviceID);
            List<DeviceName> Retorno = new List<DeviceName>();
            if (ret == NBioAPI.Error.NONE)
            {
                for (i = 0; i < nNumDevice; i++)
                {
                    Retorno.Add((DeviceName)nDeviceID[i]);
                }
            }
            return Retorno;
        }

        public uint AbrirDispositoPeloID(DeviceName id)
        {
            uint Retorno = m_NBioAPI.OpenDevice((short)id);
            if (Retorno == NBioAPI.Error.NONE)
            {
                throw new Exception("Não foi possível abrir o dispositivo informado.");
            }
            return Retorno;
        }

        public uint AbrirDispositoAuto()
        {
            uint Retorno = m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            if (Retorno == NBioAPI.Error.NONE)
            {
                throw new Exception("Não foi possível abrir o dispositivo, porque provavelmente não existe um dispositivo conectado e devidamente instalado.");
            }
            return Retorno;
        }


        public uint FecharDispositoPeloID(DeviceName id)
        {
            uint Retorno;
            Retorno = m_NBioAPI.CloseDevice((short)id);
            if (Retorno == NBioAPI.Error.NONE)
            {
                throw new Exception("Não foi possível fechar o dispositivo informado.");
            }
            return Retorno;
        }

        /*public NBioAPI.Type.FIR Dados(out NBioAPI.Type.FIR_TEXTENCODE TextEncoded)
        {
            NBioAPI.Type.HFIR hNewFIR;
            uint Retorno;
            Retorno = m_NBioAPI.Enroll(out hNewFIR, null);
            if (Retorno == NBioAPI.Error.NONE)
            {
                NBioAPI.Type.FIR biFIR;
                m_NBioAPI.GetFIRFromHandle(hNewFIR, out biFIR);

                // Get text encoded FIR data
                NBioAPI.Type.FIR_TEXTENCODE textFIR;
                m_NBioAPI.GetTextFIRFromHandle(hNewFIR, out textFIR, true);
                TextEncoded = textFIR;
                return biFIR;
            }
            else
            {
                TextEncoded = null;
                return null;
            }
        }*/


        private uint MyCaptureCallback(ref NBioAPI.Type.WINDOW_CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
        {
            NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX ParamEx = (NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX)System.Runtime.InteropServices.Marshal.PtrToStructure(cbParam0.ParamEx, typeof(NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX));
            string szQuality = cbParam0.Quality.ToString();

            if (LabelQualidadeSelecionado.InvokeRequired)
            {
                LabelQualidadeSelecionado.Invoke(new System.Windows.Forms.MethodInvoker(delegate()
                {
                    LabelQualidadeSelecionado.Text = szQuality;
                }
                   ));
            }
            else
                LabelQualidadeSelecionado.Text = szQuality;

            return 0;
        }

        private uint MyFinishCallback(ref NBioAPI.Type.WINDOW_CALLBACK_PARAM_1 cbParam1, IntPtr userParam)
        {
            //labelResult.Text = cbParam1.Result.ToString();
            string szResult = cbParam1.Result.ToString();

            if (LabelFinalizacaoSelecionado.InvokeRequired)
            {
                LabelFinalizacaoSelecionado.Invoke(new System.Windows.Forms.MethodInvoker(delegate()
                {
                    LabelFinalizacaoSelecionado.Text = szResult;
                }
                   ));

            }
            return 0;
        }

        public NBioAPI.Type.FIR_TEXTENCODE FIRDigital(short Dispositivo, PictureBox Pct, Label labelImgQuality, bool Infinito)
        {
            NBioAPI.Type.FIR MyFir;
            NBioAPI.Type.FIR_TEXTENCODE textFIR;
            Capture(Dispositivo, Pct, labelImgQuality, new Label(), TipoDedo.Anelar, TipoMao.Direita, out MyFir, out textFIR, Infinito);
            return textFIR;
        }

        public void Capture(short Dispositivo, PictureBox Pct, Label labelImgQuality, Label LblFinalizacaoSelecionado, TipoDedo Dedo, TipoMao Mao, out NBioAPI.Type.FIR MyFir, out NBioAPI.Type.FIR_TEXTENCODE textFIR, bool Infinito)
        {

            LabelQualidadeSelecionado = labelImgQuality;
            LabelFinalizacaoSelecionado = LblFinalizacaoSelecionado;

            m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.INVISIBLE;
            m_WinOption.Option2.FPForeColor[0] = Convert.ToByte("00", 16);
            m_WinOption.Option2.FPForeColor[1] = Convert.ToByte("00", 16);
            m_WinOption.Option2.FPForeColor[2] = Convert.ToByte("00", 16);
            m_WinOption.Option2.FPBackColor[0] = Convert.ToByte("FF", 16);
            m_WinOption.Option2.FPBackColor[1] = Convert.ToByte("FF", 16);
            m_WinOption.Option2.FPBackColor[2] = Convert.ToByte("FF", 16);


            m_WinOption.FingerWnd = (uint)Pct.Handle.ToInt32();


            // Callback funtion
            m_WinOption.CaptureCallBackInfo = new NBioAPI.Type.CALLBACK_INFO_0();
            m_WinOption.CaptureCallBackInfo.CallBackFunction = new NBioAPI.Type.WINDOW_CALLBACK_0(MyCaptureCallback);
            m_WinOption.FinishCallBackInfo = new NBioAPI.Type.CALLBACK_INFO_1();
            m_WinOption.FinishCallBackInfo.CallBackFunction = new NBioAPI.Type.WINDOW_CALLBACK_1(MyFinishCallback);


            // Select finger for enrollment
            if (Mao == Biometria.TipoMao.Direita)
            {
                m_WinOption.Option2.DisableFingerForEnroll[0] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[1] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[2] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[3] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[4] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[5] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[6] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[7] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[8] = (byte)NBioAPI.Type.TRUE;
                m_WinOption.Option2.DisableFingerForEnroll[9] = (byte)NBioAPI.Type.TRUE;

                switch (Dedo)
                {
                    case Biometria.TipoDedo.Anelar:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[3] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Indicador:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[1] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Médio:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[2] = (byte)NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Mínimo:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[4] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Polegar:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[0] = NBioAPI.Type.FALSE;
                            break;
                        }
                }
            }
            else
            {
                switch (Dedo)
                {

                    case Biometria.TipoDedo.Anelar:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[8] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Indicador:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[6] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Médio:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[7] = (byte)NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Mínimo:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[9] = NBioAPI.Type.FALSE;
                            break;
                        }
                    case Biometria.TipoDedo.Polegar:
                        {
                            m_WinOption.Option2.DisableFingerForEnroll[5] = NBioAPI.Type.FALSE;
                            break;
                        }
                }
            }

            NBioAPI.Type.HFIR hCapturedFIR;
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            if (Infinito)
            {
                m_NBioAPI.Capture(out hCapturedFIR, NBioAPI.Type.TIMEOUT.INFINITE, m_WinOption);
            }
            else
            {
                m_NBioAPI.Capture(out hCapturedFIR, NBioAPI.Type.TIMEOUT.DEFAULT, m_WinOption);                
            }
            try
            {
                m_NBioAPI.GetFIRFromHandle(hCapturedFIR, out MyFir);
                m_NBioAPI.GetTextFIRFromHandle(hCapturedFIR, out textFIR, true);
                m_NBioAPI.CloseDevice(Dispositivo);
            }
            catch (Exception ex)
            {
                textFIR = null;
                MyFir = null;
            }
        }

        public Boolean ComparaFIR(String Text1, String Text2)
        {
            bool retorno;
            uint ret;
            NBioAPI.Type.FIR_TEXTENCODE texto1 = new NBioAPI.Type.FIR_TEXTENCODE();
            texto1.TextFIR = Text1;
            NBioAPI.Type.FIR_TEXTENCODE texto2 = new NBioAPI.Type.FIR_TEXTENCODE();
            texto2.TextFIR = Text2;
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();
            ret = m_NBioAPI.VerifyMatch(texto1, texto2, out retorno, myPayload);
            return retorno;
        }
    }
}
