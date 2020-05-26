using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACESSO.BIOMETRIA;

namespace ACESSO.ADMINISTRATIVO
{
    public partial class FrmUsuario : Form
    {
        private bool Novo = true;
        private bool NovoCartao = true;
        private bool NovaRota = true;
        private bool NovoEquipamento = true;
        private int CSCODIGO = 0;
        private int RUCodigo = 0;
        private int EUSCodigo = 0;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            validador2.LimpaControles();
            validador3.LimpaControles();
            validador4.LimpaControles();
            validador5.LimpaControles();
            tabControl1.SelectedIndex = 0;
            BtnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnCancela.Enabled = true;
            BtnAlterar.Enabled = false;
            tabControl1.Enabled = false;
            GrdCartao.DataSource = null;
            GrdDigitais.DataSource = null;
            GrdRota.DataSource = null;
            Novo = true;
            validador1.HabilitaControles(true);
            CboUSTipo.Enabled = false;
            TxtUsuario.Enabled = true;
            TxtUsuario.Focus();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
            validador2.LimpaControles();
            validador3.LimpaControles();
            validador4.LimpaControles();
            BtnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancela.Enabled = false;
            BtnAlterar.Enabled = false;
            tabControl1.Enabled = false;
            GrdCartao.DataSource = null;
            GrdDigitais.DataSource = null;
            GrdRota.DataSource = null;
            Novo = true;
            CboUSTipo.Enabled = true;
            CboUSTipo.Focus();
            TxtUsuario.Enabled = true;
            validador1.HabilitaControles(true);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            BtnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnCancela.Enabled = true;
            BtnAlterar.Enabled = false;
            tabControl1.Enabled = false;
            validador1.HabilitaControles(true);
            Novo = false;
            CboUSTipo.Enabled = false;
            TxtUsuario.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void CboUSTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
            TxtUSUSUARIOREDE.Enabled = true;
            TxtUsuario.Text = "";
            LblUsuario.Text = "";
            TxtUsuario.Focus();
        }

        private void CarregaGrids()
        {
            CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
            CarregaGridCartao(oProxy);
            CarregaRota(oProxy);
            CarregarDigitais(oProxy);
            CarregaGridEPI(oProxy);
        }

        private void CarregaGrids(CUsuario.CUsuarioClient oProxy)
        {
            CarregaGridCartao(oProxy);
            CarregaRota(oProxy);
            CarregarDigitais(oProxy);
            CarregaGridEPI(oProxy);
        }

        private void CarregarDigitais(CUsuario.CUsuarioClient oProxy)
        {
            GrdDigitais.AutoGenerateColumns = false;
            GrdDigitais.DataSource = oProxy.ListarDigitalUsuario(int.Parse(TxtUSCodigo.Text));
        }

        private void CarregaRota(CUsuario.CUsuarioClient oProxy)
        {
            GrdRota.AutoGenerateColumns = false;
            GrdRota.DataSource = oProxy.ListarRotaUsuario(TipoUsuario(), int.Parse(TxtUsuario.Text));
        }

        private void CarregaGridCartao(CUsuario.CUsuarioClient oProxy)
        {
            GrdCartao.AutoGenerateColumns = false;
            GrdCartao.DataSource = oProxy.ListarCartaoUsuario(TipoUsuario(), int.Parse(TxtUsuario.Text));
        }


        private char TipoUsuario()
        {
            switch (CboUSTipo.SelectedIndex)
            {
                //E=EMPREGADO;S=ESTAGIÁRIO;T=TERCEIRO;V=VISITANTE
                case 0:
                    {
                        //CONTRATADO
                        return char.Parse("T");
                    }
                case 1:
                    {
                        //EMPREGADO
                        return char.Parse("E");
                    }

                case 2:
                    {
                        //ESTAGIÁRIO
                        return char.Parse("S");
                    }
                case 3:
                    {
                        //VISITANTE
                        return char.Parse("V");
                    }
                default:
                    {
                        return char.Parse("X");
                    }
            }
        }

