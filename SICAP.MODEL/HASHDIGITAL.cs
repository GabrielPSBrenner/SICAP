using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class HASHDIGITAL
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(HASHDIGITAL oHASHDIGITAL, DataContext MyDb)
        {
            MyDb.HASHDIGITALs.InsertOnSubmit(oHASHDIGITAL);
        }

        public static void Incluir(HASHDIGITAL oHASHDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oHASHDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(HASHDIGITAL oHASHDIGITAL, DataContext MyDb)
        {
            MyDb.HASHDIGITALs.Attach(oHASHDIGITAL, true);
        }

        public static void Alterar(HASHDIGITAL oHASHDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oHASHDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pHaCodigo, DataContext MyDB)
        {
            HASHDIGITAL oHASHDIGITAL = default(HASHDIGITAL);
            var res = from p in MyDB.HASHDIGITALs where p.HaCodigo == pHaCodigo select p;
            if (res.Count() > 0)
            {
                oHASHDIGITAL = res.First();
                MyDB.HASHDIGITALs.DeleteOnSubmit(oHASHDIGITAL);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pHaCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            HASHDIGITAL oHASHDIGITAL = default(HASHDIGITAL);
            var res = from p in db.HASHDIGITALs where p.HaCodigo == pHaCodigo select p;
            if (res.Count() > 0)
            {
                oHASHDIGITAL = res.First();
                db.HASHDIGITALs.DeleteOnSubmit(oHASHDIGITAL);
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

        public static void Excluir(HASHDIGITAL oHASHDIGITAL, DataContext MyDb)
        {
            MyDb.HASHDIGITALs.Attach(oHASHDIGITAL);
            MyDb.HASHDIGITALs.DeleteOnSubmit(oHASHDIGITAL);
        }
        public static void Excluir(HASHDIGITAL oHASHDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oHASHDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<HASHDIGITAL> ListarTodos(DataContext MyDB)
        {
            List<HASHDIGITAL> oLista = new List<HASHDIGITAL>();
            var res = from p in MyDB.HASHDIGITALs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<HASHDIGITAL> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }

        public static List<HASHDIGITAL> HashUsuario(int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.HASHDIGITALs where p.HaCodigoUsuario == Codigo select p;
            var oLista = res.ToList();
            db.Dispose();
            return oLista;
        }


        public static HASHDIGITAL SelecionaPK(int pHaCodigo, DataContext MyDB = null)
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
            HASHDIGITAL oHASHDIGITAL = default(HASHDIGITAL);
            var res = (from p in db.HASHDIGITALs where p.HaCodigo == pHaCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oHASHDIGITAL = res.First();
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
            return oHASHDIGITAL;
        }

        #endregion

    }
}
