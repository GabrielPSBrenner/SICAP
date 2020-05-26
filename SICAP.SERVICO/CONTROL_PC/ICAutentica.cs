using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ACESSO.SERVICO.CONTROL_PC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICAutentica" in both code and config file together.
    [ServiceContract]
    public interface ICAutentica
    {
        [OperationContract]
        bool IsAuthenticated(string Domain, string UserName, string Password);
    }
}
