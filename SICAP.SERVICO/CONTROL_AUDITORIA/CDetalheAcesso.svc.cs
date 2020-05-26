using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CDetalheAcesso" in code, svc and config file together.
    public class CDetalheAcesso : ICDetalheAcesso
    {

        #region ICDetalheAcesso Members

        public vw_Acesso oAcesso(int APCodigo)
        {
            return vw_Acesso.SelecionaPK(APCodigo);
        }

        public vw_Usuario oUsuario(int UsCodigo)
        {
            return vw_Usuario.SelecionaPK(UsCodigo);
        }

        #endregion
    }
}
