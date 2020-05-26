using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTipoEquipamento" in code, svc and config file together.
    public class CTipoEquipamento : ICTipoEquipamento
    {

        #region ICTipoEquipamento Members

        public List<TIPOEQUIPAMENTO> ListarTodosTiposEquipamento()
        {
            return TIPOEQUIPAMENTO.ListarTodos();
        }

        public MODEL.TIPOEQUIPAMENTO SelecionaPKTipoEquipamento(int Codigo)
        {
            return TIPOEQUIPAMENTO.SelecionaPK(Codigo);
        }

        public void Incluir(MODEL.TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            TIPOEQUIPAMENTO.Incluir(oTIPOEQUIPAMENTO);
        }

        public void Alterar(MODEL.TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            TIPOEQUIPAMENTO.Alterar(oTIPOEQUIPAMENTO);
        }

        public void Excluir(MODEL.TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            TIPOEQUIPAMENTO.Excluir(oTIPOEQUIPAMENTO);
        }

        #endregion
    }
}
