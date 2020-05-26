using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    [ServiceContract]
    public interface ICUsuario
    {

        [OperationContract]
        List<vw_EquipamentoUsuario> oListaEquipamentoUsuario(int CodigoUSuario);

        [OperationContract]
        List<EQUIPAMENTO> ListarTodosEquipamentosNaoDistribuidos();
        
        [OperationContract]
        List<CARTAO> ListarCartao(char Tipo, int Usuario);

        [OperationContract]
        List<USUARIO> ListarUsuario(char Tipo);

        [OperationContract]
        List<ROTA> ListarRota();

        [OperationContract]
        List<FUNCIONARIO> ListarFuncionario();

        [OperationContract]
        List<TERCEIRO> ListarTerceiro();

        [OperationContract]
        List<ESTAGIARIO> ListarEstagiario();

        [OperationContract]
        List<VISITANTE> ListarVisitante();

        [OperationContract]
        List<EQUIPAMENTO> ListarEquipamento();

        [OperationContract]
        List<vw_RotaUsuario> ListarRotaUsuario(char Tipo, int Codigo);

        [OperationContract]
        List<vw_CartaoUsuario> ListarCartaoUsuario(char Tipo, int Codigo);

        [OperationContract]
        List<vw_Digital> ListarDigitalUsuario(int Codigo);

        [OperationContract]
        EQUIPUSUARIO SelecionaEquipamentoUsuario(int Codigo);

        [OperationContract]
        CARTAO SelecionaCartao(int Codigo);

        [OperationContract]
        USUARIO SelecionaUsuario(char Tipo, int Codigo);

        [OperationContract]
        CARTAOUSUARIO SelecionaCartaoUSuarioPK(int Codigo);

        [OperationContract]
        ROTAUSUARIO SelecionaRotaPK(int Codigo);

        [OperationContract]
        FUNCIONARIO SelecionaFuncionario(int Codigo);

        [OperationContract]
        ESTAGIARIO SelecionaEstagiario(int Codigo);

        [OperationContract]
        VISITANTE SelecionaVisitante(int Codigo);

        [OperationContract]
        TERCEIRO SelecionaTerceiro(int Codigo);

        [OperationContract]
        int Incluir(USUARIO oUsuario);

        [OperationContract]
        void IncluirCartaoUsuario(CARTAOUSUARIO oCartao);

        [OperationContract]
        void AlterarCartaoUsuario(CARTAOUSUARIO oCartao);

        [OperationContract]
        void ExcluirCartaoUsuario(CARTAOUSUARIO oCartao);
        
        [OperationContract]
        void IncluirRotaUsuario(ROTAUSUARIO oRota);

        [OperationContract]
        void AlterarRotaUsuario(ROTAUSUARIO oRota);

        [OperationContract]
        void ExcluirRotaUsuario(ROTAUSUARIO oRota);

        [OperationContract]
        void ExcluirDigital(int Codigo);

        [OperationContract]
        void Alterar(USUARIO oUsuario);

        [OperationContract]
        void Excluir(USUARIO oUsuario);

        [OperationContract]
        bool CartaoAdicionado(int USCodigo, int CrCodigo);

        [OperationContract]
        bool RotaAdicionada(int RUCodigoRota, int RUCodigoUsuario);
                     
        [OperationContract]
        void IncluirEquipamento(EQUIPUSUARIO oEQUIPUSUARIO);

        [OperationContract]
        void AlterarEquipamento(EQUIPUSUARIO oEQUIPUSUARIO);

        [OperationContract]
        void ExcluirEquipamento(int pEUSCodigo);
        
    }
}
