using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTD2XX_NET;
namespace ACESSO.PONTOCONTROLE.Classes
{
    public class Codigos
    {
        public static readonly byte Inicia = 240;
        public static readonly byte LigaRele1 = 1;
        public static readonly byte LigaRele2 = 2;
        public static readonly byte LigaRele3 = 4;
        public static readonly byte LigaRele4 = 8;
        public static readonly byte DesLigaRele1 = 254;
        public static readonly byte DesLigaRele2 = 253;
        public static readonly byte DesLigaRele3 = 251;
        public static readonly byte DesLigaRele4 = 247;
    }

    public class Tipos
    {
        public static readonly int Inicia = 0;
        public static readonly int Finaliza = 1;
        public static readonly int Liga = 2;
        public static readonly int Desliga = 3;
    }

    public class nseUSB2E2S
    {
        byte saida = 0;
        public uint[] getListLocIdPlacas()
        {
            FTD2XX_NET.FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            uint ftdiDeviceCount = 0;
            FTDI acesso = new FTDI();
            acesso.GetNumberOfDevices(ref ftdiDeviceCount);
            FTDI.FT_DEVICE_INFO_NODE[] infos = new FTDI.FT_DEVICE_INFO_NODE[ftdiDeviceCount];
            acesso.GetDeviceList(infos);
            uint[] placas = new uint[ftdiDeviceCount];
            for (int c = 0; c < infos.Length; c++)
            {
                placas[c] = infos[c].LocId;
                executaComando(infos[c].LocId, Tipos.Inicia, Codigos.Inicia);
            }

            return placas;
        }

        public void executaComando(uint location, int tp, byte idRele)
        {
            FTDI acesso = new FTDI();
            FTD2XX_NET.FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            ftStatus = acesso.OpenByLocation(location);


            if (tp == Tipos.Inicia || tp == Tipos.Finaliza)
                saida = idRele;
            else if (tp == Tipos.Liga)
                saida = (byte)(saida | idRele);
            else
                saida = (byte)(saida & idRele);

            ftStatus = acesso.SetBitMode(saida, FTDI.FT_BIT_MODES.FT_BIT_MODE_CBUS_BITBANG);
            ftStatus = acesso.Close();
        }
    }
}
