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
    public interface ICTipoEquipamento
    {
        [OperationContract]
        List<TIPOEQUIPAMENTO> ListarTodosTiposEquipamento();
        
        [OperationContract]
        TIPOEQUIPAMENTO SelecionaPKTipoEquipamento(int Codigo);

        [OperationContract]
        void Incluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO);
        
        [OperationContract]
        void Alterar(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO);
        
        [OperationContract]
        void Excluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO);
        
    }
}
