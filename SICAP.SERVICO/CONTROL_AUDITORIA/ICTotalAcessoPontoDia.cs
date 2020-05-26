using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICTotalAcessoPontoDia" in both code and config file together.
    [ServiceContract]
    public interface ICTotalAcessoPontoDia
    {
        [OperationContract]
        List<vw_TotalAcessoPontoDia> TotalAcessoPontoDia();

        [OperationContract]
        List<vw_TotalAcessoPontoDia> TotalAcessoPontoDiaPeriodo(DateTime DataInicio, DateTime DataFim);
    }
}
