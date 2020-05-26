using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_PC
{
    public class CPonto : ICPonto
    {

        #region ICPonto Members

        public PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo)
        {
            return PONTOCONTROLE.SelecionaPK(Codigo, Tipo);
        }

        public USUARIO SelecionaUsuario(int Codigo)
        {
            return USUARIO.SelecionaPK(Codigo);
        }

        public List<ROTAUSUARIO> RotasUsuario(int CodigoUsuario)
        {
            return ROTAUSUARIO.RotasUsuario(CodigoUsuario);
        }

        public List<PONTOROTA> PontosRota(int CodigoRota)
        {
            return PONTOROTA.ListarPontosDaRota(CodigoRota);
        }

        public bool PossuiPermissaoPonto(int CodigoUsuario, int CodigoPonto)
        {
            return ROTAUSUARIO.PossuiPermissaoPonto(CodigoUsuario, CodigoPonto);
        }

        public void IncluirAcesso(ACESSOPONTOCONTROLE oAcessoPontoControle)
        {
            ACESSOPONTOCONTROLE.Incluir(oAcessoPontoControle);
        }

        public List<HASHDIGITAL> ListaHash()
        {
            return HASHDIGITAL.ListarTodos();
        }

        public DIGITAL SelecionaDigital(int Codigo)
        {
            return DIGITAL.SelecionaPK(Codigo);
        }

        public HASHDIGITAL SelecionaHash(int Codigo)
        {
            return HASHDIGITAL.SelecionaPK(Codigo);
        }
        public List<HASHDIGITAL> SelecionaHashUsuario(int Codigo)
        {
            return HASHDIGITAL.HashUsuario(Codigo);
        }
      
        public FUNCIONARIO SelecionaFuncionario(int Codigo)
        {
            return FUNCIONARIO.SelecionaPK(Codigo);
        }

        public ESTAGIARIO SelecionaEstagiario(int Codigo)
        {
            return ESTAGIARIO.SelecionaPK(Codigo);
        }

        public TERCEIRO SelecionaTerceiro(int Codigo)
        {
            return TERCEIRO.SelecionaPK(Codigo);
        }

        public VISITANTE SelecionaVisitante(int Codigo)
        {
            return VISITANTE.SelecionaPK(Codigo);
        }
        
        public USUARIO SelecionaUsuarioRede(string Codigo)
        {
            return USUARIO.SelecionaUsuarioRede(Codigo);
        }

        public CARTAO SelecionaCartao(string NumeroCartao, out CARTAOUSUARIO oCartaoUsuario)
        {
            return CARTAOUSUARIO.SelecionaCartao(NumeroCartao, out oCartaoUsuario);
        }
        
        public CONTRATOTERCEIRO ContratoValidoTerceiro(int CodigoTerceiro)
        {
            return CONTRATOTERCEIRO.SelecionaContratoValido(CodigoTerceiro);
        }

        public List<vw_EquipamentoPonto> ListaEquipamentoPonto(int CodigoPonto)
        {
           return TIPOEQUIPAMENTO.ListaEquipamentoPonto(CodigoPonto);
        }

        public vw_EquipamentoUsuario ListaEquipamentoUsuarioTAG(int CodigoUsuario, string TAG)
        {
           return EQUIPUSUARIO.ListaEquipamentoUsuario(CodigoUsuario, TAG);
        }
        #endregion
    }
}
