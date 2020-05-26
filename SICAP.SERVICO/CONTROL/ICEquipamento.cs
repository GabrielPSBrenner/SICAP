using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICEquipamento" in both code and config file together.
    [ServiceContract]
    public interface ICEquipamento
    {
        [OperationContract]
        List<EQUIPAMENTO> ListarEquipamentosTipo(int CodigoTipo);

        [OperationContract]
        List<TIPOEQUIPAMENTO> ListarTiposEquipamentos();

        [OperationContract]
        List<FABRICANTE> ListarFabricantes();
        
        [OperationContract]
        EQUIPAMENTO SelecionaEquipamento(int Codigo);

        [OperationContract]
        void Incluir(EQUIPAMENTO oEquipamento);

        [OperationContract]
        void Alterar(EQUIPAMENTO oEquipamento);

        [OperationContract]
        void Excluir(EQUIPAMENTO oEquipamento);

        [OperationContract]
        FABRICANTE SelecionaFabricante(int Codigo);
    }
}
