using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CParametro" in code, svc and config file together.
    public class CParametro : ICParametro
    {

        #region ICParametro Members

        public void Alterar(PARAMETRO oParametro)
        {
            PARAMETRO.Alterar(oParametro);
        }

        public PARAMETRO SelecionarParametro()
        {
            return PARAMETRO.SelecionaPK(1);            
        }

        #endregion
    }
}
