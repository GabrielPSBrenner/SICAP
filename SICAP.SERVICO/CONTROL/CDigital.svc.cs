using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CDigital : ICDigital
    {

        #region ICDigital Members

        public void Excluir(DIGITAL oDig)
        {
            DIGITAL.Excluir(oDig);            
        }

        public void Incluir(DIGITAL Digital1, HASHDIGITAL Hash1, DIGITAL Digital2, HASHDIGITAL Hash2, DIGITAL Digital3, HASHDIGITAL Hash3)
        {
            DIGITAL.Incluir(Digital1, Hash1, Digital2, Hash2, Digital3, Hash3);
        }

        public List<DIGITAL> Digitais(int CodigoUsuario)
        {
            return DIGITAL.ListarPorUsuario(CodigoUsuario);
        }

        #endregion
    }
}
