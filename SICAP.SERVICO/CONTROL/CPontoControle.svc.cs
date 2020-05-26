using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CPontoControle : ICPontoControle
    {       

        #region ICPontoControle Members

        public List<PONTOCONTROLE> ListarTodosPontosControle()
        {
            return PONTOCONTROLE.ListarTodos();
        }

        public PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo)
        {
            return PONTOCONTROLE.SelecionaPK(Codigo, Tipo);
        }

        public void Incluir(PONTOCONTROLE oPONTOCONTROLE)
        {
            PONTOCONTROLE.Incluir(oPONTOCONTROLE);
        }

        public void Alterar(PONTOCONTROLE oPONTOCONTROLE)
        {
            PONTOCONTROLE.Alterar(oPONTOCONTROLE);
        }

        public void Excluir(PONTOCONTROLE oPONTOCONTROLE)
        {
            PONTOCONTROLE.Excluir(oPONTOCONTROLE);
        }

        #endregion
    }
}
