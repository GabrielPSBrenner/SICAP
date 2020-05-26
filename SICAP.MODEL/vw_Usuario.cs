using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class vw_Usuario
    {
        public static vw_Usuario SelecionaPK(int UsCodigo)
        {
            DataContext db = default(DataContext);            
            db = new DataContext(MyGlobal.ConnectionString);

            vw_Usuario oUsuario = null;
            var res = (from p in db.vw_Usuarios where p.USCODIGO == UsCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oUsuario = res.First();
            }            
            db.Dispose();
            return oUsuario;
        }
    }
}
