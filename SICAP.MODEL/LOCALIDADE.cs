using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class LOCALIDADE
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(LOCALIDADE oLOCALIDADE, DataContext MyDb)
        {
            MyDb.LOCALIDADEs.InsertOnSubmit(oLOCALIDADE);
        }

        public static void Incluir(LOCALIDADE oLOCALIDADE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oLOCALIDADE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(LOCALIDADE oLOCALIDADE, DataContext MyDb)
        {
            MyDb.LOCALIDADEs.Attach(oLOCALIDADE, true);
        }

        public static void Alterar(LOCALIDADE oLOCALIDADE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oLOCALIDADE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pLoCodigo, DataContext MyDB)
        {
            LOCALIDADE oLOCALIDADE = default(LOCALIDADE);
            var res = from p in MyDB.LOCALIDADEs where p.LoCodigo == pLoCodigo select p;
            if (res.Count() > 0)
            {
                oLOCALIDADE = res.First();
                MyDB.LOCALIDADEs.DeleteOnSubmit(oLOCALIDADE);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pLoCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            LOCALIDADE oLOCALIDADE = default(LOCALIDADE);
            var res = from p in db.LOCALIDADEs where p.LoCodigo == pLoCodigo select p;
            if (res.Count() > 0)
            {
                oLOCALIDADE = res.First();
                db.LOCALIDADEs.DeleteOnSubmit(oLOCALIDADE);
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

        public static void Excluir(LOCALIDADE oLOCALIDADE, DataContext MyDb)
        {
            MyDb.LOCALIDADEs.Attach(oLOCALIDADE);
            MyDb.LOCALIDADEs.DeleteOnSubmit(oLOCALIDADE);
        }
        public static void Excluir(LOCALIDADE oLOCALIDADE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oLOCALIDADE, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<LOCALIDADE> ListarTodos(DataContext MyDB)
        {
            List<LOCALIDADE> oLista = new List<LOCALIDADE>();
            var res = from p in MyDB.LOCALIDADEs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<LOCALIDADE> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static LOCALIDADE SelecionaPK(int pLoCodigo, DataContext MyDB = null)
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
            LOCALIDADE oLOCALIDADE = default(LOCALIDADE);
            var res = (from p in db.LOCALIDADEs where p.LoCodigo == pLoCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oLOCALIDADE = res.First();
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
            return oLOCALIDADE;
        }

        #endregion

    }
}
