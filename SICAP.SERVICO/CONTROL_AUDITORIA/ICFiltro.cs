using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    [ServiceContract]
    public interface ICFiltro
    {       
        [OperationContract]
        USUARIO SelecionaUsuario(char Tipo, int Codigo);

        [OperationContract]
        FUNCIONARIO SelecionaFuncionario(int Codigo);

        [OperationContract]
        ESTAGIARIO SelecionaEstagiario(int Codigo);

        [OperationContract]
        VISITANTE SelecionaVisitante(int Codigo);

        [OperationContract]
        TERCEIRO SelecionaTerceiro(int Codigo);

        [OperationContract]
        List<PONTOCONTROLE> ListarTodosPontosControle();

        [OperationContract]
        List<PONTOCONTROLE> ListarPontosControle(char Tipo);
    }
}
