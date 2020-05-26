using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Configuration;

namespace ACESSO.SERVICO.CONTROL_PC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAutentica" in code, svc and config file together.
    public class CAutentica : ICAutentica
    {

        #region ICAutentica Members

        public bool IsAuthenticated(string Domain, string UserName, string Password)
        {
            bool retorno=false;
            ACESSO.SERVICO.LdapAds oLdap = new ACESSO.SERVICO.LdapAds();
            var Dominio = ConfigurationManager.AppSettings["NOME_ESTACAO_LOCAL"].ToString();
            try
            {                
                retorno = oLdap.IsAuthenticated(Domain, UserName, Password);                
                if (retorno == false)
                {                    
                    retorno = oLdap.IsAuthenticated(Domain, UserName, Password);
                    if (retorno == false)
                    {
                        Usuario.Usuario oUs = new Usuario.Usuario();
                        retorno = oUs.ValidaUsuario(Dominio, UserName, Password);
                    }
                }
            }
            catch (Exception ex)
            {
                //implementa autenticação através da dll
                Usuario.Usuario oUs = new Usuario.Usuario();
                retorno = oUs.ValidaUsuario("INB", UserName, Password);
                if (retorno == false)
                {
                    retorno = oUs.ValidaUsuario(Dominio, UserName, Password);                    
                }               
            }
            oLdap = null;
            return retorno;
        }

        #endregion
    }
}
