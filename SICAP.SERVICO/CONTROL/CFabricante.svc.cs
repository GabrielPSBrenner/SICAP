using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFabricante" in code, svc and config file together.
    public class CFabricante : ICFabricante
    {

        #region ICFabricante Members

        public List<MODEL.FABRICANTE> ListarTodosFabricantes()
        {
            return MODEL.FABRICANTE.ListarTodos();
        }

        public MODEL.FABRICANTE SelecionaPKFabricante(int Codigo)
        {
            return MODEL.FABRICANTE.SelecionaPK(Codigo);
        }

        public void Incluir(MODEL.FABRICANTE oFABRICANTE)
        {
            MODEL.FABRICANTE.Incluir(oFABRICANTE);
        }

        public void Alterar(MODEL.FABRICANTE oFABRICANTE)
        {
            MODEL.FABRICANTE.Alterar(oFABRICANTE);
        }

        public void Excluir(MODEL.FABRICANTE oFABRICANTE)
        {
            MODEL.FABRICANTE.Excluir(oFABRICANTE);
        }
        #endregion
    }
}
