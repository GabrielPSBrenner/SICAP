using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL
{
    public class CCartao : ICCartao
    {

        #region ICCartao Members

        public List<CARTAO> ListarCARTAOsTipo(char CodigoTipo)
        {
            return CARTAO.ListarCartoesTipo(CodigoTipo);
        }

      
        public List<FABRICANTE> ListarFabricantes()
        {
            return FABRICANTE.ListarTodos();
        }

        public CARTAO SelecionaCARTAO(int Codigo)
        {
            return CARTAO.SelecionaPK(Codigo);
        }

        public List<CARTAO> SelecionaCARTAONumero(string Numero)
        {
            return CARTAO.CartaoNumero(Numero);
        }

        public void Incluir(CARTAO oCARTAO)
        {
            CARTAO.Incluir(oCARTAO);
        }

        public void Alterar(CARTAO oCARTAO)
        {
            CARTAO.Alterar(oCARTAO);
        }

        public void Excluir(CARTAO oCARTAO)
        {
            CARTAO.Excluir(oCARTAO);
        }

        public List<CARTAO> ListarCARTAOs()
        {
            return CARTAO.ListarTodos();
        }

        #endregion

        
    }
}
