using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICConsultaAcesso" in both code and config file together.
    [ServiceContract]
    public interface ICConsultaAcesso
    {
        [OperationContract]
        List<vw_Acesso> SelecionaAcessos(DateTime DataInicio, DateTime DataFim, string TipoPonto, int PontoControle, string TipoAcesso, int TipoUsuario, int CodigoUsuario);
    }
}
