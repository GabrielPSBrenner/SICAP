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
    public interface ICCartao
    {
        [OperationContract]
        List<CARTAO> ListarCARTAOsTipo(char CodigoTipo);

        [OperationContract]
        List<CARTAO> ListarCARTAOs();

        [OperationContract]
        List<FABRICANTE> ListarFabricantes();

        [OperationContract]
        CARTAO SelecionaCARTAO(int Codigo);

        [OperationContract]
        List<CARTAO> SelecionaCARTAONumero(string Numero);

        [OperationContract]
        void Incluir(CARTAO oCARTAO);

        [OperationContract]
        void Alterar(CARTAO oCARTAO);

        [OperationContract]
        void Excluir(CARTAO oCARTAO);
    }
}
