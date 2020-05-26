using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CEquipamento : ICEquipamento
    {

        #region ICEquipamento Members

        public List<EQUIPAMENTO> ListarEquipamentosTipo(int CodigoTipo)
        {
            return EQUIPAMENTO.ListarEquipamentosTipo(CodigoTipo);
        }

        public List<TIPOEQUIPAMENTO> ListarTiposEquipamentos()
        {
            return TIPOEQUIPAMENTO.ListarTodos();
        }

        public List<FABRICANTE> ListarFabricantes()
        {
            return FABRICANTE.ListarTodos();
        }

        public EQUIPAMENTO SelecionaEquipamento(int Codigo)
        {
            return EQUIPAMENTO.SelecionaPK(Codigo);
        }

        public void Incluir(EQUIPAMENTO oEquipamento)
        {
            EQUIPAMENTO.Incluir(oEquipamento);
        }

        public void Alterar(EQUIPAMENTO oEquipamento)
        {
            EQUIPAMENTO.Alterar(oEquipamento);
        }

        public void Excluir(EQUIPAMENTO oEquipamento)
        {
            EQUIPAMENTO.Excluir(oEquipamento);
        }
     
        public FABRICANTE SelecionaFabricante(int Codigo)
        {
            return FABRICANTE.SelecionaPK(Codigo);
        }

        #endregion
    }
}
