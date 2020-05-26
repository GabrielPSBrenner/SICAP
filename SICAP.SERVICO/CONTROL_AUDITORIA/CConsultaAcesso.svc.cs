using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ACESSO.MODEL;

namespace ACESSO.SERVICO.CONTROL_AUDITORIA
{
    public class CConsultaAcesso : ICConsultaAcesso
    {
        public List<vw_Acesso> SelecionaAcessos(DateTime DataInicio, DateTime DataFim, string TipoPonto, int PontoControle, string TipoAcesso, int TipoUsuario, int CodigoUsuario)
        {
            return vw_Acesso.SelecionaAcessos(DataInicio, DataFim, TipoPonto, PontoControle, TipoAcesso, TipoUsuario, CodigoUsuario);
        }        
    }
}
