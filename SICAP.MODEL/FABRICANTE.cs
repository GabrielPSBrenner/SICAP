using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class FABRICANTE
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(FABRICANTE oFABRICANTE, DataContext MyDb)
        {
            MyDb.FABRICANTEs.InsertOnSubmit(oFABRICANTE);
        }

        public static void Incluir(FABRICANTE oFABRICANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oFABRICANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(FABRICANTE oFABRICANTE, DataContext MyDb)
        {
            MyDb.FABRICANTEs.Attach(oFABRICANTE, true);
        }

        public static void Alterar(FABRICANTE oFABRICANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oFABRICANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pFaCodigo, DataContext MyDB)
        {
            FABRICANTE oFABRICANTE = default(FABRICANTE);
            var res = from p in MyDB.FABRICANTEs where p.FaCodigo == pFaCodigo select p;
            if (res.Count() > 0)
            {
                oFABRICANTE = res.First();
                MyDB.FABRICANTEs.DeleteOnSubmit(oFABRICANTE);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pFaCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            FABRICANTE oFABRICANTE = default(FABRICANTE);
            var res = from p in db.FABRICANTEs where p.FaCodigo == pFaCodigo select p;
            if (res.Count() > 0)
            {
                oFABRICANTE = res.First();
                db.FABRICANTEs.DeleteOnSubmit(oFABRICANTE);
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

        public static void Excluir(FABRICANTE oFABRICANTE, DataContext MyDb)
        {
            MyDb.FABRICANTEs.Attach(oFABRICANTE);
            MyDb.FABRICANTEs.DeleteOnSubmit(oFABRICANTE);
        }
        public static void Excluir(FABRICANTE oFABRICANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oFABRICANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<FABRICANTE> ListarTodos(DataContext MyDB)
        {
            List<FABRICANTE> oLista = new List<FABRICANTE>();
            var res = from p in MyDB.FABRICANTEs orderby p.FaNome select p;
            oLista = res.ToList();
            return oLista;
        }

        public static List<FABRICANTE> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static FABRICANTE SelecionaPK(int pFaCodigo, DataContext MyDB = null)
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
            FABRICANTE oFABRICANTE = default(FABRICANTE);
            var res = (from p in db.FABRICANTEs where p.FaCodigo == pFaCodigo  select p).ToList();
            if (res.Count > 0)
            {
                oFABRICANTE = res.First();
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
            return oFABRICANTE;
        }

        #endregion

    }
}
