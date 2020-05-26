using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CUsuario : ICUsuario
    {

        public List<CARTAO> ListarCartao(char Tipo, int Usuario)
        {
            return CARTAO.ListarCartoesTipo(Tipo, Usuario);
        }

        public CARTAO SelecionaCartao(int Codigo)
        {
            return CARTAO.SelecionaPK(Codigo);
        }

        public List<USUARIO> ListarUsuario(char Tipo)
        {
            return USUARIO.UsuariosTipo(Tipo);
        }

        public List<ROTA> ListarRota()
        {
            var Retorno = ROTA.ListarTodos();
            Retorno.Insert(0, new ROTA());
            return Retorno;
        }

        public List<vw_RotaUsuario> ListarRotaUsuario(char Tipo, int Codigo)
        {
            return USUARIO.RotasUsuario(Tipo, Codigo);
        }

        public List<vw_CartaoUsuario> ListarCartaoUsuario(char Tipo, int Codigo)
        {
            return USUARIO.CartoesUsuario(Tipo, Codigo);
        }

        public List<vw_Digital> ListarDigitalUsuario(int Codigo)
        {
            return USUARIO.DigitaisUsuario(Codigo);
        }

        public USUARIO SelecionaUsuario(char Tipo, int Codigo)
        {
            return USUARIO.SelecionaUsuario(Tipo, Codigo);
        }

        public CARTAOUSUARIO SelecionaCartaoUSuarioPK(int Codigo)
        {
            return CARTAOUSUARIO.SelecionaPK(Codigo);
        }

        public void IncluirCartaoUsuario(CARTAOUSUARIO oCartao)
        {
            CARTAOUSUARIO.Incluir(oCartao);
        }

        public void AlterarCartaoUsuario(CARTAOUSUARIO oCartao)
        {
            CARTAOUSUARIO.Alterar(oCartao);
        }

        public void ExcluirCartaoUsuario(CARTAOUSUARIO oCartao)
        {
            CARTAOUSUARIO.Excluir(oCartao);
        }

        public void IncluirRotaUsuario(ROTAUSUARIO oRota)
        {
            ROTAUSUARIO.Incluir(oRota);
        }

        public void AlterarRotaUsuario(ROTAUSUARIO oRota)
        {
            ROTAUSUARIO.Alterar(oRota);
        }

        public void ExcluirRotaUsuario(ROTAUSUARIO oRota)
        {
            ROTAUSUARIO.Excluir(oRota);
        }

        public ROTAUSUARIO SelecionaRotaPK(int Codigo)
        {
            return ROTAUSUARIO.SelecionaPK(Codigo);
        }

        public int Incluir(USUARIO oUsuario)
        {
            return USUARIO.Incluir(oUsuario);
        }

        public void Alterar(USUARIO oUsuario)
        {
            USUARIO.Alterar(oUsuario);
        }

        public void Excluir(USUARIO oUsuario)
        {
            USUARIO.Excluir(oUsuario);
        }

        public List<FUNCIONARIO> ListarFuncionario()
        {
            var Lista = FUNCIONARIO.ListarTodos();
            Lista.Insert(0, new FUNCIONARIO());
            return Lista;
        }

        public List<TERCEIRO> ListarTerceiro()
        {
            var Lista = TERCEIRO.ListarTodos();
            Lista.Insert(0, new TERCEIRO());
            return Lista;
        }

        public List<ESTAGIARIO> ListarEstagiario()
        {
            var Lista = ESTAGIARIO.ListarTodos();
            Lista.Insert(0, new ESTAGIARIO());
            return Lista;
        }

        public List<VISITANTE> ListarVisitante()
        {
            var Lista = VISITANTE.ListarTodos();
            Lista.Insert(0, new VISITANTE());
            return Lista;
        }

        public bool CartaoAdicionado(int USCodigo, int CrCodigo)
        {
            return USUARIO.CartaoAdicionado(USCodigo, CrCodigo);
        }

        public bool RotaAdicionada(int RUCodigoRota, int RUCodigoUsuario)
        {
            return USUARIO.RotaAdicionada(RUCodigoRota, RUCodigoUsuario);
        }
        public List<EQUIPAMENTO> ListarEquipamento()
        {
            return EQUIPAMENTO.ListarEquipamentosTipo(1);
        }

        public void ExcluirDigital(int Codigo)
        {
            DIGITAL.Excluir(Codigo);
        }

        public FUNCIONARIO SelecionaFuncionario(int Codigo)
        {
            return FUNCIONARIO.SelecionaPK(Codigo);
        }

        public ESTAGIARIO SelecionaEstagiario(int Codigo)
        {
            return ESTAGIARIO.SelecionaPK(Codigo);
        }

        public VISITANTE SelecionaVisitante(int Codigo)
        {
            return VISITANTE.SelecionaPK(Codigo);
        }

        public TERCEIRO SelecionaTerceiro(int Codigo)
        {
            return TERCEIRO.SelecionaPK(Codigo);
        }


        public EQUIPUSUARIO SelecionaEquipamentoUsuario(int Codigo)
        {
            return EQUIPUSUARIO.SelecionaPK(Codigo);
        }

        public void IncluirEquipamento(EQUIPUSUARIO oEQUIPUSUARIO)
        {
            EQUIPUSUARIO.Incluir(oEQUIPUSUARIO);
        }

        public void AlterarEquipamento(EQUIPUSUARIO oEQUIPUSUARIO)
        {
            EQUIPUSUARIO.Alterar(oEQUIPUSUARIO);
        }

        public void ExcluirEquipamento(int pEUSCodigo)
        {
            EQUIPUSUARIO.Excluir(pEUSCodigo);
        }

        public List<vw_EquipamentoUsuario> oListaEquipamentoUsuario(int CodigoUsuario)
        {
            return EQUIPUSUARIO.ListaEquipamentoUsuario(CodigoUsuario);
        }

        public List<EQUIPAMENTO> ListarTodosEquipamentosNaoDistribuidos()
        {
            return EQUIPAMENTO.ListarTodosEquipamentosNaoDistribuidos();
        }
    }
}
