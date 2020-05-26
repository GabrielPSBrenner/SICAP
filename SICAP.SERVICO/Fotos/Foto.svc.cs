using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Web.Hosting;

 

namespace ACESSO.SERVICO.Fotos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Foto" in code, svc and config file together.
    public class Foto : IFoto
    {
        #region IFoto Members

        public byte[] DownloadFile(string FName, int Tipo)
        {
            System.IO.FileStream fs1 = null;
            string Filename = HostingEnvironment.ApplicationPhysicalPath + ("\\Fotos");
            if (Tipo==0)
            {
                //Empregado
                Filename += "\\empregados\\" + FName;
            }
            else if(Tipo ==1)
            {
              //Contratado
                Filename += "\\contratados\\" + FName;
            }
            else
            {
                //Visitante
                Filename += "\\visitantes\\" + FName;
            }

            fs1 = System.IO.File.Open(Filename, FileMode.Open, FileAccess.Read);
            byte[] b1 = new byte[fs1.Length];
            fs1.Read(b1, 0, (int)fs1.Length);
            fs1.Close();
            return b1;
        }

        #endregion
    }
}
