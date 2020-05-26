using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ACESSO.SERVICO.Fotos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFoto" in both code and config file together.
    [ServiceContract]
    public interface IFoto
    {
        [OperationContract]
        byte[] DownloadFile(string FName, int Tipo);      

    }
}
