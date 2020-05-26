using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public class MyGlobal
    {
        private static string strConnectionString = "SERVER=RES234312;DATABASE=ACESSO;UID=sa;PWD=$ic@p000";
        public static string ConnectionString
        {
            get { return strConnectionString; }
            set { strConnectionString = value; }
        }

    }
}
