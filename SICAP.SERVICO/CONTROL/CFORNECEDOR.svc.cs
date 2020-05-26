using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFORNECEDOR" in code, svc and config file together.
    public class CFORNECEDOR : ICFORNECEDOR
    {     
        #region ICFORNECEDOR Members

        public List<FORNECEDOR> ListarTodosFornecedores()
        {
            return FORNECEDOR.ListarTodos();
        }

        public FORNECEDOR SelecionaPKFornecedor(string Codigo)
        {
            return FORNECEDOR.SelecionaPK(Codigo);
        }

        public void Incluir(MODEL.FORNECEDOR oFORNECEDOR)
        {
            FORNECEDOR.Incluir(oFORNECEDOR);
        }

        public void Alterar(MODEL.FORNECEDOR oFORNECEDOR)
        {
            FORNECEDOR.Alterar(oFORNECEDOR);
        }

        public void Excluir(MODEL.FORNECEDOR oFORNECEDOR)
        {
            FORNECEDOR.Excluir(oFORNECEDOR);
        }

        #endregion
    }
}
