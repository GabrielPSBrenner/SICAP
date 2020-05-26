using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_PC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CConfigura" in code, svc and config file together.
    public class CConfigura : ICConfigura
    {
        #region ICConfigura Members

        public List<PONTOCONTROLE> ListarTodosPontosControle()
        {
            return PONTOCONTROLE.ListarTodos();
        }
        #endregion
    }
}
