using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class vw_Acesso
    {

        public static List<vw_Acesso> SelecionaAcessos(DateTime DataInicio, DateTime DataFim, string TipoPonto, int PontoControle, string TipoAcesso, int TipoUsuario, int CodigoUsuario)
        {
            DataContext db = default(DataContext);
            db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.vw_Acessos where p.APDataAcesso >= DataInicio && p.APDataAcesso <= DataFim select p;
            if (TipoPonto.Trim() != "")
                res = res.Where(p => p.APTipoPontoControle == char.Parse(TipoPonto));
            if (PontoControle > 0)
                res = res.Where(p => p.APCodigoPontoControle == PontoControle);
            switch (TipoAcesso)
            {
                case "FORÇADOS":
                    {
                        res = res.Where(p => p.APCodigoUsuarioLiberaForcado != null);
                        break;
                    }
                case "PERMITIDOS":
                    {
                        res = res.Where(p => p.APCodigoUsuarioLiberaForcado == null && p.APNegado == false);
                        break;
                    }
                case "NEGADOS":
                    {
                        res = res.Where(p => p.APNegado == true);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            switch (TipoUsuario)
            {
                case 1:
                    {
                        if (CodigoUsuario > 0)
                        {
                            res = res.Where(p => p.USCODIGOTERCEIRO == CodigoUsuario);
                        }
                        else
                        {
                            res = res.Where(p => p.USCODIGOTERCEIRO != null);
                        }
                        break;
                    }
                case 2:
                    {
                        if (CodigoUsuario > 0)
                        {
                            res = res.Where(p => p.USMATFUNC == CodigoUsuario);
                        }
                        else
                        {
                            res = res.Where(p => p.USMATFUNC != null);
                        }
                        break;
                    }
                case 3:
                    {
                        if (CodigoUsuario > 0)
                        {
                            res = res.Where(p => p.USCODIGOESTAGIARIO == CodigoUsuario);
                        }
                        else
                        {
                            res = res.Where(p => p.USCODIGOESTAGIARIO != null);
                        }
                        break;
                    }
                case 4:
                    {
                        if (CodigoUsuario > 0)
                        {
                            res = res.Where(p => p.USCODIGOVISITANTE == CodigoUsuario);
                        }
                        else
                        {
                            res = res.Where(p => p.USCODIGOVISITANTE != null);
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            List<vw_Acesso> oRetorno;
            oRetorno = res.ToList();
            db.Dispose();
            return oRetorno;
        }


        public static vw_Acesso SelecionaPK(int APCodigo)
        {
            DataContext db = default(DataContext);
            db = new DataContext(MyGlobal.ConnectionString);

            vw_Acesso ovw_Acesso = null;
            var res = (from p in db.vw_Acessos where p.APCodigo == APCodigo select p).ToList();
            if (res.Count() > 0)
            {
                ovw_Acesso = res.First();
            }
            db.Dispose();
            return ovw_Acesso;
        }

    }
}
