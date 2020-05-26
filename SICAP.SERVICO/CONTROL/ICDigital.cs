using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    [ServiceContract]
    public interface ICDigital
    {
        [OperationContract]
        void Excluir(DIGITAL oDig);

        [OperationContract]
        void Incluir(DIGITAL Digital1, HASHDIGITAL Hash1, DIGITAL Digital2, HASHDIGITAL Hash2, DIGITAL Digital3, HASHDIGITAL Hash3);

        [OperationContract]
        List<DIGITAL> Digitais(int CodigoUsuario);

    }
}
