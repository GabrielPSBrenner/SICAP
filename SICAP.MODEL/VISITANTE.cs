using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class VISITANTE
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(VISITANTE oVISITANTE, DataContext MyDb)
        {
            MyDb.VISITANTEs.InsertOnSubmit(oVISITANTE);
        }

        public static void Incluir(VISITANTE oVISITANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oVISITANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(VISITANTE oVISITANTE, DataContext MyDb)
        {
            MyDb.VISITANTEs.Attach(oVISITANTE, true);
        }

        public static void Alterar(VISITANTE oVISITANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oVISITANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pViCodigo, DataContext MyDB)
        {
            VISITANTE oVISITANTE = default(VISITANTE);
            dynamic res = from p in MyDB.VISITANTEs where p.ViCodigo == pViCodigo select p;
            if (res.Count() > 0)
            {
                oVISITANTE = res.First();
                MyDB.VISITANTEs.DeleteOnSubmit(oVISITANTE);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pViCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            VISITANTE oVISITANTE = default(VISITANTE);
            dynamic res = from p in db.VISITANTEs where p.ViCodigo == pViCodigo select p;
            if (res.Count() > 0)
            {
                oVISITANTE = res.First();
                db.VISITANTEs.DeleteOnSubmit(oVISITANTE);
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

        public static void Excluir(VISITANTE oVISITANTE, DataContext MyDb)
        {
            MyDb.VISITANTEs.Attach(oVISITANTE);
            MyDb.VISITANTEs.DeleteOnSubmit(oVISITANTE);
        }
        public static void Excluir(VISITANTE oVISITANTE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oVISITANTE, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<VISITANTE> ListarTodos(DataContext MyDB)
        {
            List<VISITANTE> oLista = new List<VISITANTE>();
            dynamic res = from p in MyDB.VISITANTEs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<VISITANTE> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static VISITANTE SelecionaPK(int pViCodigo, DataContext MyDB = null)
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
            VISITANTE oVISITANTE = default(VISITANTE);
            dynamic res = (from p in db.VISITANTEs where p.ViCodigo == pViCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oVISITANTE = res.First();
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
            return oVISITANTE;
        }

        #endregion

    }
}
