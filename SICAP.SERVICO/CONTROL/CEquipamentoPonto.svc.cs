using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CEquipamentoPonto" in code, svc and config file together.
    public class CEquipamentoPonto : ICEquipamentoPonto
    {
        public void Incluir(EQUIPAMENTOPONTO oEquipamentoPonto)
        {
            EQUIPAMENTOPONTO.Incluir(oEquipamentoPonto);
        }

        public  void Excluir(int pEpCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto)
        {
            EQUIPAMENTOPONTO.Excluir(pEpCodigoPontoControle, pEPEquipamento, pEPCodigoTipoPonto);
        }

        public List<TIPOEQUIPAMENTO> ListaTipoEquipamento(int CodigoPonto)
        {
            return TIPOEQUIPAMENTO.ListaTipoEquipamento(CodigoPonto);
        }

        public List<vw_EquipamentoPonto> ListaEquipamentoPonto(int CodigoPonto)
        {
            return TIPOEQUIPAMENTO.ListaEquipamentoPonto(CodigoPonto);
        }

        public List<PONTOCONTROLE> ListaPontoControleEPI()
        {
            return PONTOCONTROLE.ListaPontoControleEPI();
        }
    }
}
