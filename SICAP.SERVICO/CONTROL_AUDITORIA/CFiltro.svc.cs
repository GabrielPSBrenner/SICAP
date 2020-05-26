using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFiltro" in code, svc and config file together.
    public class CFiltro : ICFiltro
    {
        public USUARIO SelecionaUsuario(char Tipo, int Codigo)
        {
            return USUARIO.SelecionaUsuario(Tipo, Codigo);
        }

        public FUNCIONARIO SelecionaFuncionario(int Codigo)
        {
            return FUNCIONARIO.SelecionaPK(Codigo);
        }

        public ESTAGIARIO SelecionaEstagiario(int Codigo)
        {
            return ESTAGIARIO.SelecionaPK(Codigo);
        }

        public VISITANTE SelecionaVisitante(int Codigo)
        {
            return VISITANTE.SelecionaPK(Codigo);
        }

        public TERCEIRO SelecionaTerceiro(int Codigo)
        {
            return TERCEIRO.SelecionaPK(Codigo);
        }
        
        public List<PONTOCONTROLE> ListarTodosPontosControle()
        {
            return PONTOCONTROLE.ListarTodos();
        }

        public List<PONTOCONTROLE> ListarPontosControle(char Tipo)
        {
            return PONTOCONTROLE.ListarPorTipo(Tipo);
        }

    }
}
