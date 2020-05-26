using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTotalAcessoPontoDia" in code, svc and config file together.
    public class CTotalAcessoPontoDia : ICTotalAcessoPontoDia
    {

        #region ICTotalAcessoPontoDia Members

        public List<vw_TotalAcessoPontoDia> TotalAcessoPontoDia()
        {
            return vw_TotalAcessoPontoDia.ListaTotalAcessoPontoDia();
        }

        public List<vw_TotalAcessoPontoDia> TotalAcessoPontoDiaPeriodo(DateTime DataInicio, DateTime DataFim)
        {
            return vw_TotalAcessoPontoDia.ListaTotalAcessoPontoDia(DataInicio, DataFim);
        }

        #endregion
    }
}
