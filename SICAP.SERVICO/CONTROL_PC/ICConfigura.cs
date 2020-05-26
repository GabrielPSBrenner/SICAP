using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_PC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICConfigura" in both code and config file together.
    [ServiceContract]
    public interface ICConfigura
    {
        [OperationContract]
        List<PONTOCONTROLE> ListarTodosPontosControle();
    }
}
