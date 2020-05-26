using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFORNECEDOR" in both code and config file together.
    [ServiceContract]
    public interface ICFORNECEDOR
    {
        [OperationContract]
        List<FORNECEDOR> ListarTodosFornecedores();

        [OperationContract]
        FORNECEDOR SelecionaPKFornecedor(string Codigo);

        [OperationContract]
        void Incluir(FORNECEDOR oFORNECEDOR);

        [OperationContract]
        void Alterar(FORNECEDOR oFORNECEDOR);

        [OperationContract]
        void Excluir(FORNECEDOR oFORNECEDOR);
    }
}
