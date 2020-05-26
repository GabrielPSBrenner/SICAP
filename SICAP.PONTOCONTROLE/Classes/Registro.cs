using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ACESSO.PONTOCONTROLE.Classes
{
    public class Registro
    {

        public static int CodigoPonto()
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO");
            if (Chave == null)
            {
                return 0;
            }
            else
            {
                int retorno = (int)Chave.GetValue("CodigoPonto");
                return retorno;
            }
        }

        public static string Tipo()
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO");
            if (Chave == null)
            {
                return "";
            }
            else
            {
                string retorno = (string)Chave.GetValue("Tipo");
                return retorno;
            }
        }

        public static int PortaSirene()
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO");
            if (Chave == null)
            {
                return 0;
            }
            else
            {
                int retorno = (int)Chave.GetValue("Sirene");
                return retorno;
            }
        }

        public static int PortaTranca()
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO");
            if (Chave == null)
            {
                return 0;
            }
            else
            {
                int retorno = (int)Chave.GetValue("Tranca");
                return retorno;
            }
        }

        public static string PortaSerial()
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO");
            if (Chave == null)
            {
                return "";
            }
            else
            {
                string retorno = Chave.GetValue("PortaSerial").ToString();
                return retorno;
            }
        }

        public static RegistryKey GravaChavePonto(int Codigo, string Tipo, int PortaTranca, int PortaSirene, string PortaSerial)
        {
            RegistryKey Chave = Registry.LocalMachine.OpenSubKey("Software\\ACESSO", true);
            if (Chave == null)
            {
                Chave = Registry.LocalMachine.CreateSubKey("Software\\ACESSO");
            }
            Chave.SetValue("CodigoPonto", Codigo);
            Chave.SetValue("Tipo", Tipo);
            Chave.SetValue("Sirene", PortaSirene);
            Chave.SetValue("Tranca", PortaTranca);
            Chave.SetValue("PortaSerial", PortaSerial);
            return Chave;
        }

      
    }
}
