using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRota" in both code and config file together.
    [ServiceContract]
    public interface ICRota
    {
        [OperationContract]
        List<ROTA> ListarTodasRotas();

        [OperationContract]
        List<PONTOCONTROLE> ListarPontosControleTipo(char TipoPonto);

        [OperationContract]
        ROTA SelecionaPKROTA(int Codigo);

        [OperationContract]
        int Incluir(ROTA oROTA);

        [OperationContract]
        void IncluirPontoRota(PONTOROTA oPontoRota);

        [OperationContract]
        void ExcluirPontoRota(PONTOROTA oPontoRota);
        
        [OperationContract]
        void Alterar(ROTA oROTA);

        [OperationContract]
        void Excluir(ROTA oROTA);

        [OperationContract]
        List<vw_PontoRota> PontosRota(int PrCodigoRota);

        [OperationContract]
        void OrdemMaisUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle);

        [OperationContract]
        void OrdemMenosUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle);
    }
}
