using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFabricante" in both code and config file together.
    [ServiceContract]
    public interface ICFabricante
    {
        [OperationContract]
        List<FABRICANTE> ListarTodosFabricantes();

        [OperationContract]
        FABRICANTE SelecionaPKFabricante(int Codigo);

        [OperationContract]
        void Incluir(FABRICANTE oFABRICANTE);

        [OperationContract]
        void Alterar(FABRICANTE oFABRICANTE);

        [OperationContract]
        void Excluir(FABRICANTE oFABRICANTE);
    }
}
