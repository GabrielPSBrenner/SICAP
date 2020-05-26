using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;


namespace ACESSO.SERVICO
{
    public class LdapAds
    {
        private string _Path, _User, _Password;

        public void LoadApplicationSettings()
        {
            _Path = "LDAP://INB/DC=inb,DC=gov,DC=br";
            _User = "INB\\ConsultaLdap";
            _Password = "gHz!,)p";
        }

        public bool IsAuthenticated(string Domain, string UserName, string Password)
        {
            string domainAndUsername = Domain + "\\" + UserName;
            DirectoryEntry entry = new DirectoryEntry(_Path, domainAndUsername, Password);

            try
            {
                //Bind to the native AdsObject to force authentication.
                object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + UserName + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();
                if (result == null)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}
