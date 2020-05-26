using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICPontoControle" in both code and config file together.
    [ServiceContract]
    public interface ICPontoControle
    {
        [OperationContract]
        List<PONTOCONTROLE> ListarTodosPontosControle();
        
        
        
        [OperationContract]
        PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo);

        [OperationContract]
        void Incluir(PONTOCONTROLE oPONTOCONTROLE);

        [OperationContract]
        void Alterar(PONTOCONTROLE oPONTOCONTROLE);

        [OperationContract]
        void Excluir(PONTOCONTROLE oPONTOCONTROLE);
    }
}
