using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ACESSO.BIOMETRIA;
using NITGEN.SDK.NBioBSP;
using FTD2XX_NET;
using ACESSO.PONTOCONTROLE.Classes;
using System.Threading;

namespace ACESSO.PONTOCONTROLE
{
   public partial class FrmPrincipal : Form
   {
      private int CodigoPonto;
      private string Tipo;
      private int nTentativas = 0;
      private int MatTentou = 0;
      private int LimiteTentativaAcesso = 0;
      private int PortaTranca;
      private int PortaSirene;
      private CPonto.vw_EquipamentoPonto[] oListaEquipamentoPonto;
      private CPonto.PONTOCONTROLE oPonto;
      private bool SireneAcionada = false;
      private nseUSB2E2S usb;
      private string PortaSerial;
      private List<int> OrdemVerificaRandomico;
      private int NumeroDia = 0;
      private DateTime Dia = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
      private string NumeroEquipamento = "";

      NBioAPI.IndexSearch oIndexSearch;
      private NBioAPI m_NBioAPI;
      uint[] lista;

      public FrmPrincipal()
      {
         InitializeComponent();

         //************************************************
         //Carrega a placa USB para acionamento da porta
         usb = new nseUSB2E2S();
         lista = usb.getListLocIdPlacas();
         //************************************************
      }

      private void label6_Click(object sender, EventArgs e)
      {

      }

      private static string DownloadFile(string Arquivo, int Tipo)
      {
         //ServiceReference1.TransfereArquivosSoapClient ls1 = new ServiceReference1.TransfereArquivosSoapClient();
         CFoto.FotoClient oProxy = new CFoto.FotoClient();
         byte[] b1 = null;
         System.IO.FileStream fs1 = null;
         string ArquivoDownload = Application.StartupPath.ToString() + "\\Fotos\\" + Arquivo;
         b1 = oProxy.DownloadFile(Arquivo, Tipo);
         Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Fotos\\");
         fs1 = new FileStream(ArquivoDownload, FileMode.Create);
         fs1.Write(b1, 0, b1.Length);
         fs1.Close();
         fs1 = null;
         return ArquivoDownload;
      }

      private void MsgErro(uint ret)
      {
         LblMsg.Text = NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]";
      }

      private List<int> ListaRandomizada(int LimiteMaximo, int Quantidade)
      {
         if (Quantidade > LimiteMaximo)
         {
            throw new System.ArgumentException("O limite máximo não pode ser menor que a quantidade", "SiCAP");
         }
         int contador;
         List<int> Resultado = new List<int>();
         Random oRandom = new Random();
         for (contador = 1; contador < Quantidade + 1; contador++)
         {
            var resulta = oRandom.Next(1, LimiteMaximo);
            var res = from p in Resultado where p == resulta select p;
            if (res.Count() == 0)
            {
               Resultado.Add(resulta);
            }
            else
            {
               contador--;
            }
         }
         Resultado = (from p in Resultado orderby p select p).ToList();
         return Resultado;
      }

