using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class vw_TotalAcessoPontoDia
    {
        public static List<vw_TotalAcessoPontoDia> ListaTotalAcessoPontoDia()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.vw_TotalAcessoPontoDias orderby p.ANO, p.MÊS, p.DIA select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }

        public static List<vw_TotalAcessoPontoDia> ListaTotalAcessoPontoDia(DateTime DataInicio ,DateTime DataFim )
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.vw_TotalAcessoPontoDias where (p.ANO >= DataInicio.Year && p.MÊS >= DataInicio.Month && p.DIA >= DataInicio.Day) && (p.ANO<=DataFim.Year && p.MÊS <= DataFim.Month && p.DIA <= DataFim.Day) orderby p.ANO, p.MÊS, p.DIA select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }
    }

}
