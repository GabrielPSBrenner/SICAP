using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_PC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICPonto" in both code and config file together.
    [ServiceContract]
    public interface ICPonto
    {
        [OperationContract]
        PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo);

        [OperationContract]
        USUARIO SelecionaUsuario(int Codigo);

        [OperationContract]
        FUNCIONARIO SelecionaFuncionario(int Codigo);

        [OperationContract]
        ESTAGIARIO SelecionaEstagiario(int Codigo);

        [OperationContract]
        TERCEIRO SelecionaTerceiro(int Codigo);

        [OperationContract]
        VISITANTE SelecionaVisitante(int Codigo);
        
        [OperationContract]
        List<ROTAUSUARIO> RotasUsuario(int CodigoUsuario);

        [OperationContract]
        List<PONTOROTA> PontosRota(int CodigoRota);

        [OperationContract]
        bool PossuiPermissaoPonto(int CodigoUsuario, int CodigoPonto);

        [OperationContract]
        void IncluirAcesso(ACESSOPONTOCONTROLE oAcessoPontoControle);

        [OperationContract]
        List<HASHDIGITAL> ListaHash();

        [OperationContract]
        HASHDIGITAL SelecionaHash(int Codigo);

        [OperationContract]
        List<HASHDIGITAL> SelecionaHashUsuario(int Codigo);
        
        [OperationContract]
        DIGITAL SelecionaDigital(int Codigo);

        [OperationContract]
        USUARIO SelecionaUsuarioRede(string Codigo);

        [OperationContract]
        CARTAO SelecionaCartao(string NumeroCartao, out CARTAOUSUARIO oCartaoUsuario);
               
        [OperationContract]
        CONTRATOTERCEIRO ContratoValidoTerceiro(int CodigoTerceiro);

        [OperationContract]
        List<vw_EquipamentoPonto> ListaEquipamentoPonto(int CodigoPonto);

        [OperationContract]
        vw_EquipamentoUsuario ListaEquipamentoUsuarioTAG(int CodigoUsuario, string TAG);
    }
}
