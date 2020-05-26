using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CRota : ICRota
    {
        #region ICRota Members

        public List<ROTA> ListarTodasRotas()
        {
            return ROTA.ListarTodos();
        }

        public ROTA SelecionaPKROTA(int Codigo)
        {
            return ROTA.SelecionaPK(Codigo);
        }

        public int Incluir(ROTA oROTA)
        {
            return ROTA.Incluir(oROTA);
        }

        public void Alterar(ROTA oROTA)
        {
            ROTA.Alterar(oROTA);
        }

        public void Excluir(ROTA oROTA)
        {
            ROTA.Excluir(oROTA);
        }

        public List<vw_PontoRota> PontosRota(int PrCodigoRota)
        {
            return ROTA.PontosDaRota(PrCodigoRota);
        }

        public void OrdemMaisUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle)
        {
            ROTA.OrdemMaisUm(PRCodigoRota, PRCodigoPontoControle, PRTipoPontoControle);
        }

        public void OrdemMenosUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle)
        {
            ROTA.OrdemMenosUm(PRCodigoRota, PRCodigoPontoControle, PRTipoPontoControle);
        }
        public List<PONTOCONTROLE> ListarPontosControleTipo(char TipoPonto)
        {
            return PONTOCONTROLE.ListarPorTipo(TipoPonto);
        }

        public void IncluirPontoRota(PONTOROTA oPontoRota)
        {
            PONTOROTA.Incluir(oPontoRota);
        }

        public void ExcluirPontoRota(PONTOROTA oPontoRota)
        {
            PONTOROTA.Excluir(oPontoRota);
        }

        #endregion       

    


    
    }
}