        private void CarregaComboEquipamentoEPI(CUsuario.CUsuarioClient oProxy)
        {
            var Retorno = oProxy.ListarTodosEquipamentosNaoDistribuidos();
            CboEquipamentoEPI.ValueMember = "EqCodigo";
            CboEquipamentoEPI.DisplayMember = "EqTagRFID";
            CboEquipamentoEPI.DataSource = Retorno;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
            CboRUCodigoRota.ValueMember = "ROCodigo";
            CboRUCodigoRota.DisplayMember = "RONome";
            CboRUCodigoRota.DataSource = oProxy.ListarRota();


            //CboEquipamento.ValueMember = "EqCodigo";
            //CboEquipamento.DataSource = oProxy.ListarEquipamento();
            //CboEquipamento.DisplayMember = "EqTagRFID";

            CarregaComboEquipamentoEPI(oProxy);

            oProxy.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se confirmar, será impossível recuperar o registro. Deseja excluir o usuário? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                try
                {
                    CUsuario.USUARIO oUsuario = oProxy.SelecionaUsuario(TipoUsuario(), int.Parse(TxtUsuario.Text));
                    oProxy.Excluir(oUsuario);
                    BtnCancela_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validador1.isValid())
            {
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                CUsuario.USUARIO oUsuario = new CUsuario.USUARIO();
                oUsuario.USUSUARIOREDE = TxtUSUSUARIOREDE.Text;
                oUsuario.USAdministrador = ChkUSAdministrador.Checked;
                oUsuario.USAuditor = ChkUSAuditor.Checked;
                oUsuario.USBloqueado = ChkUSBloqueado.Checked;
                if (ChkUSBloqueado.Checked)
                    oUsuario.USMotivoBloqueio = TxtUSMotivoBloqueio.Text;
                else
                    oUsuario.USMotivoBloqueio = null;
                oUsuario.USSeguranca = ChkUSSeguranca.Checked;
                oUsuario.USTIPO = TipoUsuario();
                if (oUsuario.USTIPO == char.Parse("E"))
                {
                    oUsuario.USMATFUNC = int.Parse(TxtUsuario.Text);
                    oUsuario.USCODIGOESTAGIARIO = null;
                    oUsuario.USCODIGOTERCEIRO = null;
                    oUsuario.USCODIGOVISITANTE = null;
                }
                else if (oUsuario.USTIPO == char.Parse("S"))
                {
                    oUsuario.USMATFUNC = null;
                    oUsuario.USCODIGOESTAGIARIO = int.Parse(TxtUsuario.Text);
                    oUsuario.USCODIGOTERCEIRO = null;
                    oUsuario.USCODIGOVISITANTE = null;
                }
                else if (oUsuario.USTIPO == char.Parse("T"))
                {
                    oUsuario.USMATFUNC = null;
                    oUsuario.USCODIGOESTAGIARIO = null;
                    oUsuario.USCODIGOTERCEIRO = int.Parse(TxtUsuario.Text);
                    oUsuario.USCODIGOVISITANTE = null;
                }
                else if (oUsuario.USTIPO == char.Parse("V"))
                {
                    oUsuario.USMATFUNC = null;
                    oUsuario.USCODIGOESTAGIARIO = null;
                    oUsuario.USCODIGOTERCEIRO = null;
                    oUsuario.USCODIGOVISITANTE = int.Parse(TxtUsuario.Text);
                }
                else
                {
                    MessageBox.Show("Tipo de usuario desconhecido. Favor selecionar o tipo novamente.", ProductName);
                }

                if (Novo)
                {
                    TxtUSCodigo.Text = oProxy.Incluir(oUsuario).ToString();
                }
                else
                {
                    oUsuario.USCODIGO = int.Parse(TxtUSCodigo.Text);
                    oProxy.Alterar(oUsuario);
                }
                validador1.HabilitaControles(false);
                BtnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                BtnCancela.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                tabControl1.Enabled = true;
                CarregaGrids(oProxy);
            }
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).controleToolStripMenuItem.Enabled = true;
        }

        private void btnSalvarCartao_Click(object sender, EventArgs e)
        {
            if (validador2.isValid())
            {
                if (CboCrCodigo.SelectedIndex == -1)
                {
                    MessageBox.Show("É obrigatório selecionar um cartão para adicionar.", ProductName);
                    CboCrCodigo.Focus();
                    return;
                }
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();


                CUsuario.CARTAO oVerifica;
                oVerifica = oProxy.SelecionaCartao((int)CboCrCodigo.SelectedValue);
                if (oVerifica == null)
                {
                    MessageBox.Show("Informe um cartão válido.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CboCrCodigo.Focus();
                    return;
                }

                CUsuario.CARTAOUSUARIO oCartao = new CUsuario.CARTAOUSUARIO();
                oCartao.CSCodigoCartao = (int)CboCrCodigo.SelectedValue;
                oCartao.CSCodigoUsuario = int.Parse(TxtUSCodigo.Text);
                oCartao.CSDataEntrega = DateTime.Parse(DtpCSDataEntrega.Value.ToString("dd/MM/yyyy"));
                oCartao.CSDataExpiracao = DateTime.Parse(DtpCSDataExpiracao.Value.ToString("dd/MM/yyyy")).AddDays(1).AddSeconds(-1);
                oCartao.CSObservacao = TxtCSObservacao.Text;
                oCartao.CSDevolvido = ChkCSDevolvido.Checked;
                if (ChkCSDevolvido.Checked)
                {
                    oCartao.CSDataDevolucao = DtpCSDataDevolucao.Value;
                }
                else
                {
                    oCartao.CSCODIGO = CSCODIGO;
                    oCartao.CSDataDevolucao = null;
                }

                if (NovoCartao)
                {
                    if (oProxy.CartaoAdicionado(int.Parse(TxtUSCodigo.Text), (int)CboCrCodigo.SelectedValue) == false)
                    {
                        oProxy.IncluirCartaoUsuario(oCartao);
                    }
                    else
                    {
                        MessageBox.Show("Não é permitido adicionar duas vezes o mesmo cartão.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CboCrCodigo.Focus();
                        return;
                    }
                }
                else
                {
                    oCartao.CSCODIGO = CSCODIGO;
                    oProxy.AlterarCartaoUsuario(oCartao);
                }
                validador2.LimpaControles();
                CboCrTipo.SelectedIndex = -1;
                CarregaGridCartao(oProxy);
                NovoCartao = true;
            }
        }

        private void GrdCartao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                var oCartao = (CUsuario.vw_CartaoUsuario)GrdCartao.Rows[e.RowIndex].DataBoundItem;
                if (GrdCartao.Columns[e.ColumnIndex].Name == "BtnAlterarCartao")
                {

                    if (oCartao != null)
                    {
                        CSCODIGO = oCartao.CSCODIGO;
                        CboCrTipo.Text = oCartao.CrTipo.ToString();
                        CboCrCodigo.SelectedValue = oCartao.CSCodigoCartao;
                        DtpCSDataEntrega.Value = oCartao.CSDataEntrega;
                        DtpCSDataExpiracao.Value = oCartao.CSDataExpiracao;
                        TxtCSObservacao.Text = oCartao.CSObservacao;
                        ChkCSDevolvido.Checked = (bool)oCartao.CSDevolvido;
                        if ((bool)oCartao.CSDevolvido)
                        {
                            DtpCSDataDevolucao.Value = (DateTime)oCartao.CSDataDevolucao;
                        }
                        else
                        {
                            DtpCSDataDevolucao.Value = DateTime.Now;
                        }
                        NovoCartao = false;
                    }
                    else
                    {
                        MessageBox.Show("Cartõa do usuário não encontrado.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CSCODIGO = 0;
                        validador2.LimpaControles();
                        CarregaGridCartao(oProxy);
                    }
                }
                else if (GrdCartao.Columns[e.ColumnIndex].Name == "BtnExcluirCartao")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var oCartaoUsuario = oProxy.SelecionaCartaoUSuarioPK(((CUsuario.vw_CartaoUsuario)GrdCartao.Rows[e.RowIndex].DataBoundItem).CSCODIGO);
                        oProxy.ExcluirCartaoUsuario(oCartaoUsuario);
                        CarregaGridCartao(oProxy);
                    }
                }

            }
        }

        private void btnCancelarCartao_Click(object sender, EventArgs e)
        {
            validador2.LimpaControles();
            CSCODIGO = 0;
            NovoCartao = true;
        }

        private void CboCrTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtUSCodigo.Text.Trim() != "")
            {
                if (CboCrTipo.SelectedIndex > -1)
                {
                    CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                    CboCrCodigo.ValueMember = "CrCodigo";
                    CboCrCodigo.DisplayMember = "CrNumeroCartao";
                    CboCrCodigo.DataSource = oProxy.ListarCartao(char.Parse(CboCrTipo.Text), int.Parse(TxtUSCodigo.Text));
                }
                else
                {
                    CboCrCodigo.DataSource = null;
                }
            }
        }


        private void BtnSalvarRota_Click(object sender, EventArgs e)
        {
            if (validador3.isValid())
            {
                if (CboRUCodigoRota.SelectedIndex == -1)
                {
                    MessageBox.Show("É obrigatório selecionar uma rota antes de clicar no salvar.", ProductName);
                    CboRUCodigoRota.Focus();
                    return;
                }
                if (ChkRUBloqueada.Checked)
                {
                    if (TxtRUMotivoBloqueio.Text.Trim() == "")
                    {
                        MessageBox.Show("Informe o motivo do bloqueio.", ProductName, MessageBoxButtons.OK);
                        TxtRUMotivoBloqueio.Focus();
                        return;
                    }
                }
                else
                {
                    TxtRUMotivoBloqueio.Text = "";
                }

                CUsuario.ROTAUSUARIO oRota = new CUsuario.ROTAUSUARIO();
                oRota.RUCodigoRota = (int)CboRUCodigoRota.SelectedValue;
                oRota.RUDataExpiracao = DtpRUDataExpiracao.Value;
                oRota.RUDataInicioPermissao = DtpRUDataInicioPermissao.Value;
                oRota.RUCodigoUsuario = int.Parse(TxtUSCodigo.Text);
                oRota.RUBloqueada = ChkRUBloqueada.Checked;
                oRota.RUMotivoBloqueio = TxtRUMotivoBloqueio.Text;
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                if (NovaRota)
                {
                    if (oProxy.RotaAdicionada((int)CboRUCodigoRota.SelectedValue, int.Parse(TxtUSCodigo.Text)))
                    {
                        MessageBox.Show("Não é possível adicionar duas vezes a mesma rota ao usuário.", ProductName);
                        CboRUCodigoRota.Focus();
                        return;
                    }
                    oProxy.IncluirRotaUsuario(oRota);
                }
                else
                {
                    oRota.RUCodigo = RUCodigo;
                    oProxy.AlterarRotaUsuario(oRota);
                }
                CarregaRota(oProxy);
                BtnCancelarRota_Click(sender, e);
            }
        }

        private void BtnCancelarRota_Click(object sender, EventArgs e)
        {
            validador3.LimpaControles();
            NovaRota = true;
        }

        private void GrdRota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                var oRota = (CUsuario.vw_RotaUsuario)GrdRota.Rows[e.RowIndex].DataBoundItem;
                if (GrdRota.Columns[e.ColumnIndex].Name == "BtnAlterarRota")
                {

                    if (oRota != null)
                    {
                        RUCodigo = oRota.RUCodigo;
                        CboRUCodigoRota.SelectedValue = oRota.RUCodigoRota;
                        DtpRUDataInicioPermissao.Value = oRota.RUDataInicioPermissao;
                        DtpRUDataExpiracao.Value = oRota.RUDataExpiracao;
                        ChkRUBloqueada.Checked = (bool)oRota.RUBloqueada;
                        TxtRUMotivoBloqueio.Text = oRota.RUMotivoBloqueio;
                        NovaRota = false;
                    }
                    else
                    {
                        MessageBox.Show("Rota do usuário não encontrada.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RUCodigo = 0;
                        validador2.LimpaControles();
                        CarregaRota(oProxy);
                    }
                }
                else if (GrdRota.Columns[e.ColumnIndex].Name == "BtnExcluirRota")
                {
                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var oRotaUsuario = oProxy.SelecionaRotaPK(((CUsuario.vw_RotaUsuario)GrdRota.Rows[e.RowIndex].DataBoundItem).RUCodigo);
                        oProxy.ExcluirRotaUsuario(oRotaUsuario);
                        CarregaRota(oProxy);
                    }
                }

            }
        }

        private void BtnColetaDigital_Click(object sender, EventArgs e)
        {
            FrmSeleçãoDedoCaptura oFrm = new FrmSeleçãoDedoCaptura(int.Parse(TxtUSCodigo.Text));
            oFrm.ShowDialog();
            CarregaGrids();

        }

        private void GrdDigitais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 3)
            {
                //BOTAO EXCLUIR
                if (MessageBox.Show("Se confirmar, será impossível desfazer a exclusão", ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    CUsuario.vw_Digital oDigital = (CUsuario.vw_Digital)GrdDigitais.Rows[e.RowIndex].DataBoundItem;
                    CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                    oProxy.ExcluirDigital(oDigital.DiCodigo);
                    CarregaGrids(oProxy);
                    MessageBox.Show("Digital excluída com sucesso.", ProductName);
                }
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text.Trim() != "")
            {
                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();


                switch (CboUSTipo.SelectedIndex)
                {
                    case 0:
                        {
                            //CONTRATADO 
                            try
                            {
                                CUsuario.TERCEIRO oTerceiro = oProxy.SelecionaTerceiro(int.Parse(TxtUsuario.Text));
                                LblUsuario.Text = oTerceiro.TeNome;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("O código do terceirado informado não é válido porque não existe um registro correspondente no Banco de Dados", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                TxtUsuario.Focus();
                                LblUsuario.Text = "";
                                return;
                            }
                            break;
                        }
                    case 1:
                        {
                            //EMPREGADO
                            try
                            {
                                CUsuario.FUNCIONARIO oFunc = oProxy.SelecionaFuncionario(int.Parse(TxtUsuario.Text));
                                LblUsuario.Text = oFunc.FUNOMFUNC;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("A Matrícula do empregado informada não é válida porque não existe um registro correspondente no Banco de Dados", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                TxtUsuario.Focus();
                                LblUsuario.Text = "";
                                return;
                            }
                            break;
                        }

                    case 2:
                        {
                            //ESTAGIÁRIO
                            try
                            {
                                CUsuario.ESTAGIARIO oEst = oProxy.SelecionaEstagiario(int.Parse(TxtUsuario.Text));
                                LblUsuario.Text = oEst.ESNome;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("A Matrícula do estagiário informada não é válida porque não existe um registro correspondente no Banco de Dados", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                TxtUsuario.Focus();
                                LblUsuario.Text = "";
                                return;
                            }
                            break;
                        }
                    case 3:
                        {
                            //VISITANTE
                            try
                            {
                                CUsuario.VISITANTE oVis = oProxy.SelecionaVisitante(int.Parse(TxtUsuario.Text));
                                LblUsuario.Text = oVis.ViNome;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("O código do visitante informado não é válido porque não existe um registro correspondente no Banco de Dados", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                TxtUsuario.Focus();
                                LblUsuario.Text = "";
                                return;
                            }
                            break;
                        }
                    default:
                        {
                            TxtUSUSUARIOREDE.Enabled = true;
                            break;
                        }
                }

                //CUsuario.usua

                CUsuario.USUARIO oUsuario = oProxy.SelecionaUsuario(TipoUsuario(), int.Parse(TxtUsuario.Text));
                if (oUsuario == null)
                {
                    BtnNovo.Enabled = true;
                    btnSalvar.Enabled = true;
                    BtnCancela.Enabled = true;
                    BtnExcluir.Enabled = false;
                    BtnAlterar.Enabled = false;
                    tabControl1.Enabled = false;
                    validador2.LimpaControles();
                    validador3.LimpaControles();
                    validador4.LimpaControles();
                    TxtUSCodigo.Text = "";
                    if (CboUSTipo.SelectedIndex == 1 || CboUSTipo.SelectedIndex == 2)
                        TxtUSUSUARIOREDE.Text = int.Parse(TxtUsuario.Text).ToString("0000");
                }
                else
                {
                    BtnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    BtnCancela.Enabled = true;
                    BtnExcluir.Enabled = true;
                    BtnAlterar.Enabled = true;
                    tabControl1.Enabled = true;
                    TxtUSCodigo.Text = oUsuario.USCODIGO.ToString();
                    TxtUSUSUARIOREDE.Text = oUsuario.USUSUARIOREDE;
                    ChkUSAdministrador.Checked = (bool)oUsuario.USAdministrador;
                    ChkUSAuditor.Checked = (bool)oUsuario.USAuditor;
                    ChkUSBloqueado.Checked = oUsuario.USBloqueado;
                    if (oUsuario.USMotivoBloqueio != null)
                    {
                        TxtUSMotivoBloqueio.Text = oUsuario.USMotivoBloqueio;
                    }
                    else
                    {
                        TxtUSMotivoBloqueio.Text = "";
                    }
                    validador1.HabilitaControles(false);
                    CarregaGrids(oProxy);

                }
                CboCrTipo.SelectedIndex = 0;
                CboCrTipo_SelectedIndexChanged(sender, e);
            }
            else
            {
                btnSalvar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnCancela.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnAlterar.Enabled = false;
                tabControl1.Enabled = false;
                CboCrCodigo.DataSource = null;
            }

        }

        private void CarregaGridEPI(CUsuario.CUsuarioClient oProxy)
        {
            var Lista = oProxy.oListaEquipamentoUsuario(int.Parse(TxtUSCodigo.Text));
            GrdEPI.AutoGenerateColumns = false;
            GrdEPI.DataSource = Lista;
        }

        private void BtnCancelarEPI_Click(object sender, EventArgs e)
        {
            validador1.LimpaControles();
        }

        private void BtnSalvarEPI_Click(object sender, EventArgs e)
        {
            if (validador5.isValid())
            {
                DateTime DataInicio = DtpEUSDataInicio.Value;
                DateTime DataFim = DtpEUSDataFim.Value;

                if (DataFim <= DateTime.Now)
                {
                    MessageBox.Show("Não é permitido adicionar um equipamento com data de término menor que a data atual");
                    DtpEUSDataFim.Focus();
                    return;
                }
                if (CboEquipamentoEPI.SelectedIndex == -1)
                {
                    MessageBox.Show("É obrigatório selecionar um equipamento antes de clicar no salvar.", ProductName);
                    CboEquipamentoEPI.Focus();
                    return;
                }

                DataFim = DtpEUSDataFim.Value;
                DataFim.AddHours(23);
                DataFim.AddMinutes(59);
                DataFim.AddSeconds(59);
                CUsuario.EQUIPUSUARIO oEquip = new CUsuario.EQUIPUSUARIO();
                oEquip.EUSCodigoUsuario = int.Parse(TxtUSCodigo.Text);
                oEquip.EUSCodigoEquipamento = (int)CboEquipamentoEPI.SelectedValue;
                oEquip.EUSDataInicio = DtpEUSDataInicio.Value;
                oEquip.EUSDataFim = DataFim;

                CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                if (NovoEquipamento)
                {

                    oProxy.IncluirEquipamento(oEquip);
                }
                else
                {
                    oEquip.EUSCodigo = EUSCodigo;
                    oProxy.AlterarEquipamento(oEquip);
                }

                CarregaGridEPI(oProxy);
                CarregaComboEquipamentoEPI(oProxy);
                oProxy.Close();
            }
        }

        private void GrdEPI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ovwEquip = (CUsuario.vw_EquipamentoUsuario)GrdEPI.Rows[e.RowIndex].DataBoundItem;


            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                if (GrdEPI.Columns[e.ColumnIndex].Name == "BtnAlterarEquip")
                {

                    if (ovwEquip != null)
                    {
                        EUSCodigo = ovwEquip.EUSCodigo;
                        CboEquipamentoEPI.SelectedValue = ovwEquip.EUSCodigoEquipamento;
                        DtpEUSDataInicio.Value = (DateTime)ovwEquip.EUSDataInicio;
                        DtpEUSDataFim.Value = (DateTime)ovwEquip.EUSDataFim;
                        NovaRota = false;

                    }
                    else
                    {
                        MessageBox.Show("Equipamento do usuário não encontrada.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EUSCodigo = 0;
                        validador5.LimpaControles();
                        CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                        oProxy.Open();
                        CarregaGridEPI(oProxy);
                        oProxy.Close();
                    }
                }
                else if (GrdEPI.Columns[e.ColumnIndex].Name == "BtnExcluirEquip")
                {

                    if (MessageBox.Show("Se excluir será impossível recuperar o registro. Deseja continuar? ", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CUsuario.CUsuarioClient oProxy = new CUsuario.CUsuarioClient();
                        oProxy.Open();
                        oProxy.ExcluirEquipamento(ovwEquip.EUSCodigo);
                        CarregaGridEPI(oProxy);
                        CarregaComboEquipamentoEPI(oProxy);
                        oProxy.Close();
                    }
                }

            }
        }

        private void TxtEUSCodigoEquipamento_TextChanged(object sender, EventArgs e)
        {
            if (TxtEUSCodigoEquipamento.Text.Trim() != "")
            {
                CboEquipamentoEPI.SelectedValue = int.Parse(TxtEUSCodigoEquipamento.Text);
            }
            else
            {
                CboEquipamentoEPI.SelectedIndex = -1;
            }
        }

        private void CboEquipamentoEPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEquipamentoEPI.SelectedIndex == -1)
            {
                TxtEUSCodigoEquipamento.Text = "";
            }
            else
            {
                TxtEUSCodigoEquipamento.Text = CboEquipamentoEPI.SelectedValue.ToString();
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
