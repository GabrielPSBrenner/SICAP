using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class USUARIO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(USUARIO oUSUARIO, DataContext MyDb)
        {
            MyDb.USUARIOs.InsertOnSubmit(oUSUARIO);
        }

        public static USUARIO SelecionaUsuario(char Tipo, int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var Retorno = SelecionaUsuario(db, Tipo, Codigo);
            db.Dispose();
            return Retorno;
        }

        public static USUARIO SelecionaUsuario(DataContext db, char Tipo, int Codigo)
        {
            IQueryable<USUARIO> Res;
            if (Tipo == char.Parse("E"))
            {
                //empregado
                Res = from p in db.USUARIOs where p.USMATFUNC == Codigo select p;
            }
            else if (Tipo == char.Parse("S"))
            {
                //estagiário
                Res = from p in db.USUARIOs where p.USCODIGOESTAGIARIO == Codigo select p;
            }
            else if (Tipo == char.Parse("T"))
            {
                //terceirizado 
                Res = from p in db.USUARIOs where p.USCODIGOTERCEIRO == Codigo select p;

            }
            else //if (Tipo == char.Parse("V"))
            {
                //visitante
                Res = from p in db.USUARIOs where p.USCODIGOVISITANTE == Codigo select p;
            }
            USUARIO retorno = null;
            if (Res.Count() > 0)
            {
                retorno = Res.First();
            }
            return retorno;
        }

        public static List<USUARIO> UsuariosTipo(char Tipo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            IQueryable<USUARIO> Res;
            if (Tipo == char.Parse("E"))
            {
                //empregado
                Res = from p in db.USUARIOs where p.USMATFUNC != null select p;
            }
            else if (Tipo == char.Parse("S"))
            {
                //estagiário
                Res = from p in db.USUARIOs where p.USCODIGOESTAGIARIO != null select p;
            }
            else if (Tipo == char.Parse("T"))
            {
                //terceirizado 
                Res = from p in db.USUARIOs where p.USCODIGOTERCEIRO != null select p;

            }
            else //if (Tipo == char.Parse("V"))
            {
                //visitante
                Res = from p in db.USUARIOs where p.USCODIGOVISITANTE != null select p;
            }
            var retorno = Res.ToList();
            db.Dispose();
            return retorno;
        }

        public static int Incluir(USUARIO oUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
            return oUSUARIO.USCODIGO;
        }

        public static void Alterar(USUARIO oUSUARIO, DataContext MyDb)
        {
            MyDb.USUARIOs.Attach(oUSUARIO, true);
        }

        public static void Alterar(USUARIO oUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pUSCODIGO, DataContext MyDB)
        {
            USUARIO oUSUARIO = default(USUARIO);
            dynamic res = from p in MyDB.USUARIOs where p.USCODIGO == pUSCODIGO select p;
            if (res.Count() > 0)
            {
                oUSUARIO = res.First();
                MyDB.USUARIOs.DeleteOnSubmit(oUSUARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pUSCODIGO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            USUARIO oUSUARIO = default(USUARIO);
            dynamic res = from p in db.USUARIOs where p.USCODIGO == pUSCODIGO select p;
            if (res.Count() > 0)
            {
                oUSUARIO = res.First();
                db.USUARIOs.DeleteOnSubmit(oUSUARIO);
                db.SubmitChanges();
                db.Dispose();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
            db.Dispose();
        }

        public static void Excluir(USUARIO oUSUARIO, DataContext MyDb)
        {
            MyDb.USUARIOs.Attach(oUSUARIO);
            MyDb.USUARIOs.DeleteOnSubmit(oUSUARIO);
        }
        public static void Excluir(USUARIO oUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        
        public static List<USUARIO> ListarTodos(DataContext MyDB)
        {
            List<USUARIO> oLista = new List<USUARIO>();
            dynamic res = from p in MyDB.USUARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<USUARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static USUARIO SelecionaPK(int pUSCODIGO, DataContext MyDB = null)
        {
            DataContext db = default(DataContext);

            if ((MyDB != null))
            {
                db = MyDB;
            }
            else
            {
                db = new DataContext(MyGlobal.ConnectionString);
            }
            USUARIO oUSUARIO = default(USUARIO);
            var res = (from p in db.USUARIOs where p.USCODIGO == pUSCODIGO select p).ToList();
            if (res.Count() > 0)
            {
                oUSUARIO = res.First();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível selecionar o ítem, porque o mesmo não existe na base de dados.");
            }
            if (MyDB == null)
            {
                db.Dispose();
            }
            return oUSUARIO;
        }

        public static USUARIO SelecionaUsuarioRede(string CODIGO)
        {
            DataContext db = default(DataContext);

            db = new DataContext(MyGlobal.ConnectionString);
            USUARIO oUSUARIO = default(USUARIO);
            var res = (from p in db.USUARIOs where p.USUSUARIOREDE == CODIGO select p).ToList();
            if (res.Count() > 0)
            {
                oUSUARIO = res.First();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível selecionar o ítem, porque o mesmo não existe na base de dados.");
            }
            db.Dispose();
            return oUSUARIO;
        }

        public static List<vw_Digital> DigitaisUsuario(int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            List<vw_Digital> oLista = new List<vw_Digital>();            
            var res = from p in db.vw_Digitals where p.HaCodigoUsuario == Codigo select p;
            oLista = res.ToList();
            db.Dispose();
            return oLista;
        }

        public static List<vw_CartaoUsuario> CartoesUsuario(char Tipo, int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            List<vw_CartaoUsuario> oLista = new List<vw_CartaoUsuario>();
            var Usuario = SelecionaUsuario(db, Tipo, Codigo);
            var res = from p in db.vw_CartaoUsuarios where p.CSCodigoUsuario == Usuario.USCODIGO select p;
            oLista = res.ToList();
            db.Dispose();
            return oLista;
        }

        public static List<vw_RotaUsuario> RotasUsuario(char Tipo, int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            List<vw_RotaUsuario> oLista = new List<vw_RotaUsuario>();
            var Usuario = SelecionaUsuario(db, Tipo, Codigo);
            var res = from p in db.vw_RotaUsuarios where p.RUCodigoUsuario == Usuario.USCODIGO select p;
            oLista = res.ToList();         
            db.Dispose();
            return oLista;
        }

        public static bool CartaoAdicionado(int USCodigo, int CrCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.CARTAOUSUARIOs where p.CSCodigoCartao == CrCodigo && p.CSCodigoUsuario == USCodigo select p;
            bool retorno = false;
            if (res.Count() > 0)
            retorno = true;
            db.Dispose();
            return retorno;
        }

           public static bool RotaAdicionada(int RUCodigoRota, int RUCodigoUsuario)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.ROTAUSUARIOs where p.RUCodigoRota == RUCodigoRota && p.RUCodigoUsuario == RUCodigoUsuario select p;
            bool retorno = false;
            if (res.Count() > 0)
            retorno = true;
            db.Dispose();
            return retorno;
        }

        #endregion

    }
}