      private void FrmPrincipal_Load(object sender, EventArgs e)
      {
         
         Tipo = ACESSO.PONTOCONTROLE.Classes.Registro.Tipo();
         if (Tipo == null)
         {
            FrmConfigura oFrm = new FrmConfigura();
            oFrm.ShowDialog();
         }
         else
         {
            if (MessageBox.Show("Deseja configurar a estação? ", ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
               FrmConfigura oFrm = new FrmConfigura();
               oFrm.ShowDialog();
            }
         }
         try
         {
            PortaSirene = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSirene();
            PortaSerial = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSerial();
         }
         catch (Exception ex)
         {
            FrmConfigura oFrm = new FrmConfigura();
            oFrm.ShowDialog();
            PortaTranca = ACESSO.PONTOCONTROLE.Classes.Registro.PortaTranca();
            PortaSirene = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSirene();
            PortaSerial = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSerial();
         }

         CodigoPonto = ACESSO.PONTOCONTROLE.Classes.Registro.CodigoPonto();
         Tipo = ACESSO.PONTOCONTROLE.Classes.Registro.Tipo();
         CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
         oPonto = oProxy.SelecionaPKPontoControle(CodigoPonto, Tipo);
         if (Tipo == "E")
         {
            oListaEquipamentoPonto = oProxy.ListaEquipamentoPonto(CodigoPonto);
         }

         if (oListaEquipamentoPonto == null)
         {
            GbxEquipamento.Visible = false;
         }
         else
         {
            if (oListaEquipamentoPonto.Count() == 0)
            {
               GbxEquipamento.Visible = false;
            }
            else
            {
               int contador;


               //PERCORRE OS EQUIPAMENTOS, VERIFICANDO SE TEM OBRIGATÓRIOS E RANDÔMICOS.
               for (contador = 0; contador < oListaEquipamentoPonto.Count(); contador++)
               {
                  if (oListaEquipamentoPonto[contador].EPObrigatorio != null)
                  {
                     if ((bool)oListaEquipamentoPonto[contador].EPObrigatorio)
                     {
                        ChkEquipObrigatorio.Checked = true;
                     }
                  }
                  if (oPonto.PoQtdVerificaEquip != null)
                  {
                     if (oPonto.PoQtdVerificaEquip > 0)
                     {
                        if ((bool)oListaEquipamentoPonto[contador].EPObrigatorio == null)
                        {
                           ChkEquipRandomico.Checked = true;
                        }
                        else
                        {
                           if ((bool)oListaEquipamentoPonto[contador].EPObrigatorio == false)
                           {
                              ChkEquipRandomico.Checked = true;
                           }
                        }
                     }
                  }
               }
               //FIM DA VERIFICAÇÃO SE O PONTO DE CONTROLE POSSUI EQUIPAMENTOS ASSOCIADOS

               if (ChkEquipRandomico.Checked)
               {
                  OrdemVerificaRandomico = ListaRandomizada((int)oPonto.PoQtdMediaPessoas, (int)oPonto.PoQtdVerificaEquip);
               }

            }
         }

         ChkPoBiometria.Checked = oPonto.PoBiometria;
         ChkPoCartaoRFID.Checked = oPonto.PoCartaoRFID;
         ChkPoSenha.Checked = oPonto.PoSenha;
         LblIdentificacao.Text = oPonto.PoNome;
         if (oPonto.PoDisparaAlarme)
         {
            LimiteTentativaAcesso = (int)oPonto.PoTentativaIndevidaDisparaAlarme;
         }
         BtnLiberacaoForcada.Enabled = oPonto.PoPermiteLiberacaoForcada;

         SerialCartao.PortName = PortaSerial;

         if (ChkPoCartaoRFID.Checked)
         {
            //Abre a porta serial para receber o código do Cartão.                
            SerialCartao.PortName = PortaSerial;
            SerialCartao.Close();
            try
            {
               SerialCartao.Open();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Confirgure a porta serial do leitor de cartão (" + ex.Message + ").");
               FrmConfigura oFrm = new FrmConfigura();
               oFrm.ShowDialog();

               PortaSerial = ACESSO.PONTOCONTROLE.Classes.Registro.PortaSerial();
               SerialCartao.PortName = PortaSerial;
               SerialCartao.Open();
            }
            SerialCartao.DiscardOutBuffer();
            SerialCartao.DiscardInBuffer();
            TimeCartao.Enabled = true;
         }
         else
         {
            m_NBioAPI = new NBioAPI();
            uint ret;
            oIndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
            ret = oIndexSearch.InitEngine();
            if (ret != NBioAPI.Error.NONE)
            {
               MsgErro(ret);
            }
            oIndexSearch.ClearDB();
            CPonto.HASHDIGITAL[] Lista = oProxy.ListaHash();
            foreach (CPonto.HASHDIGITAL oHash in Lista)
            {
               NBioAPI.Type.FIR_TEXTENCODE oFir = new NBioAPI.Type.FIR_TEXTENCODE();
               oFir.TextFIR = oHash.HaCredencialBiometricaTextual;
               NBioAPI.IndexSearch.FP_INFO[] oInfo;
               oIndexSearch.AddFIR(oFir, uint.Parse(oHash.HaCodigoUsuario.ToString()), out oInfo);
            }
            TimeSemCartao.Enabled = true;
         }
         oProxy.Close();

      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         timer1.Enabled = false;
         if (!SireneAcionada)
         {
            PicFoto.Image = null;
            timer1.Enabled = false;
            PctDigital.Image = null;
            PctVerde.Visible = false;
            PctVermelho.Visible = false;
            PctAmarelo.Visible = false;
            PctSemSinal.Visible = true;
            LblMsg.Text = "";
            LblUsuario.Text = "";
            LblDataHora.Text = "";
            usb.executaComando(lista[0], Tipos.Desliga, Codigos.DesLigaRele1);
            usb.executaComando(lista[0], Tipos.Desliga, Codigos.DesLigaRele2);
            usb.executaComando(lista[0], Tipos.Desliga, Codigos.DesLigaRele3);
            usb.executaComando(lista[0], Tipos.Desliga, Codigos.DesLigaRele4);
            if (oPonto.PoBiometria && oPonto.PoCartaoRFID == false)
            {
               TimeSemCartao.Enabled = true;
            }
            else if (oPonto.PoCartaoRFID)
            {
               SerialCartao.Open();
               SerialCartao.DiscardInBuffer();
               SerialCartao.DiscardOutBuffer();
               TimeCartao.Enabled = true;
            }
         }
      }

      private void PicFoto_Click(object sender, EventArgs e)
      {

      }

      private void BtnTestaDownload_Click(object sender, EventArgs e)
      {
         PicFoto.ImageLocation = DownloadFile("00000001.jpg", 0);

         timer1.Enabled = true;
      }

      private bool AcessoBiometrico(out int CodigoUsuario, CPonto.CPontoClient oProxy, bool Infinito)
      {
         Biometria Bio = new Biometria();
         NBioAPI.Type.FIR_TEXTENCODE oFirCapture = Bio.FIRDigital(0, PctDigital, LblQualidade, Infinito);
         NBioAPI.IndexSearch.FP_INFO oInfoCompare;
         NBioAPI.IndexSearch.CALLBACK_INFO_0 CallBackInfo = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
         uint ret;
         ret = oIndexSearch.IdentifyData(oFirCapture,  5, out oInfoCompare, CallBackInfo);
         if (ret != NBioAPI.Error.NONE)
         {
            MsgErro(ret);
            CodigoUsuario = 0;
            return false;
         }
         
          int UID = (int)oInfoCompare.ID;
         CodigoUsuario = UID;
         CPonto.HASHDIGITAL oHash = oProxy.SelecionaHash(UID);
         if (oHash == null)
         {
            CodigoUsuario = 0;
            return false;
         }
         CodigoUsuario = oHash.HaCodigoUsuario;
         return true;

      }

      private void CarregaDadosUsuario(int Codigo, CPonto.CPontoClient oProxy, out CPonto.USUARIO oUsuario)
      {
         oUsuario = oProxy.SelecionaUsuario(Codigo);
         string strCodigo;
         if (oUsuario.USTIPO == char.Parse("T"))
         {
            //Terceirizado
            CPonto.TERCEIRO oTerceiro = oProxy.SelecionaTerceiro((int)oUsuario.USCODIGOTERCEIRO);
            strCodigo = oTerceiro.TeCodigo.ToString("00000000");
            LblUsuario.Text = strCodigo + " - " + oTerceiro.TeNome;
            PicFoto.ImageLocation = DownloadFile(strCodigo + ".jpg", 1);
         }
         else if (oUsuario.USTIPO == char.Parse("E"))
         {
            //Empregado
            CPonto.FUNCIONARIO oFuncionario = oProxy.SelecionaFuncionario((int)oUsuario.USMATFUNC);
            strCodigo = oFuncionario.FUMATFUNC.ToString("00000000");
            LblUsuario.Text = strCodigo + " - " + oFuncionario.FUNOMFUNC;
            PicFoto.ImageLocation = DownloadFile(strCodigo + ".jpg", 0);

         }
         else if (oUsuario.USTIPO == char.Parse("S"))
         {
            //Estagiário
            CPonto.ESTAGIARIO oEstagiario = oProxy.SelecionaEstagiario((int)oUsuario.USCODIGOESTAGIARIO);
            strCodigo = oEstagiario.ESCodigo.ToString("00000000");
            LblUsuario.Text = strCodigo + " - " + oEstagiario.ESNome;
            PicFoto.ImageLocation = DownloadFile(strCodigo + ".jpg", 0);
         }
         else if (oUsuario.USTIPO == char.Parse("V"))
         {
            //Visitante
            CPonto.VISITANTE oVisitante = oProxy.SelecionaVisitante((int)oUsuario.USCODIGOVISITANTE);
            strCodigo = oVisitante.ViCodigo.ToString("00000000");
            LblUsuario.Text = strCodigo + " - " + oVisitante.ViNome;
            PicFoto.ImageLocation = DownloadFile(strCodigo + ".jpg", 2);
         }
      }

      private void RegistrarAcesso(CPonto.CPontoClient oProxy, int CodigoCartao, int CodigoUsuario, DateTime DataAcesso, bool Negado)
      {
         CPonto.ACESSOPONTOCONTROLE oAcesso = new CPonto.ACESSOPONTOCONTROLE();
         oAcesso.APAcessoForcado = false;
         oAcesso.APCodigoPontoControle = CodigoPonto;
         oAcesso.APTipoPontoControle = char.Parse(Tipo);
         if (CodigoCartao > 0)
            oAcesso.APCodigoCartao = CodigoCartao;
         else
            oAcesso.APCodigoCartao = null;
         oAcesso.APCodigoUsuarioInterrompeAlarme = null;
         oAcesso.APCodigoUsuarioLiberaForcado = null;
         oAcesso.APCodigoUsuarioAcesso = CodigoUsuario;
         oAcesso.APDataAcesso = DataAcesso;
         oAcesso.APNegado = Negado;
         oProxy.IncluirAcesso(oAcesso);
      }

      private void AcionaSirene()
      {
         if (PortaSirene == 1)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele1);
         }
         else if (PortaSirene == 2)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele2);
         }
         else if (PortaSirene == 3)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele3);
         }
         else if (PortaSirene == 4)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele4);
         }
         SireneAcionada = true;
         BtnLiberacaoForcada.Enabled = false;
         BtnDestravarSirene.Enabled = true;
      }

      private void AcionaTranca()
      {
         if (PortaTranca == 1)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele1);
         }
         else if (PortaTranca == 2)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele2);
         }
         else if (PortaTranca == 3)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele3);
         }
         else if (PortaTranca == 4)
         {
            usb.executaComando(lista[0], Tipos.Liga, Codigos.LigaRele4);
         }
      }

      private void Delay(int ms)
      {
         int time = Environment.TickCount;
         while (true)
         {
            Application.DoEvents();
            if (Environment.TickCount - time >= ms)
               return;
         }
      }


      private bool VerificaEquipamentos(CPonto.CPontoClient oProxy, CPonto.USUARIO oUsuario)
      {
         NumeroEquipamento = "";
         string TAGEQUIPAMENTO = "";
         bool ConseguiuLer = false;

         if (ChkEquipObrigatorio.Checked)
         {

            var oListaObrigatorio = from p in oListaEquipamentoPonto where p.EPObrigatorio == true select p;
            foreach (CPonto.vw_EquipamentoPonto oEquipamento in oListaObrigatorio)
            {
               //Caso a unidade não exija autenticação via crachá, solicitará os equipamentos de segurança
               //mas, para isso, precisa abrir a serial e fechar              
               SerialCartao.Open();

               LblMsg.Text = "Passe o equipamento " + oEquipamento.TEDescricao + " no leitor RFID. ";
               this.Refresh();
               
               //O Delay será de 100 milissegundos para ver se a porta seria tem algo.
               //com 100 voltas, o sistema aguardará 10 segundos para a leitura do equipamento, senão, dará como leitura inválida e encerrará o processo.
               ConseguiuLer = false;
               for (int i = 0; i < 100; i++)
               {
                  Delay(100);
                  if (SerialCartao.BytesToRead > 9)
                  {
                     TAGEQUIPAMENTO = SerialCartao.ReadExisting().ToString().Substring(3, 5);
                     ConseguiuLer = true;
                     break;
                  }
               }

               //Caso não tenha conseguido ler o equipamento, o retorno será falso
               if (ConseguiuLer == false)
               {
                  LblMsg.Text = "Equipamento " + oEquipamento.TEDescricao + " não informado.";
                  this.Refresh();
                  SerialCartao.Close();
                  return false;
               }
               else
               {
                  var Equipamento = oProxy.ListaEquipamentoUsuarioTAG(oUsuario.USCODIGO, TAGEQUIPAMENTO);
                  if (Equipamento == null)
                  {
                     LblMsg.Text = "O equipamento informado não corresponde a um " + oEquipamento.TEDescricao + " relacionado com o usuário. ";
                     this.Refresh();
                     SerialCartao.Close();
                     return false;
                  }
               }
               SerialCartao.Close();
            }

         }
         if (ChkEquipRandomico.Checked)
         {
            var res = from p in OrdemVerificaRandomico where p == NumeroDia select p;
            if (res.Count() > 0)
            {
               var oListaRandomico = from p in oListaEquipamentoPonto where p.EPObrigatorio == false select p;
               foreach (CPonto.vw_EquipamentoPonto oEquipamento in oListaRandomico)
               {
                  //Caso a unidade não exija autenticação via crachá, solicitará os equipamentos de segurança
                  //mas, para isso, precisa abrir a serial e fechar                  
                  SerialCartao.Open();
                  //******************************************************************************************
                  LblMsg.Text = "Você foi sorteado para passar os equipamentos pela ordem de acesso. Passe o equipamento " + oEquipamento.TEDescricao + " no leitor RFID. ";
                  this.Refresh();

                  //O Delay será de 100 milissegundos para ver se a porta seria tem algo.
                  //com 100 voltas, o sistema aguardará 10 segundos para a leitura do equipamento, senão, dará como leitura inválida e encerrará o processo.
                  ConseguiuLer = false;
                  for (int i = 0; i < 100; i++)
                  {
                     Delay(100);
                     if (SerialCartao.BytesToRead > 0)
                     {
                        TAGEQUIPAMENTO = SerialCartao.ReadExisting().ToString().Substring(3, 5);
                        ConseguiuLer = true;
                        break;
                     }
                  }

                  //Caso não tenha conseguido ler o equipamento, o retorno será falso
                  if (ConseguiuLer == false)
                  {
                     LblMsg.Text = "Equipamento " + oEquipamento.TEDescricao + " não informado.";
                     this.Refresh();
                     SerialCartao.Close();
                     return false;
                  }
                  else
                  {
                     var Equipamento = oProxy.ListaEquipamentoUsuarioTAG(oUsuario.USCODIGO, TAGEQUIPAMENTO);
                     if (Equipamento == null)
                     {
                        LblMsg.Text = "O equipamento informado não corresponde a um " + oEquipamento.TEDescricao + " relacionado com o usuário. ";
                        this.Refresh();
                        SerialCartao.Close();
                        return false;
                     }
                  }
                  SerialCartao.Close();
               }
            }

         }
         LblMsg.Text = "";
         this.Refresh();
         return true;
      }

      private void ComandoTimeSemCartao()
      {
         int CodigoUsuario;
         CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
         CPonto.USUARIO oUsuario = null;
         string MsgAdicional = "";
         bool PossuiAcesso = false;
         LblMsg.Text = "Coloque o dedo cadastrado no leitor biométrico da impressão digital.";
         this.Refresh();
         //return;
         if (AcessoBiometrico(out CodigoUsuario, oProxy, true))
         {
            LblMsg.Text = "";
            this.Refresh();
            if (ChkPoSenha.Checked)
            {
               FrmAutenticaRede oFrm = new FrmAutenticaRede(CodigoUsuario.ToString());
               oFrm.ShowDialog();
               if (oFrm.Autenticado)
               {
                  try
                  {
                     PossuiAcesso = oProxy.PossuiPermissaoPonto(CodigoUsuario, CodigoPonto);
                  }
                  catch (Exception Ex)
                  {
                     MsgAdicional = Ex.Message;
                  }
                  if (PossuiAcesso)
                  {
                     //Registrar que o acesso foi autorizado e acionar a porta elétrica para liberação
                     LblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                     PctSemSinal.Visible = false;
                     PctVerde.Visible = true;
                     RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, false);
                     CarregaDadosUsuario(CodigoUsuario, oProxy, out oUsuario);
                     AcionaTranca();
                  }
                  else
                  {
                     RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, true);
                     if (MatTentou != CodigoUsuario)
                        nTentativas = 1;
                     else
                        nTentativas += 1;

                     if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                     {
                        AcionaSirene();
                     }
                     MatTentou = CodigoUsuario;
                     LblMsg.Text = "O usuário USR não possui acesso ao ponto de controle PCAP_S. Entrar em contato com o departamento de segurança patrimonial." + MsgAdicional + ".";

                     //Registrar a tentativa inválida de sucesso e incrementar o sinal da sirene, caso tenha
                  }

               }
               else
               {
                  RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, true);
                  if (MatTentou != CodigoUsuario)
                     nTentativas = 1;
                  else
                     nTentativas += 1;

                  if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                  {
                     AcionaSirene();
                  }
                  MatTentou = CodigoUsuario;
                  LblMsg.Text = "Usuário ou senha inválido! Entrar em contato com a segurança patrimonial.";
               }
            }
            else
            {
               try
               {
                  PossuiAcesso = oProxy.PossuiPermissaoPonto(CodigoUsuario, CodigoPonto);
               }
               catch (Exception Ex)
               {
                  MsgAdicional = Ex.Message;
               }

               if (PossuiAcesso)
               {
                  if (oUsuario == null)
                  {
                     oUsuario = oProxy.SelecionaUsuario(CodigoUsuario);
                  }

                  NumeroDia += 1;

                  if (VerificaEquipamentos(oProxy, oUsuario) == false)
                  {
                     RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, true);
                     if (MatTentou != CodigoUsuario)
                        nTentativas = 1;
                     else
                        nTentativas += 1;

                     if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                     {
                        AcionaSirene();
                     }
                     MatTentou = CodigoUsuario;
                     return;
                  }
                  else
                  {
                     //Registrar que o acesso foi autorizado e acionar a porta elétrica para liberação
                     LblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                     PctSemSinal.Visible = false;
                     PctVerde.Visible = true;
                     RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, false);
                     CarregaDadosUsuario(CodigoUsuario, oProxy, out oUsuario);
                     AcionaTranca();
                  }
               }
               else
               {
                  RegistrarAcesso(oProxy, 0, CodigoUsuario, DateTime.Now, true);
                  if (MatTentou != CodigoUsuario)
                     nTentativas = 1;
                  else
                     nTentativas += 1;

                  if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                  {
                     AcionaSirene();
                  }
                  MatTentou = CodigoUsuario;
                  LblMsg.Text = "O usuário USR não possui acesso ao ponto de controle PCAP_S. Entrar em contato com o departamento de segurança patrimonial.";
               }

            }
         }
         else
         {            
            nTentativas += 1;
            if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
            {
               AcionaSirene();
            }
            if (CodigoUsuario == 0)
            {
               LblMsg.Text = "Não foi possível identificar o usuário USR. Entrar em contato com o departamento de segurança patrimonial.";
            }
            else
            {
               LblMsg.Text = "O usuário USR não possui acesso ao ponto de controle PCAP_S. Entrar em contato com o departamento de segurança patrimonial.";
            }            
         }
         oProxy.Close();
         timer1.Enabled = true;
      }

      private void TimeSemCartao_Tick(object sender, EventArgs e)
      {
         TimeSemCartao.Enabled = false;
         ComandoTimeSemCartao();
      }

      private void BtnLiberacaoForcada_Click(object sender, EventArgs e)
      {
         FrmAutenticaRede oFrm = new FrmAutenticaRede();
         bool Autenticado = false;
         CPonto.USUARIO oUsuario;

         if (ChkPoSenha.Checked == true)
         {
            oFrm.ShowDialog();
         }
         if (oFrm.Autenticado || Autenticado)
         {
            oUsuario = oFrm.Usuario;
            if ((bool)oUsuario.USAdministrador || (bool)oUsuario.USSeguranca)
            {
               //programar para liberar a porta de forma forçada
               FrmLiberaForcado oFrmLF = new FrmLiberaForcado(oUsuario.USCODIGO, CodigoPonto, char.Parse(Tipo));
               timer1.Enabled = false;
               oFrmLF.ShowDialog();
               if (oFrmLF.Libera)
               {
                  //Registrar que o acesso foi autorizado e acionar a porta elétrica para liberação
                  LblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                  PctSemSinal.Visible = false;
                  PctVerde.Visible = true;
                  CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
                  CarregaDadosUsuario(oUsuario.USCODIGO, oProxy, out oUsuario);
                  oProxy.Close();
                  AcionaTranca();
                  if (oPonto.PoCartaoRFID)
                  {
                     SerialCartao.Close();
                  }
               }
               timer1.Enabled = true;
            }
            else
            {
               MessageBox.Show("Esse usuário não está habilitado a liberar um acesso de forma forçada.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
      }

      private void BtnDestravarSirene_Click(object sender, EventArgs e)
      {
         FrmAutenticaRede oFrm = new FrmAutenticaRede();
         bool Autenticado = false;
         if (ChkPoSenha.Checked)
         {
            oFrm.ShowDialog();
         }
         if (oFrm.Autenticado || Autenticado)
         {
            var oUsuario = oFrm.Usuario;
            if ((bool)oUsuario.USAdministrador || (bool)oUsuario.USSeguranca)
            {
               SireneAcionada = false;
               BtnLiberacaoForcada.Enabled = oPonto.PoPermiteLiberacaoForcada;
               BtnDestravarSirene.Enabled = false;
               timer1_Tick(sender, e);
            }
            else
            {
               MessageBox.Show("Esse usuário não está habilitado a desligar a sirene.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
         else
         {
            MessageBox.Show("Autenticação inválida.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void MnuDesligar_Click(object sender, EventArgs e)
      {
         FrmAutenticaRede oFrm = new FrmAutenticaRede();
         oFrm.ShowDialog();
         if (oFrm.Autenticado)
         {
            var oUsuario = oFrm.Usuario;
            if ((bool)oUsuario.USAdministrador)
            {
               this.Close();
            }
         }

      }

      private void MnuConfigurar_Click(object sender, EventArgs e)
      {
         FrmAutenticaRede oFrm = new FrmAutenticaRede();
         oFrm.ShowDialog();
         if (oFrm.Autenticado)
         {
            var oUsuario = oFrm.Usuario;
            if ((bool)oUsuario.USAdministrador)
            {
               FrmConfigura ofrm = new FrmConfigura();
               ofrm.ShowDialog();
            }
         }
      }

      private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
      {
         if (oPonto.PoCartaoRFID)
         {
            //Fecha a porta serial para receber o código do Cartão.                
            SerialCartao.Close();
            TimeCartao.Enabled = false;
         }
      }

      private void TimeCartao_Tick(object sender, EventArgs e)
      {
         string MsgAdicional = "";
         if (SerialCartao.IsOpen == false)
         {
            SerialCartao.Open();
         }

         LblMsg.Text = "Passe o cartão de identificação CId_S no leitor";
         this.Refresh();

         if (SerialCartao.BytesToRead > 0)
         {
            TimeCartao.Enabled = false;
            string NumeroCartao = SerialCartao.ReadExisting().ToString().Substring(3, 5);
            SerialCartao.Close(); //Fecha a porta para não receber mais nada.                
            CPonto.CPontoClient oProxy = new CPonto.CPontoClient();
            CPonto.CARTAO oCartao;
            CPonto.USUARIO oUsuario = null;
            CPonto.CARTAOUSUARIO oCartaoUsuario;
            int CodigoUsuario;
            oCartao = oProxy.SelecionaCartao(out oCartaoUsuario, NumeroCartao);
            bool PossuiAcesso = false;
            if (oCartao == null)
            {
               nTentativas += 1;
               if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
               {
                  AcionaSirene();
               }
               LblMsg.Text = "Cartão de identificação CId_S inválido ou não cadastrado no sistema. Entrar em contato com o departamento de Segurança Patrimonial.";
            }
            else
            {
               if ((bool)oCartao.CrBloqueado)
               {
                  if (MatTentou != oCartaoUsuario.CSCodigoUsuario)
                     nTentativas = 1;
                  else
                     nTentativas += 1;
                  if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                  {
                     AcionaSirene();
                  }
                  CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                  LblMsg.Text = "O cartão de identificação do usuário foi bloqueado pelo motivo: " + oCartao.CrMotivoBloqueio + ".";
               }
               else
               {

                  try
                  {
                     PossuiAcesso = oProxy.PossuiPermissaoPonto(oCartaoUsuario.CSCodigoUsuario, CodigoPonto);
                  }
                  catch (Exception ex)
                  {
                     PossuiAcesso = false;
                     MsgAdicional = ex.Message;
                  }

                  if (PossuiAcesso)
                  {
                     if (oPonto.PoBiometria)
                     {
                        LblMsg.Text = "Coloque o dedo cadastrado no leitor biométrico da impressão digital.";
                        this.Refresh();
                        //Implementar o acesso biométrico
                        CPonto.HASHDIGITAL[] oListaHash = oProxy.SelecionaHashUsuario(oCartaoUsuario.CSCodigoUsuario);
                        m_NBioAPI = new NBioAPI();
                        uint ret;
                        oIndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
                        ret = oIndexSearch.InitEngine();
                        if (ret != NBioAPI.Error.NONE)
                        {
                           MsgErro(ret);
                        }
                        oIndexSearch.ClearDB();
                        foreach (CPonto.HASHDIGITAL oHash in oListaHash)
                        {
                           NBioAPI.Type.FIR_TEXTENCODE oFir = new NBioAPI.Type.FIR_TEXTENCODE();
                           oFir.TextFIR = oHash.HaCredencialBiometricaTextual;
                           NBioAPI.IndexSearch.FP_INFO[] oInfo;
                           oIndexSearch.AddFIR(oFir, uint.Parse(oHash.HaCodigo.ToString()), out oInfo);
                        }

                        if (AcessoBiometrico(out CodigoUsuario, oProxy, false))
                        {
                           PossuiAcesso = true;
                        }
                        else
                        {
                           PossuiAcesso = false;
                        }
                     }
                     if (oPonto.PoSenha)
                     {
                        //Acesso via senha de rede.

                        FrmAutenticaRede oFrm = new FrmAutenticaRede();
                        oFrm.ShowDialog();
                        if (oFrm.Autenticado)
                        {
                           oUsuario = oFrm.Usuario;
                           if (oUsuario.USCODIGO != oCartaoUsuario.CSCodigoUsuario)
                           {
                              PossuiAcesso = false;
                              RegistrarAcesso(oProxy, oCartaoUsuario.CSCODIGO, oUsuario.USCODIGO, DateTime.Parse(LblDataHora.Text), true);
                              if (MatTentou != oUsuario.USCODIGO)
                                 nTentativas = 1;
                              else
                                 nTentativas += 1;
                              if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                              {
                                 AcionaSirene();
                              }
                              MatTentou = oUsuario.USCODIGO;
                              CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                              LblMsg.Text = "O usuário que se autenticou é diferente do usuário a qual pertence o crachá.";
                           }
                        }
                        else
                        {
                           PossuiAcesso = false;
                        }
                     }

                     if (oUsuario == null)
                     {
                        oUsuario = oProxy.SelecionaUsuario(oCartaoUsuario.CSCodigoUsuario);
                     }

                     NumeroDia += 1;
                     if (VerificaEquipamentos(oProxy, oUsuario) == false)
                     {
                        CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                        RegistrarAcesso(oProxy, oCartaoUsuario.CSCODIGO, oCartaoUsuario.CSCodigoUsuario, DateTime.Now, true);
                        if (MatTentou != oCartaoUsuario.CSCodigoUsuario)
                           nTentativas = 1;
                        else
                           nTentativas += 1;
                        if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                        {
                           AcionaSirene();
                        }
                        MatTentou = oCartaoUsuario.CSCodigoUsuario;
                        timer1.Enabled = true;
                        return;
                     }
                     else
                     {
                        PossuiAcesso = true;
                     }

                     if (PossuiAcesso)
                     {
                        //Registrar que o acesso foi autorizado e acionar a porta elétrica para liberação
                        LblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        PctSemSinal.Visible = false;
                        PctVerde.Visible = true;
                        RegistrarAcesso(oProxy, oCartaoUsuario.CSCODIGO, oCartaoUsuario.CSCodigoUsuario, DateTime.Parse(LblDataHora.Text), false);
                        CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                        AcionaTranca();
                     }
                     else
                     {
                        CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                        RegistrarAcesso(oProxy, oCartaoUsuario.CSCODIGO, oCartaoUsuario.CSCodigoUsuario, DateTime.Parse(LblDataHora.Text), true);
                        if (MatTentou != oCartaoUsuario.CSCodigoUsuario)
                           nTentativas = 1;
                        else
                           nTentativas += 1;
                        if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                        {
                           AcionaSirene();
                        }
                        MatTentou = oCartaoUsuario.CSCodigoUsuario;
                        LblMsg.Text = "O Acesso não foi autorizado.";
                     }
                  }
                  else
                  {
                     CarregaDadosUsuario(oCartaoUsuario.CSCodigoUsuario, oProxy, out oUsuario);
                     RegistrarAcesso(oProxy, oCartaoUsuario.CSCODIGO, oCartaoUsuario.CSCodigoUsuario, DateTime.Now, true);
                     if (MatTentou != oCartaoUsuario.CSCodigoUsuario)
                        nTentativas = 1;
                     else
                        nTentativas += 1;

                     if (LimiteTentativaAcesso > 0 && nTentativas > LimiteTentativaAcesso)
                     {
                        AcionaSirene();
                     }
                     MatTentou = oCartaoUsuario.CSCodigoUsuario;
                     LblMsg.Text = "O Usuário não possui acesso ao ponto de controle PCAP_S. Entrar em contato com a segurança patrimonial." + MsgAdicional + ".";
                  }
               }
            }
            oProxy.Close();

            //Libera o timer que limpa os dados e habilita novamente a leitura ou entaõ, libera o timer do cartao;
            timer1.Enabled = true;
            if (PossuiAcesso)
            {
               PctVerde.Visible = true;
               PctVermelho.Visible = false;
               PctAmarelo.Visible = false;
               PctSemSinal.Visible = false;
            }
            else
            {
               PctVerde.Visible = false;
               PctVermelho.Visible = true;
               PctAmarelo.Visible = false;
               PctSemSinal.Visible = false;
            }
         }
      }

      private void BtnConfigurar_Click(object sender, EventArgs e)
      {
         FrmAutenticaRede oFrm = new FrmAutenticaRede();
         bool Autenticado = false;
         if (ChkPoSenha.Checked)
         {
            oFrm.ShowDialog();
         }
         if (oFrm.Autenticado || Autenticado)
         {

            var oUsuario = oFrm.Usuario;
            if ((bool)oUsuario.USAdministrador)
            {
               FrmConfigura ofrm = new FrmConfigura();
               ofrm.ShowDialog();
            }
         }
      }


   }
}
