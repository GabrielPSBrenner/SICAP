using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICEquipamentoPonto" in both code and config file together.
    [ServiceContract]
    public interface ICEquipamentoPonto
    {
        [OperationContract]
        void Incluir(EQUIPAMENTOPONTO oEquipamentoPonto);
        
        [OperationContract]
        void Excluir(int pEpCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto);

        [OperationContract]
        List<TIPOEQUIPAMENTO> ListaTipoEquipamento(int CodigoPonto);

        [OperationContract]
        List<vw_EquipamentoPonto> ListaEquipamentoPonto(int CodigoPonto);

        [OperationContract]
        List<PONTOCONTROLE> ListaPontoControleEPI();
        
    }
}
